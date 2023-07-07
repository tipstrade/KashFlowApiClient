using Microsoft.Extensions.Configuration;
using TipsTrade.KashFlow;
using TipsTrade.KashFlow.KashFlowAPI;

namespace Test_net6 {
  internal class Program {
    static async Task Main(string[] args) {
      var config = new ConfigurationBuilder()
        .AddUserSecrets<Program>()
        .Build()
        ;

      var api = new KashFlowClient(config["UserName"], config["Password"]);

      var cancellationToken = new CancellationTokenSource();
      cancellationToken.CancelAfter(5000);

      var reciptsTask = await api.GetReceiptsAsync(ReceiptFilterType.All, 100, cancellationToken.Token).ToArrayAsync();

      //var firstN = await api.GetReceiptsAsync(ReceiptFilterType.All)
      //  .Where(x => x.Lines.Count() > 1)
      //  .Take(250)
      //  .ToArrayAsync();

      //var receipts = await api.FindReceiptsAsync(x => {
      //  return x.Paid == 0;
      //});

      //var tasks = new[] {
      //  api.GetReceiptsAsync(ReceiptFilterType.Unpaid).ToArrayAsync().AsTask(),
      //  api.GetReceiptsAsync(ReceiptFilterType.Overdue).ToArrayAsync().AsTask(),
      //  //api.GetReceiptsAsync(ReceiptFilterType.Overpaid).ToArrayAsync().AsTask()
      //};

      //var items = (await Task.WhenAll(tasks))
      //  .SelectMany(x=> x)
      //  .DistinctBy(x=> x.InvoiceDBID)
      //  ;

      //var recipts = await api.GetReceiptsAsync(ReceiptFilterType.Unpaid)
      //  .ToArrayAsync()
      //  ;

      //var payments = await api.GetInvoicePaymentsAsync(new DateTime(2023, 1, 1))
      //  .Take(250)
      //  .ToArrayAsync()
      //  ;

      var invoices = await api.GetInvoices_UnpaidAsync(new GetInvoices_UnpaidRequest());

      Console.WriteLine("Hello, World!");
    }
  }
}