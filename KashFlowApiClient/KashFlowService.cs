#if NET6_0_OR_GREATER
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using TipsTrade.KashFlow.v2;

namespace TipsTrade.KashFlow {
  /// <summary>The KashFlow service.</summary>
  public class KashFlowService {
    private KashFlowClient? V1 { get; set; }

    private KashFlowRestClient? V2 { get; set; }

    private KashFlowSettings Settings { get; }

    /// <summary>Creates an instance of the <see cref="KashFlowService"/> class.</summary>
    public KashFlowService(IOptions<KashFlowSettings> options) {
      Settings = options.Value;
    }

    /// <summary>Gets V1 of the KashFlow API client.</summary>
    public async Task<KashFlowClient> GetClientV1Async() {
      if (Settings.V1 == null) {
        throw new InvalidOperationException("No settings are available.");
      }

      var client = V1;

      if (client == null) {
        client = new KashFlowClient(Settings.V1.UserName, Settings.V1.Password) {
          Timeout = new TimeSpan(0, Settings.Timeout, 0)
        };

        if (!string.IsNullOrEmpty(Settings.V1.AutoAuthKey) && !string.IsNullOrEmpty(Settings.V1.AutoAuthName)) {
          await client.AutoAuthIPAsync(new KashFlowAPI.AutoAuthIPRequest {
            appName = Settings.V1.AutoAuthName,
            AutoAuthKey = Settings.V1.AutoAuthKey,
          });
        }

        V1 = client;
      }

      return client;
    }

    /// <summary>Gets V2 of the KashFlow API client.</summary>
    public Task<KashFlowRestClient> GetClientV2Async() {
      if (Settings.V2 == null) {
        throw new InvalidOperationException("No settings are available.");
      }

      var client = V2;

      if (client == null) {
        client = new KashFlowRestClient(Settings.V2.Username, Settings.V2.Password, Settings.V2.MemorableWord) {
          Timeout = new TimeSpan(0, Settings.Timeout, 0)
        };
      }

      return Task.FromResult(client);
    }

    #region Inner classes
    /// <summary>Represents the settings for confiruring the <see cref="KashFlowService"/>.</summary>
    public class KashFlowSettings {
      /// <summary>Represents the settings for configuring V1 client.</summary>
      public V1Credentials? V1 { get; set; }

      /// <summary>The timeout (in seconds).</summary>
      public int Timeout { get; set; } = 60;

      /// <summary>Represents the settings for configuring V2 client.</summary>
      public V2Credentials? V2 { get; set; }

      /// <summary>Represents the settings for configuring V1 client.</summary>
      public class V1Credentials {
        /// <summary>The key used to configure the auto IP auth.</summary>
        public string AutoAuthKey { get; set; } = "";

        /// <summary>The name used for logging the auto IP auth.</summary>
        public string AutoAuthName { get; set; } = "";

        /// <summary>The password used for authentication.</summary>
        public string Password { get; set; } = "";

        /// <summary>The username used for authentication.</summary>
        public string UserName { get; set; } = "";
      }

      /// <summary>Represents the settings for configuring V2 client.</summary>
      public class V2Credentials {
        /// <summary>The memorable word used for authentication.</summary>
        public string MemorableWord { get; set; } = "";

        /// <summary>The password used for authentication.</summary>
        public string Password { get; set; } = "";

        /// <summary>The username used for authentication.</summary>
        public string Username { get; set; } = "";
      }
    }
    #endregion
  }

  #region Extension methods
  /// <summary>A collection of KashFlow extension methods.</summary>
  public static class KashFlowServiceExtensions {
    /// <summary>Adds the KashFlow singleton service.</summary>
    public static IServiceCollection AddKashFlow(this IServiceCollection services, Action<KashFlowService.KashFlowSettings>? setupAction = null) {
      services.AddSingleton<KashFlowService>();

      if (setupAction != null) {
        services.ConfigureKashFlow(setupAction);
      }

      return services;
    }

    /// <summary>Configures the KashFlow options.</summary>
    public static IServiceCollection ConfigureKashFlow(this IServiceCollection services, Action<KashFlowService.KashFlowSettings> setupAction) {
      return services.Configure(setupAction);
    }
  }
  #endregion
}
#endif