#if NET6_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TipsTrade.KashFlow.KashFlowAPI;

namespace TipsTrade.KashFlow {
  /// <summary>A collection of async extension methods.</summary>
  public static class AsyncExtensionMethods {
    /// <summary>Finds the invoice payments for the specified filter.</summary>
    public static async Task<IEnumerable<Payment>> FindInvoicePaymentsAsync(this KashFlowClient client, Func<Payment, bool> predicate, DateTime? start = null, DateTime? end = null) {
      return await client.GetInvoicePaymentsAsync(start, end).Where(predicate).ToArrayAsync();
    }

    /// <summary>Finds the recipts for the specified filter.</summary>
    public static async Task<IEnumerable<Invoice>> FindReceiptsAsync(this KashFlowClient client, Func<Invoice, bool> predicate, ReceiptFilterType filter = ReceiptFilterType.All) {
      return await client.GetReceiptsAsync(filter).Where(predicate).ToArrayAsync();
    }

    /// <summary>Finds the first receipt for the specified filter.</summary>
    public static async Task<Invoice> FirstReceiptsAsync(this KashFlowClient client, Func<Invoice, bool> predicate, ReceiptFilterType filter = ReceiptFilterType.All) {
      return await client.GetReceiptsAsync(filter).FirstOrDefaultAsync(predicate);
    }

    /// <summary>Gets a collection of the invoice payments.</summary>
    public static async IAsyncEnumerable<Payment> GetInvoicePaymentsAsync(this KashFlowClient client, DateTime? start = null, DateTime? end = null) {
      var pagingRequest = new GetInvoicePaymentsByDateRangeRequest {
        EndDate = end ?? DateTime.MaxValue,
        StartDate = start ?? DateTime.MinValue,
        PageNumber = 1
      };

      while (true) {
        var results = await client.GetInvoicePaymentsByDateRangeAsync(pagingRequest);

        foreach (var item in results) {
          yield return item;
        }

        if (!results.Any()) {
          break;
        }

        pagingRequest.PageNumber++;
      }
    }

    /// <summary>Gets a collection of the recipts.</summary>
    public static async IAsyncEnumerable<Invoice> GetReceiptsAsync(this KashFlowClient client, ReceiptFilterType filter = ReceiptFilterType.All, int perPage = 100) {
      var pagingRequest = new GetReceiptsWithPagingRequest {
        FilterBy = $"{filter}",
        PerPage = perPage,
        Page = 1,
      };

      while (true) {
        var ressult = await client.GetReceiptsWithPagingAsync(pagingRequest);

        foreach (var item in ressult.Result) {
          yield return item;
        }

        pagingRequest.Page++;

        if (pagingRequest.Page > ressult.TotalPages) {
          break;
        }
      };
    }
  }
}
#endif