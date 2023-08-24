#if NET6_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using TipsTrade.KashFlow.v2.Model;

namespace TipsTrade.KashFlow.v2 {
  /// <summary>Represents the REST API client.</summary>
  public class KashFlowRestClient {
    #region Fields
    private const string BaseUrl = "https://api.kashflow.com/v2/";

    private readonly HttpClient Client = new HttpClient { BaseAddress = new Uri(BaseUrl), Timeout = new TimeSpan(0, 1, 0) };

    private string memorableWord;

    private string password;

    private string username;
    #endregion

    #region Properties
    private bool IsAuthenticated => Client.DefaultRequestHeaders.Authorization != null;

    /// <summary>The memorable word used for authentication.</summary>
    public string MemorableWord {
      get => memorableWord;
      set {
        memorableWord = value;
        InvalidateSession();
      }
    }

    /// <summary>The username used for authentication.</summary>
    public string Password {
      get => password;
      set {
        password = value;
        InvalidateSession();
      }
    }

    internal string? SessionToken {
      set {
        if (value == null) {
          Client.DefaultRequestHeaders.Authorization = null;
        } else {
          Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("KfToken", value);
        }
      }
    }

    /// <summary>The password used for authentication.</summary>
    public string UserName {
      get => username;
      set {
        username = value;
        InvalidateSession();
      }
    }

    /// <summary>The timeout for any HTTP requests.</summary>
    public TimeSpan Timeout {
      get {
        return Client.Timeout;
      }
      set {
        Client.Timeout = value;
      }
    }
    #endregion

    #region Constructors
    /// <summary>Creates and instance of the <see cref="KashFlowRestClient"/></summary>
    public KashFlowRestClient(string userName = "", string password = "", string memorableWord = "") {
      UserName = userName;
      Password = password;
      MemorableWord = memorableWord;
    }
    #endregion

    #region Internal Methods
    private async Task Authenticate(CancellationToken cancellationToken = default) {
      // Authentication is a 2-step process
      // See: https://www.kashflow.com/developers/rest-api/sessiontoken/

      var route = new[] { "sessiontoken" };

      var response1 = await ExecuteObjectRequestAsync<Login1Response>(new RequestArgs<Login1Request>(route) {
        Method = HttpMethod.Post,
        Payload = new Login1Request { UserName = UserName, Password = Password }
      }, cancellationToken);

      var response2 = await ExecuteObjectRequestAsync<Login2Response>(new RequestArgs<Login2Request>(route) {
        Method = HttpMethod.Put,
        Payload = new Login2Request {
          MemorableWordList = response1.MemorableWordList.FromWord(MemorableWord),
          TemporaryToken = response1.TemporaryToken
        }
      }, cancellationToken);

      SessionToken = response2.SessionToken;
    }

    private Task<JsonElement> ExecuteObjectRequestAsync(RequestArgs request, CancellationToken cancellationToken = default) {
      return ExecuteObjectRequestAsync<JsonElement>(request, cancellationToken);
    }

    private async Task<T> ExecuteObjectRequestAsync<T>(RequestArgs request, CancellationToken cancellationToken = default) {
      using var response = await ExecuteRequestAsync(request, cancellationToken);

      if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
        return default;
      }

      var json = await response.Content.ReadAsStringAsync();

      try {
        return JsonSerializer.Deserialize<T>(json) ?? throw new InvalidOperationException("The API returned a null JSON string.");
      } catch {
        throw;
      }

      return await response.Content.ReadFromJsonAsync<T>() ?? throw new InvalidOperationException("The API returned a null JSON string.");
    }

    private async Task<Stream> ExecuteStreamRequestAsync(RequestArgs request, CancellationToken cancellationToken = default) {
      using var response = await ExecuteRequestAsync(request, cancellationToken);
      using var str = await response.Content.ReadAsStreamAsync(cancellationToken);
      var ms = new MemoryStream();

      await str.CopyToAsync(ms, cancellationToken);

      ms.Position = 0;

      return ms;
    }

    private async Task<HttpResponseMessage> ExecuteRequestAsync(RequestArgs request, CancellationToken cancellationToken = default) {
      if (!IsAuthenticated && !request.Route.Contains("sessiontoken")) {
        await Authenticate(cancellationToken);
      }

      HttpRequestMessage httpRequest = request;

      var response = await Client.SendAsync(httpRequest, cancellationToken);

      if (!response.IsSuccessStatusCode) {
        var error = await response.Content.ReadAsStringAsync(cancellationToken);

        throw new Exception($"Failed with {response.StatusCode}");
      }

      return response;
    }

    private void InvalidateSession() {
      SessionToken = null;
    }
    #endregion

    #region API methods
    /// <summary>Archvies the specified list of customers.</summary>
    public Task ArchiveCustomers(params string[] codes) => ArchiveCustomers(codes.AsEnumerable());

    /// <summary>Archvies the specified list of customers.</summary>
    public async Task ArchiveCustomers(IEnumerable<string> codes) {
      var req = new RequestArgs<IEnumerable<string>>("internal", "customers", "archive") {
        Method = HttpMethod.Put,
        Payload = codes
      };

      await ExecuteObjectRequestAsync(req);
    }

    /// <summary>Archvies the specified list of suppliers.</summary>
    public Task ArchiveSuppliers(params string[] codes) => ArchiveSuppliers(codes.AsEnumerable());

    /// <summary>Archvies the specified list of suppliers.</summary>
    public async Task ArchiveSuppliers(IEnumerable<string> codes) {
      var req = new RequestArgs<IEnumerable<string>>("internal", "suppliers", "archive") {
        Method = HttpMethod.Put,
        Payload = codes
      };

      await ExecuteObjectRequestAsync(req);
    }

    /// <summary>Gets the specified bulk payment.</summary>
    private Task<BulkPayment> GetBulkPaymentAsync(string type, int number) {
      return ExecuteObjectRequestAsync<BulkPayment>(new RequestArgs(type, "bulk", "payments", $"{number}"));
    }

    /// <summary>Gets the specified invoice <see cref="BulkPayment"/>.</summary>
    public Task<BulkPayment> GetInvoiceBulkPayment(int number) => GetBulkPaymentAsync("invoices", number);

    /// <summary>Gets the specified <see cref="Invoice"/>.</summary>
    public Task<Invoice> GetInvoiceAsync(int number) {
      return ExecuteObjectRequestAsync<Invoice>(new RequestArgs("invoices", $"{number}"));
    }

    /// <summary>Gets the collection of <see cref="Invoice"/> objects.</summary>
    public async IAsyncEnumerable<Invoice> GetInvoicesAsync(PurchaseRequest request) {
      var query = request.ToDictionary();
      var page = request.Page;

      do {
        var response = await ExecuteObjectRequestAsync<PaginatedResponse<Invoice>>(new RequestArgs("invoices") {
          Query = query
        });

        foreach (var item in response.Data) {
          yield return item;
        }

        if (response.MetaData.NextPageUrl == null) {
          break;
        }

        query["page"] = ++page;
      } while (true);
    }

    /// <summary>Gets the specified purchase <see cref="BulkPayment"/>.</summary>
    public Task<BulkPayment> GetPurchaseBulkPayment(int number) => GetBulkPaymentAsync("purchases", number);

    /// <summary>Gets the specified <see cref="Purchase"/>.</summary>
    public Task<Purchase> GetPurchaseAsync(int number) {
      return ExecuteObjectRequestAsync<Purchase>(new RequestArgs("purchases", $"{number}"));
    }

    /// <summary>Gets the collection of <see cref="Purchase"/> objects.</summary>
    public async IAsyncEnumerable<Purchase> GetPurchasesAsync(PurchaseRequest request) {
      var query = request.ToDictionary();
      var page = request.Page;

      do {
        var response = await ExecuteObjectRequestAsync<PaginatedResponse<Purchase>>(new RequestArgs("purchases") {
          Query = query
        });

        foreach (var item in response.Data) {
          yield return item;
        }

        if (response.MetaData.NextPageUrl == null) {
          break;
        }

        query["page"] = ++page;
      } while (true);
    }
    #endregion

    #region Inner classes
    private class RequestArgs {
      public IApiRequest? ApiRequest { get; set; }

      public HttpMethod Method { get; set; } = HttpMethod.Get;

      public IEnumerable<string> Route { get; }

      public IDictionary<string, object>? Query { get; set; }

      public RequestArgs(params string[] route) : this(route.AsEnumerable()) {
      }

      public RequestArgs(IEnumerable<string> route) {
        Route = route;
      }

      public static implicit operator HttpRequestMessage(RequestArgs args) {
        var path = string.Join("/", args.Route);

        if (args.Query?.Any() == true || args.ApiRequest != null) {
          var query = args.Query ?? new Dictionary<string, object>();

          if (args.ApiRequest != null) {
            query = args.ApiRequest.AppendToDictionary(query);
          }

          if (query.Any()) {
            var queryString = query.Select(item => {
              string value;

              if (item.Value is DateTimeOffset || item.Value is DateTime) {
                value = $"{item.Value:o}";
              } else {
                value = $"{item.Value}";
              }

              return $"{item.Key}={HttpUtility.UrlEncode(value)}";
            });

            path += "?" + string.Join("&", queryString);
          }
        }

        var request = new HttpRequestMessage(args.Method, path);

        if (args is IRequestPayload requestPayload) {
          request.Content = requestPayload.GetContent();
        }

        return request;
      }
    }

    private interface IRequestPayload {
      HttpContent GetContent();
    }

    private class RequestArgs<T> : RequestArgs, IRequestPayload {
      public T? Payload { get; set; }

      public RequestArgs(params string[] route) : base(route) {
      }

      public RequestArgs(IEnumerable<string> route) : base(route) {
      }

      public HttpContent GetContent() {
        return new StringContent(JsonSerializer.Serialize(Payload), System.Text.Encoding.UTF8, "application/json");
      }
    }
    #endregion
  }
}
#endif