#if NET6_0_OR_GREATER
using System.Collections.Generic;

namespace TipsTrade.KashFlow.v2.Model {
  internal class Login1Request {
    public string Password { get; set; }

    public string UserName { get; set; }
  }

  internal class Login2Request {
    public string TemporaryToken { get; set; }
    public IEnumerable<MemorableWordItem> MemorableWordList { get; set; }
  }

  internal class MemorableWordItem {
    public int Position { get; set; }
    public string Value { get; set; }
  }

  internal class Login1Response {
    public bool HasTemporaryPassword { get; set; }
    public bool IsAdmin { get; set; }
    public string PackageName { get; set; }
    public bool PartnerBrandingOptOut { get; set; }
    public IEnumerable<MemorableWordItem> MemorableWordList { get; set; }
    public int PartnerId { get; set; }
    public bool SubscriptionExpired { get; set; }
    public string TemporaryToken { get; set; }
  }

  internal class Login2Response {
    public string CompanyName { get; set; }
    public bool IsAdmin { get; set; }
    public bool SubscriptionExpired { get; set; }
    public int PartnerId { get; set; }
    public string PackageName { get; set; }
    public bool PartnerBrandingOptOut { get; set; }
    public string SessionToken { get; set; }
    public string StartPageUrl { get; set; }
    public string SubscriptionExpiryDate { get; set; }
    public bool HasTemporaryPassword { get; set; }
  }
}
#endif