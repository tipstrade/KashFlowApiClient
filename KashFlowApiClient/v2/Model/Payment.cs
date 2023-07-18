#if NET6_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TipsTrade.KashFlow.v2.Model.Covnerters;

namespace TipsTrade.KashFlow.v2.Model {
  public class PaymentItem {
    public int? BulkPaymentNumber { get; set; }
    public string Permalink { get; set; }
    //public int PaymentProcessorEnumValue { get; set; }
    public bool IsPaymentCreditNote { get; set; }
    public int? VATReturnId { get; set; }
    public int Id { get; set; }
    [JsonConverter(typeof(FlexibleDateTimeConverter))]
    public DateTime Date { get; set; }
    public int? BulkId { get; set; }
    public int? BFSTransactionId { get; set; }
    public int PaymentProcessor { get; set; }
    public int AccountId { get; set; }
    public string Note { get; set; }
    public int Method { get; set; }
    public decimal Amount { get; set; }
    public string ContactName { get; set; }
    public string ContactReference { get; set; }
    public string ObjectIssuedDate { get; set; }
    public int? ObjectNumber { get; set; }
    [JsonConverter(typeof(FlexibleDateTimeConverter))]
    public DateTime? PaidDate { get; set; }
    public string CustomerName { get; set; }
  }

  public class BulkPayment {
    public int AccountId { get; set; }
    public string Comment { get; set; }
    [JsonConverter(typeof(FlexibleDateTimeConverter))]
    public DateTime Date { get; set; }
    public int Method { get; set; }
    public int Number { get; set; }
    public List<PaymentItem> PaymentItems { get; set; }
    public bool Reconciled { get; set; }
    public string Permalink { get; set; }
  }
}
#endif