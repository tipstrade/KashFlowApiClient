using TipsTrade.KashFlow.KashFlowAPI;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;

namespace TipsTrade.KashFlow {
  /// <summary>
  /// A wrapper around the KashFlowAPISoapClient, that provides caching of credentials, as well
  /// as throwing exceptions rather than returning errors in output parameters.
  /// </summary>
  public partial class KashFlowClient
#if NET45
:    Component
#endif
    {
    #region Constants
    /// <summary>
    /// Default message size is 20MB.
    /// </summary>
    private int maxReceivedMessageSize = 20 * 1024 * 1024;

    /// <summary>
    /// The default timeout is 1 minute.
    /// </summary>
    private TimeSpan timeout = new TimeSpan(0, 1, 0);
    #endregion

    #region Properties
    /// <summary>
    /// Gets or sets the underlying SOAP client.
    /// </summary>
    public KashFlowAPISoapClient Client { get; protected set; }

    /// <summary>
    /// Gets the maximum message size that can be received by the underlying SOAP client.
    /// </summary>
    [DefaultValue(20 * 1024 * 1024)]
    public int MaxReceivedMessageSize {
      get {
        return maxReceivedMessageSize;
      }
      set {
        if (value < 0)
          throw new ArgumentException(string.Format("{0} is not a valid value.", value));

        maxReceivedMessageSize = value;
        OnClientOptionsChanged();
      }
    }

    /// <summary>
    /// Gets or sets the password used to access the KashFlow API.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets the username used to access the KashFlow API.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the interval of time provided for a connection to open, close, receive or send before the transport raises an exception.
    /// </summary>
    [DefaultValue(typeof(TimeSpan), "00:01:00")]
    public TimeSpan Timeout {
      get {
        return timeout;
      }
      set {
        timeout = value;
        OnClientOptionsChanged();
      }
    }
    #endregion

    #region Constructors
    /// <summary>
    /// Creates an instance of the KashFlowClient class with no credentials.
    /// </summary>
    public KashFlowClient()
      : this(null, null) {
    }

    /// <summary>
    /// Creates an instance of the KashFlowClient class.
    /// </summary>
    /// <param name="username">The username used to access the KashFlow API.</param>
    /// <param name="password">The password used to access the KashFlow API.</param>
    /// <param name="timeout">An optional value for the underlying SOAP client's timeout.</param>
    public KashFlowClient(string username, string password, TimeSpan? timeout = null) {
      Username = username;
      Password = password;
      Timeout = timeout ?? Timeout;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Automagically generates the method code from the KashFlowAPISoapClient.
    /// Rather than handling output parameters, it throws a KashFlowException when a method fails.
    /// </summary>
    public static string GenerateMethodCode() {
      var sb = new StringBuilder();
      sb.Append(@"using TipsTrade.KashFlow.KashFlowAPI;
using System;
using System.Threading.Tasks;

namespace TipsTrade.KashFlow {
  public partial class KashFlowClient {
#region Automatically generated methods
#pragma warning disable IDE0018, IDE1006
");

      var t = typeof(KashFlowAPISoapClient);
      var methods = t.GetMethods(BindingFlags.Instance | BindingFlags.Public)
        .Where(m => m.Name.EndsWith("Async"))
        .OrderBy(m => m.Name);

      foreach (MethodInfo m in methods) {
        var requestParam = m.GetParameters().FirstOrDefault();
        if (requestParam == null) continue;

        var responseObjectType = m.ReturnType.GenericTypeArguments.First(); // The type of object returned
        var responseObjectValueName = m.Name.Replace("Async", "Result"); // The name of field in the response that contains the actual result
        var responseType = responseObjectType.GetField(responseObjectValueName)?.FieldType ?? null; // The type of object that is returned

        // The warns if extra fields are returned
        var responseObjectFields = responseObjectType.GetFields().Where(f => {
          return f.Name != responseObjectValueName && f.Name != "Status" && f.Name != "StatusDetail";
        });

        var asyncResponseName = responseType == null ? "Task" : $"Task<{responseType}>";
        var syncResponseName = responseType == null ? "void" : $"{responseType}";

        // Provide sync methods for the Net45 build
        sb.AppendLine("#if NET45");
        sb.AppendFormat("///<summary>See https://www.kashflow.com/developers/soap-api/{0}/ </summary>\n",
          m.Name.Replace("_", "").Replace("Async", "").ToLower());
        sb.AppendLine($"public {syncResponseName} {m.Name.Replace("Async", "")}({requestParam.ParameterType.Name} request) {{");
        if (responseType == null) {
          sb.AppendLine($"Task.Run(async () => await {m.Name}(request)).Wait();");
        } else {
          sb.AppendLine($"return Task.Run(async () => await {m.Name}(request)).Result;");
        }
        sb.AppendLine("}");
        sb.AppendLine("#endif");
        sb.AppendLine();

        // The Async Method
        sb.AppendFormat("///<summary>See https://www.kashflow.com/developers/soap-api/{0}/ </summary>\n",
          m.Name.Replace("_", "").Replace("Async", "").ToLower());
        sb.AppendLine($"public async {asyncResponseName} {m.Name}({requestParam.ParameterType.Name} request) {{");

        if (responseObjectFields.Count() != 0) {
          sb.AppendLine("int i = null;");
        }

        // Because there's no consistency in the case
        var requestParamFields = requestParam.ParameterType.GetFields();
        var usernameField = requestParamFields.Where(p => p.Name.ToLower() == "username").FirstOrDefault();
        var passwordField = requestParamFields.Where(p => p.Name.ToLower() == "password").FirstOrDefault();
        if (usernameField != null) {
          sb.AppendLine($"if (string.IsNullOrEmpty(request.{usernameField.Name})) request.{usernameField.Name} = Username;");
        }
        if (passwordField != null) {
          sb.AppendLine($"if (string.IsNullOrEmpty(request.{passwordField.Name})) request.{passwordField.Name} = Password;");
        }
        if ((usernameField != null) || (passwordField != null)) {
          sb.AppendLine();
        }

        // Make the actual request
        sb.AppendLine($"var resp = await Client.{m.Name}(request);");
        sb.AppendLine();

        // Check for any errors
        if (responseObjectType.GetField("StatusDetail") != null) {
          sb.AppendLine("if (!string.IsNullOrEmpty(resp.StatusDetail))");
          sb.AppendLine("throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };");
          sb.AppendLine();
        }

        // If there's a value to return
        if (responseType != null) {
          sb.AppendLine($"return resp.{responseObjectValueName};");
        }

        sb.AppendLine("}");
        sb.AppendLine();
      }

      sb.Append(@"#pragma warning disable IDE0018,IDE1006
#endregion
  }
}
");

      return sb.ToString();
    }

    /// <summary>
    /// Raised when any of the Client's properties changes.
    /// </summary>
    protected void OnClientOptionsChanged() {
      Client = new KashFlowAPISoapClient(
        new BasicHttpBinding(BasicHttpSecurityMode.Transport) {
          MaxReceivedMessageSize = MaxReceivedMessageSize,
          CloseTimeout = Timeout,
          OpenTimeout = Timeout,
          ReceiveTimeout = Timeout,
          SendTimeout = Timeout,
        },
        new EndpointAddress("https://securedwebapp.com/api/service.asmx")
        );
    }
    #endregion
  }
}
