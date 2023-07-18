#if NET6_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TipsTrade.KashFlow.v2.Model.Covnerters;

namespace TipsTrade.KashFlow.v2.Model {
  public class Purchase {
    public Currency Currency { get; set; }
    [JsonConverter(typeof(FlexibleDateTimeConverter))]
    public DateTime DueDate { get; set; }
    public decimal GrossAmount { get; set; }
    public int Id { get; set; }
    [JsonConverter(typeof(FlexibleDateTimeConverter))]
    public DateTime IssuedDate { get; set; }
    public IEnumerable<PurchaseLine> LineItems { get; set; }
    public decimal NetAmount { get; set; }
    public int Number { get; set; }
    public int OverdueDays { get; set; }
    public string PaidDate { get; set; }
    public IEnumerable<PaymentItem>? PaymentLines { get; set; }
    public string Permalink { get; set; }
    public string Status { get; set; }
    public string SupplierCode { get; set; }
    public int SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string SupplierReference { get; set; }
    public decimal TotalPaidAmount { get; set; }
    public decimal VATAmount { get; set; }
    public int FileCount { get; set; }
  }

  public class PurchaseLine {
    public string Description { get; set; }
    public decimal HomeCurrencyRate { get; set; }
    public decimal HomeCurrencyVATAmount { get; set; }
    public int NominalCode { get; set; }
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public decimal Quantity { get; set; }
    public decimal Rate { get; set; }
    public object TaxCode { get; set; }
    public decimal VATAmount { get; set; }
    public bool? VATExempt { get; set; }
    public decimal VATLevel { get; set; }
    public string NominalName { get; set; }
    public string ProjectName { get; set; }
    public int ProjectNumber { get; set; }
  }

  public class PurchaseRequest : IApiRequest {
    [JsonPropertyName("page")]
    public int Page { get; set; } = 1;

    [JsonPropertyName("perpage")]
    public int PerPage { get; set; } = 100;

    [JsonPropertyName("sortby")]
    public string? SortBy { get; set; }

    [JsonPropertyName("order")]
    public string? Order { get; set; }

    [JsonPropertyName("filterby")]
    public string? FilterBy { get; set; }


    [JsonPropertyName("projectnumber")]
    public int? ProjectNumber { get; set; }

    [JsonPropertyName("suppliercode")]
    public string? Suppliercode { get; set; }
  }
}
#endif