using net.tipstrade.KashFlowApiClient.KashFlowAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;

namespace net.tipstrade.KashFlowApiClient {
  /// <summary>
  /// A wrapper around the KashFlowAPISoapClient, that provides caching of credentials, as well
  /// as throwing exceptions rather than returning errors in output parameters.
  /// </summary>
  public partial class KashFlowClient {
    #region Constants
    /// <summary>
    /// Default message size is 20MB.
    /// </summary>
    private int maxReceivedMessageSize = 20 * 1024 * 1024;
    #endregion

    #region Properties
    /// <summary>
    /// Gets or sets the underlying SOAP client.
    /// </summary>
    protected KashFlowAPISoapClient Client { get; set; }

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
        OnMaxReceivedMessageSizeChanged();
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
    #endregion

    #region Constructors
    /// <summary>
    /// Creates an instance of the KashFlowClient class.
    /// </summary>
    /// <param name="username">The username used to access the KashFlow API.</param>
    /// <param name="password">The password used to access the KashFlow API.</param>
    public KashFlowClient(string username, string password) {
      if (username == null)
        throw new ArgumentNullException("username");

      if (password == null)
        throw new ArgumentNullException("password");

      Username = username;
      Password = password;

      OnMaxReceivedMessageSizeChanged();
    }
    #endregion

    #region Methods
    /// <summary>
    /// Automagically generates the method code from the KashFlowAPISoapClient.
    /// Rather than handling output parameters, it throws a KashFlowException when a method fails.
    /// </summary>
    public static string GenerateMethodCode() {
      var sb = new StringBuilder();
      sb.Append(@"using net.tipstrade.KashFlowApiClient.KashFlowAPI;
using System;

namespace net.tipstrade.KashFlowApiClient {
  public partial class KashFlowClient {
    #region Automatically generated methods
");

      var t = typeof(KashFlowAPISoapClient);
      var methods = t.GetMethods(BindingFlags.Instance | BindingFlags.Public);

      Array.Sort<MethodInfo>(methods, (a, b) => {
        return string.Compare(a.Name, b.Name);
      });

      bool hasUserName, hasPassword, hasStatus, hasStatusDetail;
      foreach (MethodInfo m in methods) {
        var parms = m.GetParameters();

        hasUserName = parms.Any(x => x.Name == "UserName");
        hasPassword = parms.Any(x => x.Name == "Password");
        hasStatus = parms.Any(x => x.Name == "Status");
        hasStatusDetail = parms.Any(x => x.Name == "StatusDetail");

        if (!hasUserName && !hasPassword && !hasStatus && !hasStatusDetail) {
          Console.Error.WriteLine("{0} doesn't contain the required parameters.", m.Name);
          continue;
        }

        sb.AppendFormat("///<summary>See https://www.kashflow.com/developers/soap-api/{0}/ </summary>\n",
          m.Name.Replace("_", "").ToLower());
        sb.AppendFormat("public {0} {1}(", m.ReturnType.Name, m.Name);

        bool first = true;
        foreach (ParameterInfo p in parms) {
          switch (p.Name.ToLower()) {
            case "username":
            case "password":
            case "status":
            case "statusdetail":
              break;

            default:
              if (!first)
                sb.Append(", ");

              if (p.IsOut) {
                sb.Append("out ");
              } else if (p.ParameterType.IsByRef) {
                sb.Append("ref ");
              }

              sb.AppendFormat("{0} {1}", p.ParameterType.Name.Replace("&", ""), p.Name);

              first = false;
              break;
          }
        }

        sb.AppendLine(") {");

        if (hasStatus)
          sb.AppendLine("\tstring status;");

        sb.AppendLine("\tstring statusDetail;");

        sb.AppendFormat("\t{0} resp = Client.{1}(\n", m.ReturnType.Name, m.Name);
        for (int i = 0; i < parms.Length; i++) {
          ParameterInfo p = parms[i];

          switch (p.Name.ToLower()) {
            case "username":
              sb.Append("\t\tUsername");
              break;

            case "password":
              sb.Append("\t\tPassword");
              break;

            case "status":
              sb.Append("\t\tout status");
              break;

            case "statusdetail":
              sb.Append("\t\tout statusDetail");
              break;

            default:
              sb.Append("\t\t");

              if (p.IsOut) {
                sb.Append("out ");
              } else if (p.ParameterType.IsByRef) {
                sb.Append("ref ");
              }

              sb.Append(p.Name);

              break;
          }

          if (i < (parms.Length - 1))
            sb.Append(",");

          sb.AppendLine();
        }
        sb.AppendLine("\t\t);");
        sb.AppendLine();

        sb.AppendLine("\tif (statusDetail != \"\")");
        sb.Append("\t\tthrow new KashFlowException(statusDetail)");
        if (hasStatus)
          sb.Append(" { Status = status }");
        sb.AppendLine(";");

        sb.AppendLine("\treturn resp;");
        sb.AppendLine("}");
        sb.AppendLine();
      }

      sb.Append(@"    #endregion
  }
}

");

      return sb.ToString();
    }

    /// <summary>
    /// Raised when the MaxReceivedMessageSize property changes.
    /// </summary>
    protected void OnMaxReceivedMessageSizeChanged() {
      Client = new KashFlowAPISoapClient(
        new BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode.Transport) {
          MaxReceivedMessageSize = MaxReceivedMessageSize,
        },
        new EndpointAddress("https://securedwebapp.com/api/service.asmx")
        );
    }
    #endregion
  }
}
