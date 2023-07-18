#if NET6_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TipsTrade.KashFlow.v2.Model.Covnerters;

namespace TipsTrade.KashFlow.v2.Model {
  public class Invoice {
    public object Address { get; set; }
    public bool AutomaticCreditControlEnabled { get; set; }
    public Currency Currency { get; set; }
    public string CustomerCode { get; set; }
    public decimal CustomerDiscount { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerReference { get; set; }
    public object DeliveryAddress { get; set; }
    [JsonConverter(typeof(FlexibleDateTimeConverter))]
    public DateTime DueDate { get; set; }
    public int EmailCount { get; set; }
    public decimal GrossAmount { get; set; }
    public int Id { get; set; }
    public bool InvoiceInECMemberState { get; set; }
    public bool InvoiceOutsideECMemberState { get; set; }
    [JsonConverter(typeof(FlexibleDateTimeConverter))]
    public DateTime IssuedDate { get; set; }
    public IEnumerable<InvoiceLine> LineItems { get; set; }
    [JsonConverter(typeof(FlexibleDateTimeConverter))]
    public DateTime? LastPaymentDate { get; set; }
    public decimal NetAmount { get; set; }
    public int Number { get; set; }
    public int OverdueDays { get; set; }
    [JsonConverter(typeof(FlexibleDateTimeConverter))]
    public DateTime? PaidDate { get; set; }
    public IEnumerable<PaymentItem>? PaymentLines { get; set; }
    public string Status { get; set; }
    public int SuppressNumber { get; set; }
    public decimal TotalPaidAmount { get; set; }
    public bool UpdateCustomerAddress { get; set; }
    public bool UpdateCustomerDeliveryAddress { get; set; }
    public decimal VATAmount { get; set; }
    public string VATNumber { get; set; }
  }

  public class InvoiceLine {
    public bool ApplyTax1 { get; set; }
    public bool ApplyTax2 { get; set; }
    public bool ApplyTax3 { get; set; }
    public bool ApplyTax4 { get; set; }
    public bool ApplyTax5 { get; set; }
    public int NominalCode { get; set; }
    public string Description { get; set; }
    public int Number { get; set; }
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public decimal Quantity { get; set; }
    public decimal Rate { get; set; }
    public decimal Tax1Amount { get; set; }
    public decimal Tax2Amount { get; set; }
    public decimal Tax3Amount { get; set; }
    public decimal Tax4Amount { get; set; }
    public decimal Tax5Amount { get; set; }
    public decimal VATAmount { get; set; }
    public bool? VATExempt { get; set; }
    public decimal VATLevel { get; set; }
    public int ProjectNumber { get; set; }
  }

  public class InvoiceRequest : IApiRequest {
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
    public string? CustomerCode { get; set; }
  }
}
#endif