#if NET6_0_OR_GREATER
namespace TipsTrade.KashFlow.v2.Model {
  public class Currency {
    public string Code { get; set; }
    public bool DisplaySymbolOnRight { get; set; }
    public double ExchangeRate { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
  }
}
#endif