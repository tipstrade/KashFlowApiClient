using Microsoft.Extensions.Configuration;
using TipsTrade.KashFlow;
using TipsTrade.KashFlow.KashFlowAPI;
using TipsTrade.KashFlow.v2;
using TipsTrade.KashFlow.v2.Model;
using static TipsTrade.KashFlow.KashFlowService;

namespace Test_net6 {
  internal class Program {
    static async Task Main(string[] args) {
      var config = new ConfigurationBuilder()
        .AddUserSecrets<Program>()
        .Build()
        ;

      var settings = config.GetSection("KashFlow").Get<KashFlowSettings>();
      var v1 = new KashFlowClient(settings.V1.UserName, settings.V1.Password);
      var v2 = new KashFlowRestClient(settings.V2.Username, settings.V2.Password, settings.V2.MemorableWord);

      var allInvoices = await v2.GetInvoicesAsync(new PurchaseRequest { })
        .SelectAwait(async (x) => await v2.GetInvoiceAsync(x.Number))
        .Where(x => x.PaymentLines?.Any() == true)
        .Take(100)
        .ToArrayAsync()
        ;

      var bulkPaymentIds = allInvoices
        .Where(x => x.PaymentLines?.Any() == true)
        .SelectMany(x => x.PaymentLines!.Select(x => x.BulkPaymentNumber))
        .OfType<int>()
        .Distinct()
        .Where(x => x != 0)
        ;

      var builkPayments = await Task.WhenAll(
        bulkPaymentIds.Select(x => v2.GetInvoiceBulkPayment(x))
        );

      var carsuper = await v2.GetInvoiceBulkPayment(6250);
      var invoice = await v2.GetInvoiceAsync(carsuper.PaymentItems.First().ObjectNumber.Value);
      var inv2 = await v2.GetInvoiceAsync(3810147);

      //var foo = await api.V2.GetSubscriptionAsync();
      var purchases = await v2.GetPurchasesAsync(new PurchaseRequest {
        Suppliercode = "AMAZON01"
      }).Take(200).ToArrayAsync();

      var purchase = await v2.GetPurchaseAsync(purchases.First().Number);

      Console.WriteLine(purchase);

      //var cancellationToken = new CancellationTokenSource();
      //cancellationToken.CancelAfter(5000);

      //var reciptsTask = await api.GetReceiptsAsync(ReceiptFilterType.All, 100, cancellationToken.Token).ToArrayAsync();

      var firstN = await v1.GetReceiptsAsync(ReceiptFilterType.All)
        .Where(x => x.Lines.Count() > 1)
        .Take(250)
        .ToArrayAsync()
        ;

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

      var invoices = await v1.GetInvoices_UnpaidAsync(new GetInvoices_UnpaidRequest());

      Console.WriteLine("Hello, World!");
    }
  }
}