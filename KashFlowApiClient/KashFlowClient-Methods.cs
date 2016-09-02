using net.tipstrade.KashFlowApiClient.KashFlowAPI;
using System;

namespace net.tipstrade.KashFlowApiClient {
  public partial class KashFlowClient {
    #region Automatically generated methods
    ///<summary>See https://www.kashflow.com/developers/soap-api/addorupdatesubproduct/ </summary>
    public Int32 AddOrUpdateSubProduct(SubProduct sp) {
      string status;
      string statusDetail;
      Int32 resp = Client.AddOrUpdateSubProduct(
        Username,
        Password,
        sp,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/allocateadvancepaymenttoinvoice/ </summary>
    public Int32 AllocateAdvancePaymentToInvoice(Int32 InvoiceNumber, Int32 BankTxId) {
      string status;
      string statusDetail;
      Int32 resp = Client.AllocateAdvancePaymentToInvoice(
        Username,
        Password,
        InvoiceNumber,
        BankTxId,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/allocateadvancepaymenttoreceipt/ </summary>
    public Int32 AllocateAdvancePaymentToReceipt(Int32 ReceiptNumber, Int32 BankTxId) {
      string status;
      string statusDetail;
      Int32 resp = Client.AllocateAdvancePaymentToReceipt(
        Username,
        Password,
        ReceiptNumber,
        BankTxId,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/applycreditnotetoinvoice/ </summary>
    public Boolean applyCreditNoteToInvoice(Int32 InvoiceID, Int32 CreditNoteID) {
      string status;
      string statusDetail;
      Boolean resp = Client.applyCreditNoteToInvoice(
        Username,
        Password,
        InvoiceID,
        CreditNoteID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/attachfiletoreceipt/ </summary>
    public Int32 AttachFileToReceipt(Int32 ReceiptNo, String Base64String, String ContentType, String Filename, String FileExtension, String FileSize) {
      string status;
      string statusDetail;
      Int32 resp = Client.AttachFileToReceipt(
        Username,
        Password,
        ReceiptNo,
        Base64String,
        ContentType,
        Filename,
        FileExtension,
        FileSize,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/autoauthip/ </summary>
    public Int32 AutoAuthIP(String appName, String AutoAuthKey) {
      string status;
      string statusDetail;
      Int32 resp = Client.AutoAuthIP(
        Username,
        Password,
        appName,
        AutoAuthKey,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/convertquotetoinvoice/ </summary>
    public Invoice ConvertQuoteToInvoice(Int32 QuoteID, Int32 CustomerID, Int32 CopyQuoteReference, Int32 deleteQuoteAfterConversion) {
      string status;
      string statusDetail;
      Invoice resp = Client.ConvertQuoteToInvoice(
        Username,
        Password,
        QuoteID,
        CustomerID,
        CopyQuoteReference,
        deleteQuoteAfterConversion,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/createaccount/ </summary>
    public Int32 createAccount(String AccountCreationKey, String memorableword, String EmailAddress, String CompanyName, String Addr1, String Addr2, String Addr3, String Addr4, String Postcode, String ContactName, String Telephone, Int32 VATRegistered, String VATNumber, Int32 USSettings, String promocode) {
      string status;
      string statusDetail;
      Int32 resp = Client.createAccount(
        AccountCreationKey,
        Username,
        Password,
        memorableword,
        EmailAddress,
        CompanyName,
        Addr1,
        Addr2,
        Addr3,
        Addr4,
        Postcode,
        ContactName,
        Telephone,
        VATRegistered,
        VATNumber,
        USSettings,
        promocode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/createbankaccount/ </summary>
    public Int32 CreateBankAccount(String AccountName, Int32 NominalCode) {
      string status;
      string statusDetail;
      Int32 resp = Client.CreateBankAccount(
        Username,
        Password,
        AccountName,
        NominalCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletebanktransaction/ </summary>
    public Int32 DeleteBankTransaction(Int32 TransactionID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteBankTransaction(
        Username,
        Password,
        TransactionID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletecustomer/ </summary>
    public Int32 DeleteCustomer(Int32 CustomerID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteCustomer(
        Username,
        Password,
        CustomerID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoice/ </summary>
    public Int32 DeleteInvoice(Int32 InvoiceNumber) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteInvoice(
        Username,
        Password,
        InvoiceNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicebyid/ </summary>
    public Int32 DeleteInvoiceByID(Int32 InvoiceID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteInvoiceByID(
        Username,
        Password,
        InvoiceID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoiceline/ </summary>
    public Int32 DeleteInvoiceLine(Int32 LineID, Int32 InvoiceNumber) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteInvoiceLine(
        Username,
        Password,
        LineID,
        InvoiceNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicelinewithinvoiceid/ </summary>
    public Int32 DeleteInvoiceLineWithInvoiceID(Int32 LineID, Int32 InvoiceID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteInvoiceLineWithInvoiceID(
        Username,
        Password,
        LineID,
        InvoiceID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicepayment/ </summary>
    public String DeleteInvoicePayment(Int32 InvoicePaymentNumber) {
      string statusDetail;
      String resp = Client.DeleteInvoicePayment(
        Username,
        Password,
        InvoicePaymentNumber,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail);
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletejournal/ </summary>
    public Int32 DeleteJournal(Int32 JournalNumber) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteJournal(
        Username,
        Password,
        JournalNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletejournalbyid/ </summary>
    public Int32 DeleteJournalByID(Int32 JournalID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteJournalByID(
        Username,
        Password,
        JournalID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequote/ </summary>
    public Int32 DeleteQuote(Int32 QuoteNumber) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteQuote(
        Username,
        Password,
        QuoteNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequotebyid/ </summary>
    public Int32 DeleteQuoteByID(Int32 QuoteID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteQuoteByID(
        Username,
        Password,
        QuoteID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequoteline/ </summary>
    public Int32 DeleteQuoteLine(Int32 LineID, Int32 QuoteNumber) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteQuoteLine(
        Username,
        Password,
        LineID,
        QuoteNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequotelinewithquoteid/ </summary>
    public Int32 DeleteQuoteLineWithQuoteID(Int32 LineID, Int32 QuoteID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteQuoteLineWithQuoteID(
        Username,
        Password,
        LineID,
        QuoteID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceipt/ </summary>
    public Int32 DeleteReceipt(Int32 ReceiptNumber) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteReceipt(
        Username,
        Password,
        ReceiptNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptattachment/ </summary>
    public Int32 DeleteReceiptAttachment(Int32 ReceiptID, Int32 AttachmentID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteReceiptAttachment(
        Username,
        Password,
        ReceiptID,
        AttachmentID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptbyid/ </summary>
    public Int32 DeleteReceiptByID(Int32 ReceiptID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteReceiptByID(
        Username,
        Password,
        ReceiptID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptline/ </summary>
    public Int32 DeleteReceiptLine(Int32 LineID, Int32 ReceiptNumber) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteReceiptLine(
        Username,
        Password,
        LineID,
        ReceiptNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptlinewithreceiptid/ </summary>
    public Int32 DeleteReceiptLineWithReceiptID(Int32 LineID, Int32 ReceiptID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteReceiptLineWithReceiptID(
        Username,
        Password,
        LineID,
        ReceiptID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptpayment/ </summary>
    public Int32 DeleteReceiptPayment(Int32 ReceiptPaymentNumber) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteReceiptPayment(
        Username,
        Password,
        ReceiptPaymentNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletesupplier/ </summary>
    public Int32 DeleteSupplier(Int32 SupplierID) {
      string status;
      string statusDetail;
      Int32 resp = Client.DeleteSupplier(
        Username,
        Password,
        SupplierID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/emailinvoice/ </summary>
    public String EmailInvoice(Int32 InvoiceNumber, String FromEmail, String FromName, String SubjectLine, String Body, String RecipientEmail) {
      string statusDetail;
      String resp = Client.EmailInvoice(
        Username,
        Password,
        InvoiceNumber,
        FromEmail,
        FromName,
        SubjectLine,
        Body,
        RecipientEmail,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail);
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/emailpurchaseorder/ </summary>
    public String EmailPurchaseOrder(Int32 ReceiptNumber, String FromEmail, String FromName, String SubjectLine, String Body, String RecipientEmail) {
      string status;
      string statusDetail;
      String resp = Client.EmailPurchaseOrder(
        Username,
        Password,
        ReceiptNumber,
        FromEmail,
        FromName,
        SubjectLine,
        Body,
        RecipientEmail,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getaccountoverview/ </summary>
    public AccountOverview GetAccountOverview() {
      string status;
      string statusDetail;
      AccountOverview resp = Client.GetAccountOverview(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getagedcreditors/ </summary>
    public AgedDebtorsCreditors[] GetAgedCreditors(DateTime AgedCreditorsDate) {
      string status;
      string statusDetail;
      AgedDebtorsCreditors[] resp = Client.GetAgedCreditors(
        Username,
        Password,
        AgedCreditorsDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getageddebtors/ </summary>
    public AgedDebtorsCreditors[] GetAgedDebtors(DateTime AgedDebtorsDate) {
      string status;
      string statusDetail;
      AgedDebtorsCreditors[] resp = Client.GetAgedDebtors(
        Username,
        Password,
        AgedDebtorsDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbalancesheet/ </summary>
    public BalanceSheet GetBalanceSheet(DateTime Date) {
      string status;
      string statusDetail;
      BalanceSheet resp = Client.GetBalanceSheet(
        Username,
        Password,
        Date,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankaccounts/ </summary>
    public BankAccount[] GetBankAccounts() {
      string status;
      string statusDetail;
      BankAccount[] resp = Client.GetBankAccounts(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankbalance/ </summary>
    public Decimal GetBankBalance(Int32 AccountID, DateTime BalanceDate) {
      string status;
      string statusDetail;
      Decimal resp = Client.GetBankBalance(
        Username,
        Password,
        AccountID,
        BalanceDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankoverview/ </summary>
    public BankOverview[] GetBankOverview() {
      string status;
      string statusDetail;
      BankOverview[] resp = Client.GetBankOverview(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbanktransactions/ </summary>
    public BankTransaction[] GetBankTransactions(Int32 AccountID) {
      string status;
      string statusDetail;
      BankTransaction[] resp = Client.GetBankTransactions(
        Username,
        Password,
        AccountID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbanktxtypes/ </summary>
    public BankTXType[] GetBankTxTypes() {
      string status;
      string statusDetail;
      BankTXType[] resp = Client.GetBankTxTypes(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcompanydetails/ </summary>
    public CompanyDetails GetCompanyDetails() {
      string status;
      string statusDetail;
      CompanyDetails resp = Client.GetCompanyDetails(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcurrencies/ </summary>
    public Currencies[] GetCurrencies() {
      string status;
      string statusDetail;
      Currencies[] resp = Client.GetCurrencies(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomer/ </summary>
    public Customer GetCustomer(String CustomerCode) {
      string status;
      string statusDetail;
      Customer resp = Client.GetCustomer(
        Username,
        Password,
        CustomerCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomeradvancepayments/ </summary>
    public BankTransaction[] GetCustomerAdvancePayments(Int32 CustomerId) {
      string status;
      string statusDetail;
      BankTransaction[] resp = Client.GetCustomerAdvancePayments(
        Username,
        Password,
        CustomerId,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbalance/ </summary>
    public CustomerBalance GetCustomerBalance(String CustomerCode) {
      string status;
      string statusDetail;
      CustomerBalance resp = Client.GetCustomerBalance(
        Username,
        Password,
        CustomerCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbyemail/ </summary>
    public Customer GetCustomerByEmail(String CustomerEmail) {
      string status;
      string statusDetail;
      Customer resp = Client.GetCustomerByEmail(
        Username,
        Password,
        CustomerEmail,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbyid/ </summary>
    public Customer GetCustomerByID(Int32 CustomerID) {
      string status;
      string statusDetail;
      Customer resp = Client.GetCustomerByID(
        Username,
        Password,
        CustomerID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomercurrency/ </summary>
    public String GetCustomerCurrency(String CustomerCode) {
      string status;
      string statusDetail;
      String resp = Client.GetCustomerCurrency(
        Username,
        Password,
        CustomerCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomers/ </summary>
    public Customer[] GetCustomers() {
      string status;
      string statusDetail;
      Customer[] resp = Client.GetCustomers(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersbypostcode/ </summary>
    public Customer[] GetCustomersByPostcode(String Postcode) {
      string status;
      string statusDetail;
      Customer[] resp = Client.GetCustomersByPostcode(
        Username,
        Password,
        Postcode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersmodifiedsince/ </summary>
    public Customer[] GetCustomersModifiedSince(DateTime ModifiedSince) {
      string status;
      string statusDetail;
      Customer[] resp = Client.GetCustomersModifiedSince(
        Username,
        Password,
        ModifiedSince,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersources/ </summary>
    public BasicDataset[] GetCustomerSources() {
      string status;
      string statusDetail;
      BasicDataset[] resp = Client.GetCustomerSources(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomervatnumber/ </summary>
    public String GetCustomerVATNumber(String CustomerCode) {
      string status;
      string statusDetail;
      String resp = Client.GetCustomerVATNumber(
        Username,
        Password,
        CustomerCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getdigitacsvfile/ </summary>
    public String GetDigitaCSVFile(DateTime StartDate, DateTime EndDate) {
      string status;
      string statusDetail;
      String resp = Client.GetDigitaCSVFile(
        Username,
        Password,
        StartDate,
        EndDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getincomebycustomer/ </summary>
    public BasicDataset[] GetIncomeByCustomer(DateTime StartDate, DateTime EndDate, Boolean BasedOnInvoiceDate) {
      string status;
      string statusDetail;
      BasicDataset[] resp = Client.GetIncomeByCustomer(
        Username,
        Password,
        StartDate,
        EndDate,
        BasedOnInvoiceDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoice/ </summary>
    public Invoice GetInvoice(Int32 InvoiceNumber) {
      string status;
      string statusDetail;
      Invoice resp = Client.GetInvoice(
        Username,
        Password,
        InvoiceNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicetypedefined/ </summary>
    public Invoice_TypeDefined GetInvoice_TypeDefined(Int32 InvoiceNumber) {
      string status;
      string statusDetail;
      Invoice_TypeDefined resp = Client.GetInvoice_TypeDefined(
        Username,
        Password,
        InvoiceNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicebyid/ </summary>
    public Invoice GetInvoiceByID(Int32 InvoiceID) {
      string status;
      string statusDetail;
      Invoice resp = Client.GetInvoiceByID(
        Username,
        Password,
        InvoiceID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicenotes/ </summary>
    public InvoiceNotes[] GetInvoiceNotes(Int32 InvoiceId) {
      string status;
      string statusDetail;
      InvoiceNotes[] resp = Client.GetInvoiceNotes(
        Username,
        Password,
        InvoiceId,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepayment/ </summary>
    public Payment[] GetInvoicePayment(Int32 InvoiceNumber) {
      string status;
      string statusDetail;
      Payment[] resp = Client.GetInvoicePayment(
        Username,
        Password,
        InvoiceNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepaymentsbydaterange/ </summary>
    public Payment[] GetInvoicePaymentsByDateRange(DateTime StartDate, DateTime EndDate, Int32 PageNumber) {
      string status;
      string statusDetail;
      Payment[] resp = Client.GetInvoicePaymentsByDateRange(
        Username,
        Password,
        StartDate,
        EndDate,
        PageNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepaymentscountfordaterange/ </summary>
    public Int32 GetInvoicePaymentsCountforDateRange(DateTime StartDate, DateTime EndDate) {
      string status;
      string statusDetail;
      Int32 resp = Client.GetInvoicePaymentsCountforDateRange(
        Username,
        Password,
        StartDate,
        EndDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesoverdue/ </summary>
    public Invoice[] GetInvoices_Overdue() {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetInvoices_Overdue(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesoverduetypedefined/ </summary>
    public Invoice_TypeDefined[] GetInvoices_Overdue_TypeDefined() {
      string status;
      string statusDetail;
      Invoice_TypeDefined[] resp = Client.GetInvoices_Overdue_TypeDefined(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesrecent/ </summary>
    public Invoice[] GetInvoices_Recent(Int32 NumberOfInvoices) {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetInvoices_Recent(
        Username,
        Password,
        NumberOfInvoices,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesrecenttypedefined/ </summary>
    public Invoice_TypeDefined[] GetInvoices_Recent_TypeDefined(Int32 NumberOfInvoices) {
      string status;
      string statusDetail;
      Invoice_TypeDefined[] resp = Client.GetInvoices_Recent_TypeDefined(
        Username,
        Password,
        NumberOfInvoices,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesunpaid/ </summary>
    public Invoice[] GetInvoices_Unpaid() {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetInvoices_Unpaid(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesunpaidtypedefined/ </summary>
    public Invoice_TypeDefined[] GetInvoices_Unpaid_TypeDefined() {
      string status;
      string statusDetail;
      Invoice_TypeDefined[] resp = Client.GetInvoices_Unpaid_TypeDefined(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesbydaterange/ </summary>
    public Invoice[] GetInvoicesByDateRange(DateTime StartDate, DateTime EndDate) {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetInvoicesByDateRange(
        Username,
        Password,
        StartDate,
        EndDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesforcustomer/ </summary>
    public Invoice[] GetInvoicesForCustomer(Int32 CustID) {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetInvoicesForCustomer(
        Username,
        Password,
        CustID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesforcustomertypedefined/ </summary>
    public Invoice_TypeDefined[] GetInvoicesForCustomer_typeDefined(Int32 CustID) {
      string status;
      string statusDetail;
      Invoice_TypeDefined[] resp = Client.GetInvoicesForCustomer_typeDefined(
        Username,
        Password,
        CustID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvpaymethods/ </summary>
    public PaymentMethod[] GetInvPayMethods() {
      string status;
      string statusDetail;
      PaymentMethod[] resp = Client.GetInvPayMethods(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getjournal/ </summary>
    public JournalEntry GetJournal(Int32 JournalNumber) {
      string status;
      string statusDetail;
      JournalEntry resp = Client.GetJournal(
        Username,
        Password,
        JournalNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getjournals/ </summary>
    public JournalEntry[] GetJournals() {
      string status;
      string statusDetail;
      JournalEntry[] resp = Client.GetJournals(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getkpis/ </summary>
    public BasicDataset[] GetKPIs(DateTime StartDate, DateTime EndDate, Int32 ExcludeVAT, Int32 ExcludeSameDayPays) {
      string status;
      string statusDetail;
      BasicDataset[] resp = Client.GetKPIs(
        Username,
        Password,
        StartDate,
        EndDate,
        ExcludeVAT,
        ExcludeSameDayPays,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getmonthlyprofitandloss/ </summary>
    public MonthlyPL[] GetMonthlyProfitAndLoss(DateTime StartDate, DateTime EndDate) {
      string status;
      string statusDetail;
      MonthlyPL[] resp = Client.GetMonthlyProfitAndLoss(
        Username,
        Password,
        StartDate,
        EndDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalcodes/ </summary>
    public NominalCode[] GetNominalCodes() {
      string status;
      string statusDetail;
      NominalCode[] resp = Client.GetNominalCodes(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalcodesextended/ </summary>
    public NominalCodeExtended[] GetNominalCodesExtended() {
      string status;
      string statusDetail;
      NominalCodeExtended[] resp = Client.GetNominalCodesExtended(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalledger/ </summary>
    public TransactionInformation[] GetNominalLedger(DateTime StartDate, DateTime EndDate, Int32 NominalID) {
      string status;
      string statusDetail;
      TransactionInformation[] resp = Client.GetNominalLedger(
        Username,
        Password,
        StartDate,
        EndDate,
        NominalID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getpaypallink/ </summary>
    public String GetPaypalLink(Int32 InvoiceNumber) {
      string status;
      string statusDetail;
      String resp = Client.GetPaypalLink(
        Username,
        Password,
        InvoiceNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getproducts/ </summary>
    public Product[] GetProducts() {
      string status;
      string statusDetail;
      Product[] resp = Client.GetProducts(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getproductswithsubproducts/ </summary>
    public ProductsFull[] GetProductsWithSubProducts() {
      string status;
      string statusDetail;
      ProductsFull[] resp = Client.GetProductsWithSubProducts(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprofitandloss/ </summary>
    public ProfitAndLoss GetProfitAndLoss(DateTime StartDate, DateTime EndDate) {
      string status;
      string statusDetail;
      ProfitAndLoss resp = Client.GetProfitAndLoss(
        Username,
        Password,
        StartDate,
        EndDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyid/ </summary>
    public Project GetProjectById(Int32 ProjId) {
      string status;
      string statusDetail;
      Project resp = Client.GetProjectById(
        Username,
        Password,
        ProjId,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyname/ </summary>
    public Project GetProjectByName(String ProjName) {
      string status;
      string statusDetail;
      Project resp = Client.GetProjectByName(
        Username,
        Password,
        ProjName,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyref/ </summary>
    public Project GetProjectByRef(String ProjRef) {
      string status;
      string statusDetail;
      Project resp = Client.GetProjectByRef(
        Username,
        Password,
        ProjRef,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojects/ </summary>
    public BasicDataset[] GetProjects() {
      string status;
      string statusDetail;
      BasicDataset[] resp = Client.GetProjects(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectsfull/ </summary>
    public Project[] GetProjects_Full(Int32 ProjStatus) {
      string status;
      string statusDetail;
      Project[] resp = Client.GetProjects_Full(
        Username,
        Password,
        ProjStatus,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotebyid/ </summary>
    public Invoice GetQuoteByID(Int32 QuoteID) {
      string status;
      string statusDetail;
      Invoice resp = Client.GetQuoteByID(
        Username,
        Password,
        QuoteID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotebynumber/ </summary>
    public Invoice GetQuoteByNumber(Int32 QuoteNumber) {
      string status;
      string statusDetail;
      Invoice resp = Client.GetQuoteByNumber(
        Username,
        Password,
        QuoteNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotes/ </summary>
    public Invoice[] GetQuotes() {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetQuotes(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotesrecent/ </summary>
    public Invoice[] GetQuotes_Recent(Int32 NumberOfQuotes) {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetQuotes_Recent(
        Username,
        Password,
        NumberOfQuotes,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotesforcustomer/ </summary>
    public Invoice[] GetQuotesForCustomer(Int32 CustID) {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetQuotesForCustomer(
        Username,
        Password,
        CustID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipt/ </summary>
    public Invoice GetReceipt(Int32 ReceiptNumber) {
      string status;
      string statusDetail;
      Invoice resp = Client.GetReceipt(
        Username,
        Password,
        ReceiptNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipttypedefined/ </summary>
    public Invoice_TypeDefined GetReceipt_TypeDefined(Int32 ReceiptNumber) {
      string status;
      string statusDetail;
      Invoice_TypeDefined resp = Client.GetReceipt_TypeDefined(
        Username,
        Password,
        ReceiptNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptattachments/ </summary>
    public ReceiptAttachment[] GetReceiptAttachments(Int32 ReceiptID) {
      string status;
      string statusDetail;
      ReceiptAttachment[] resp = Client.GetReceiptAttachments(
        Username,
        Password,
        ReceiptID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptnotes/ </summary>
    public ReceiptNotes[] GetReceiptNotes(Int32 ReceiptId) {
      string status;
      string statusDetail;
      ReceiptNotes[] resp = Client.GetReceiptNotes(
        Username,
        Password,
        ReceiptId,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptpayment/ </summary>
    public Payment[] GetReceiptPayment(Int32 ReceiptNumber) {
      string status;
      string statusDetail;
      Payment[] resp = Client.GetReceiptPayment(
        Username,
        Password,
        ReceiptNumber,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipts/ </summary>
    public Invoice[] GetReceipts() {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetReceipts(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptsrecent/ </summary>
    public Invoice[] GetReceipts_Recent(Int32 NumberOfReceipts) {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetReceipts_Recent(
        Username,
        Password,
        NumberOfReceipts,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptsforsupplier/ </summary>
    public Invoice[] GetReceiptsForSupplier(Int32 SupplierID) {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetReceiptsForSupplier(
        Username,
        Password,
        SupplierID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptswithpaging/ </summary>
    public Invoice[] GetReceiptsWithPaging(Int32 Page, Int32 PerPage, String FilterBy, out Int32 PageNumber, out Int32 TotalPages, out Int32 TotalRecords) {
      string status;
      string statusDetail;
      Invoice[] resp = Client.GetReceiptsWithPaging(
        Username,
        Password,
        Page,
        PerPage,
        FilterBy,
        out status,
        out statusDetail,
        out PageNumber,
        out TotalPages,
        out TotalRecords
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getrecpaymethods/ </summary>
    public PaymentMethod[] GetRecPayMethods() {
      string status;
      string statusDetail;
      PaymentMethod[] resp = Client.GetRecPayMethods(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getremoteloginurl/ </summary>
    public String GetRemoteLoginURL() {
      string status;
      string statusDetail;
      String resp = Client.GetRemoteLoginURL(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproductbycode/ </summary>
    public SubProduct GetSubProductByCode(String ProductCode) {
      string status;
      string statusDetail;
      SubProduct resp = Client.GetSubProductByCode(
        Username,
        Password,
        ProductCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproductbyid/ </summary>
    public SubProduct GetSubProductByID(Int32 ProductID) {
      string status;
      string statusDetail;
      SubProduct resp = Client.GetSubProductByID(
        Username,
        Password,
        ProductID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproducts/ </summary>
    public SubProduct[] GetSubProducts(Int32 NominalID) {
      string status;
      string statusDetail;
      SubProduct[] resp = Client.GetSubProducts(
        Username,
        Password,
        NominalID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsupplier/ </summary>
    public Supplier GetSupplier(String SupplierCode) {
      string status;
      string statusDetail;
      Supplier resp = Client.GetSupplier(
        Username,
        Password,
        SupplierCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsupplierbyid/ </summary>
    public Supplier GetSupplierByID(Int32 SupplierID) {
      string status;
      string statusDetail;
      Supplier resp = Client.GetSupplierByID(
        Username,
        Password,
        SupplierID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliercurrency/ </summary>
    public String GetSupplierCurrency(String SupplierCode) {
      string status;
      string statusDetail;
      String resp = Client.GetSupplierCurrency(
        Username,
        Password,
        SupplierCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliers/ </summary>
    public Supplier[] GetSuppliers() {
      string status;
      string statusDetail;
      Supplier[] resp = Client.GetSuppliers(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliervatnumber/ </summary>
    public String GetSupplierVATNumber(String SupplierCode) {
      string status;
      string statusDetail;
      String resp = Client.GetSupplierVATNumber(
        Username,
        Password,
        SupplierCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/gettrialbalance/ </summary>
    public NominalCode[] GetTrialBalance(DateTime StartDate, DateTime EndDate) {
      string status;
      string statusDetail;
      NominalCode[] resp = Client.GetTrialBalance(
        Username,
        Password,
        StartDate,
        EndDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/gettrialbalancewithopeningbalances/ </summary>
    public NominalCodeBalance[] GetTrialBalanceWithOpeningBalances(DateTime StartDate, DateTime EndDate) {
      string status;
      string statusDetail;
      NominalCodeBalance[] resp = Client.GetTrialBalanceWithOpeningBalances(
        Username,
        Password,
        StartDate,
        EndDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getuseraccountdefaults/ </summary>
    public UserAccountDefaults GetUserAccountDefaults() {
      string status;
      string statusDetail;
      UserAccountDefaults resp = Client.GetUserAccountDefaults(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getuseraccountdefaultstypedefined/ </summary>
    public UserAccountDefaults_TypeDefined GetUserAccountDefaults_TypeDefined() {
      string status;
      string statusDetail;
      UserAccountDefaults_TypeDefined resp = Client.GetUserAccountDefaults_TypeDefined(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getvatrates/ </summary>
    public BasicDataset[] GetVATRates() {
      string status;
      string statusDetail;
      BasicDataset[] resp = Client.GetVATRates(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getvatreport/ </summary>
    public VATReport GetVATReport(DateTime StartDate, DateTime EndDate) {
      string status;
      string statusDetail;
      VATReport resp = Client.GetVATReport(
        Username,
        Password,
        StartDate,
        EndDate,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertbanktransaction/ </summary>
    public Int32 InsertBankTransaction(BankTransaction bp) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertBankTransaction(
        Username,
        Password,
        bp,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertcustomer/ </summary>
    public Int32 InsertCustomer(Customer custr) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertCustomer(
        Username,
        Password,
        custr,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoice/ </summary>
    public Int32 InsertInvoice(Invoice Inv) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertInvoice(
        Username,
        Password,
        Inv,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicetypedefined/ </summary>
    public Int32 InsertInvoice_TypeDefined(Invoice_TypeDefined Inv_TD) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertInvoice_TypeDefined(
        Username,
        Password,
        Inv_TD,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoiceline/ </summary>
    public Int32 InsertInvoiceLine(Int32 InvoiceID, InvoiceLine InvLine) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertInvoiceLine(
        Username,
        Password,
        InvoiceID,
        InvLine,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicelinewithinvoicenumber/ </summary>
    public Int32 InsertInvoiceLineWithInvoiceNumber(Int32 InvoiceNumber, InvoiceLine InvLine) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertInvoiceLineWithInvoiceNumber(
        Username,
        Password,
        InvoiceNumber,
        InvLine,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicenote/ </summary>
    public Boolean InsertInvoiceNote(Int32 InvoiceId, DateTime NoteDate, String Notes) {
      string status;
      string statusDetail;
      Boolean resp = Client.InsertInvoiceNote(
        Username,
        Password,
        InvoiceId,
        NoteDate,
        Notes,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicepayment/ </summary>
    public Int32 InsertInvoicePayment(Payment InvoicePayment) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertInvoicePayment(
        Username,
        Password,
        InvoicePayment,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertjournal/ </summary>
    public Int32 InsertJournal(JournalEntry Jnl) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertJournal(
        Username,
        Password,
        Jnl,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertnominalcode/ </summary>
    public Int32 InsertNominalCode(String name, Int32 code, Int32 classification, Int32 nomtype) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertNominalCode(
        Username,
        Password,
        name,
        code,
        classification,
        nomtype,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertorupdateproject/ </summary>
    public Int32 InsertOrUpdateProject(Project Project) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertOrUpdateProject(
        Username,
        Password,
        Project,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertquote/ </summary>
    public Int32 InsertQuote(Invoice Quote) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertQuote(
        Username,
        Password,
        Quote,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertquoteline/ </summary>
    public Int32 InsertQuoteLine(Int32 QuoteID, InvoiceLine QuoteLine) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertQuoteLine(
        Username,
        Password,
        QuoteID,
        QuoteLine,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceipt/ </summary>
    public Int32 InsertReceipt(Invoice Inv) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertReceipt(
        Username,
        Password,
        Inv,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceipttypedefined/ </summary>
    public Int32 InsertReceipt_TypeDefined(Invoice_TypeDefined Inv_TD) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertReceipt_TypeDefined(
        Username,
        Password,
        Inv_TD,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptline/ </summary>
    public Int32 InsertReceiptLine(Int32 ReceiptID, InvoiceLine InvLine) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertReceiptLine(
        Username,
        Password,
        ReceiptID,
        InvLine,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptlinefromnumber/ </summary>
    public Int32 InsertReceiptLineFromNumber(Int32 ReceiptNumber, InvoiceLine InvLine) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertReceiptLineFromNumber(
        Username,
        Password,
        ReceiptNumber,
        InvLine,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptnote/ </summary>
    public Boolean InsertReceiptNote(Int32 ReceiptId, DateTime NoteDate, String Notes) {
      string status;
      string statusDetail;
      Boolean resp = Client.InsertReceiptNote(
        Username,
        Password,
        ReceiptId,
        NoteDate,
        Notes,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptpayment/ </summary>
    public Int32 InsertReceiptPayment(Payment ReceiptPayment) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertReceiptPayment(
        Username,
        Password,
        ReceiptPayment,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertsupplier/ </summary>
    public Int32 InsertSupplier(Supplier supl) {
      string status;
      string statusDetail;
      Int32 resp = Client.InsertSupplier(
        Username,
        Password,
        supl,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/isonesaasenabled/ </summary>
    public Boolean IsOneSaaSEnabled() {
      string status;
      string statusDetail;
      Boolean resp = Client.IsOneSaaSEnabled(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/isstillquote/ </summary>
    public Boolean isStillQuote(Int32 QuoteID) {
      string status;
      string statusDetail;
      Boolean resp = Client.isStillQuote(
        Username,
        Password,
        QuoteID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/isuservatregistered/ </summary>
    public Boolean isUserVATRegistered() {
      string status;
      string statusDetail;
      Boolean resp = Client.isUserVATRegistered(
        Username,
        Password,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/printinvoice/ </summary>
    public String PrintInvoice(Int32 InvoiceNumber, String InvoiceNumberList) {
      string status;
      string statusDetail;
      String resp = Client.PrintInvoice(
        Username,
        Password,
        InvoiceNumber,
        InvoiceNumberList,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/printpurchaseorder/ </summary>
    public String PrintPurchaseOrder(Int32 ReceiptNumber, String ReceiptNumberList) {
      string status;
      string statusDetail;
      String resp = Client.PrintPurchaseOrder(
        Username,
        Password,
        ReceiptNumber,
        ReceiptNumberList,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/searchcustomerbycusttext/ </summary>
    public Customer SearchCustomerByCustText(String SearchVal) {
      string status;
      string statusDetail;
      Customer resp = Client.SearchCustomerByCustText(
        Username,
        Password,
        SearchVal,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/setcustomercurrency/ </summary>
    public Int32 SetCustomerCurrency(String CurrencyCode, String CustomerCode) {
      string status;
      string statusDetail;
      Int32 resp = Client.SetCustomerCurrency(
        Username,
        Password,
        CurrencyCode,
        CustomerCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/setcustomervatnumber/ </summary>
    public Int32 SetCustomerVATNumber(String CustVATNumber, String CustomerCode) {
      string status;
      string statusDetail;
      Int32 resp = Client.SetCustomerVATNumber(
        Username,
        Password,
        CustVATNumber,
        CustomerCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/setsuppliercurrency/ </summary>
    public Int32 SetSupplierCurrency(String CurrencyCode, String SupplierCode) {
      string status;
      string statusDetail;
      Int32 resp = Client.SetSupplierCurrency(
        Username,
        Password,
        CurrencyCode,
        SupplierCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/setsuppliervatnumber/ </summary>
    public Int32 SetSupplierVATNumber(String SupVATNumber, String SupplierCode) {
      string status;
      string statusDetail;
      Int32 resp = Client.SetSupplierVATNumber(
        Username,
        Password,
        SupVATNumber,
        SupplierCode,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatebanktransaction/ </summary>
    public Int32 UpdateBankTransaction(BankTransaction bp, Int32 TransactionID) {
      string status;
      string statusDetail;
      Int32 resp = Client.UpdateBankTransaction(
        Username,
        Password,
        bp,
        TransactionID,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatecustomer/ </summary>
    public String UpdateCustomer(Customer custr) {
      string status;
      string statusDetail;
      String resp = Client.UpdateCustomer(
        Username,
        Password,
        custr,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoice/ </summary>
    public String UpdateInvoice(Invoice Inv) {
      string statusDetail;
      String resp = Client.UpdateInvoice(
        Username,
        Password,
        Inv,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail);
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoicetypedefined/ </summary>
    public String UpdateInvoice_TypeDefined(Invoice_TypeDefined InvTD) {
      string statusDetail;
      String resp = Client.UpdateInvoice_TypeDefined(
        Username,
        Password,
        InvTD,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail);
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoiceheader/ </summary>
    public String UpdateInvoiceHeader(Invoice Inv) {
      string statusDetail;
      String resp = Client.UpdateInvoiceHeader(
        Username,
        Password,
        Inv,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail);
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatejournal/ </summary>
    public Int32 UpdateJournal(JournalEntry Jnl) {
      string status;
      string statusDetail;
      Int32 resp = Client.UpdateJournal(
        Username,
        Password,
        Jnl,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatejournalheader/ </summary>
    public Int32 UpdateJournalHeader(JournalEntry Jnl) {
      string status;
      string statusDetail;
      Int32 resp = Client.UpdateJournalHeader(
        Username,
        Password,
        Jnl,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatequote/ </summary>
    public Int32 UpdateQuote(Invoice Quote) {
      string status;
      string statusDetail;
      Int32 resp = Client.UpdateQuote(
        Username,
        Password,
        Quote,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatequoteheader/ </summary>
    public Int32 UpdateQuoteHeader(Invoice Quote) {
      string status;
      string statusDetail;
      Int32 resp = Client.UpdateQuoteHeader(
        Username,
        Password,
        Quote,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceipt/ </summary>
    public Int32 UpdateReceipt(Invoice Receipt) {
      string status;
      string statusDetail;
      Int32 resp = Client.UpdateReceipt(
        Username,
        Password,
        Receipt,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceipttypedefined/ </summary>
    public Int32 UpdateReceipt_TypeDefined(Invoice_TypeDefined Receipt_TD) {
      string status;
      string statusDetail;
      Int32 resp = Client.UpdateReceipt_TypeDefined(
        Username,
        Password,
        Receipt_TD,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceiptheader/ </summary>
    public Int32 UpdateReceiptHeader(Invoice Receipt) {
      string status;
      string statusDetail;
      Int32 resp = Client.UpdateReceiptHeader(
        Username,
        Password,
        Receipt,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatesupplier/ </summary>
    public String UpdateSupplier(Supplier sup) {
      string statusDetail;
      String resp = Client.UpdateSupplier(
        Username,
        Password,
        sup,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail);
      return resp;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/vcftocustomerobjects/ </summary>
    public Customer[] VCFToCustomerObjects(Byte[] inStream) {
      string status;
      string statusDetail;
      Customer[] resp = Client.VCFToCustomerObjects(
        Username,
        Password,
        inStream,
        out status,
        out statusDetail
        );

      if (statusDetail != "")
        throw new KashFlowException(statusDetail) { Status = status };
      return resp;
    }

    #endregion
  }
}

