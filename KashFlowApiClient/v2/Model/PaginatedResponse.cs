#if NET6_0_OR_GREATER
using System.Collections.Generic;

namespace TipsTrade.KashFlow.v2.Model {
  public class PaginatedResponse<T> {
    public IEnumerable<T> Data { get; set; }
    public MetaData MetaData { get; set; }
  }

  public class MetaData {
    public string FirstPageUrl { get; set; }
    public string LastPageUrl { get; set; }
    public string NextPageUrl { get; set; }
    public object PreviousPageUrl { get; set; }
    public int TotalRecords { get; set; }
  }
}
#endif