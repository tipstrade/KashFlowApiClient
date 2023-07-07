#if NET6_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using TipsTrade.KashFlow.KashFlowAPI;

namespace TipsTrade.KashFlow {
  /// <summary>A collection of async extension methods.</summary>
  public static class AsyncExtensionMethods {
    /// <summary>Finds the invoice payments for the specified filter.</summary>
    public static async Task<IEnumerable<Payment>> FindInvoicePaymentsAsync(
      this KashFlowClient client,
      Func<Payment, bool> predicate, DateTime? start = null, DateTime? end = null,
      CancellationToken cancellationToken = default
      ) {
      return await client.GetInvoicePaymentsAsync(start, end, cancellationToken)
        .Where(predicate).ToArrayAsync(cancellationToken)
        ;
    }

    /// <summary>Finds the recipts for the specified filter.</summary>
    public static async Task<IEnumerable<Invoice>> FindReceiptsAsync(
      this KashFlowClient client,
      Func<Invoice, bool> predicate, ReceiptFilterType filter = ReceiptFilterType.All,
      CancellationToken cancellationToken = default
      ) {
      return await client.GetReceiptsAsync(filter, cancellationToken: cancellationToken)
        .Where(predicate).ToArrayAsync(cancellationToken)
        ;
    }

    /// <summary>Finds the first receipt for the specified filter.</summary>
    public static async Task<Invoice> FirstReceiptsAsync(
      this KashFlowClient client,
      Func<Invoice, bool> predicate, ReceiptFilterType filter = ReceiptFilterType.All,
      CancellationToken cancellationToken = default
      ) {
      return await client.GetReceiptsAsync(filter, cancellationToken: cancellationToken)
        .FirstOrDefaultAsync(predicate, cancellationToken)
        ;
    }

    /// <summary>Gets a collection of the invoice payments.</summary>
    public static async IAsyncEnumerable<Payment> GetInvoicePaymentsAsync(
      this KashFlowClient client,
      DateTime? start = null, DateTime? end = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
      ) {
      var pagingRequest = new GetInvoicePaymentsByDateRangeRequest {
        EndDate = end ?? DateTime.MaxValue,
        StartDate = start ?? DateTime.MinValue,
        PageNumber = 1
      };

      while (true) {
        cancellationToken.ThrowIfCancellationRequested();

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
    public static async IAsyncEnumerable<Invoice> GetReceiptsAsync(
      this KashFlowClient client,
      ReceiptFilterType filter = ReceiptFilterType.All, int perPage = 100,
      [EnumeratorCancellation] CancellationToken cancellationToken = default
      ) {
      var pagingRequest = new GetReceiptsWithPagingRequest {
        FilterBy = $"{filter}",
        PerPage = perPage,
        Page = 1,
      };

      while (true) {
        cancellationToken.ThrowIfCancellationRequested();

        var result = await client.GetReceiptsWithPagingAsync(pagingRequest);

        foreach (var item in result.Result) {
          yield return item;
        }

        pagingRequest.Page++;

        if (pagingRequest.Page > result.TotalPages) {
          break;
        }
      };
    }

    /// <summary>Gets all the outstanding recipts.</summary>
    public static async Task<IEnumerable<Invoice>> GetReceiptsOutstandingAsync(
      this KashFlowClient client,
      CancellationToken cancellationToken = default
      ) {
      // Kashflow considers overpaid and unpaid as different
      var tasks = await Task.WhenAll(
        client.GetReceiptsAsync(ReceiptFilterType.Unpaid, cancellationToken: cancellationToken).ToArrayAsync(cancellationToken).AsTask(),
        client.GetReceiptsAsync(ReceiptFilterType.Overpaid, cancellationToken: cancellationToken).ToArrayAsync(cancellationToken).AsTask()
        );

      return tasks
        .SelectMany(x => x)
        .DistinctBy(x => x.InvoiceDBID)
        ;
    }
  }
}
#endif