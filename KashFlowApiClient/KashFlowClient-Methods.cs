using TipsTrade.KashFlow.KashFlowAPI;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TipsTrade.KashFlow {
  public partial class KashFlowClient {
    #region Automatically generated methods
#pragma warning disable IDE0018, IDE1006
    ///<summary>See https://www.kashflow.com/developers/soap-api/addorupdatesubproduct/ </summary>
    public async Task<System.Int32> AddOrUpdateSubProductAsync(AddOrUpdateSubProductRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AddOrUpdateSubProductAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AddOrUpdateSubProductResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/allocateadvancepaymenttoinvoice/ </summary>
    public async Task<System.Int32> AllocateAdvancePaymentToInvoiceAsync(AllocateAdvancePaymentToInvoiceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AllocateAdvancePaymentToInvoiceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AllocateAdvancePaymentToInvoiceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/allocateadvancepaymenttoreceipt/ </summary>
    public async Task<System.Int32> AllocateAdvancePaymentToReceiptAsync(AllocateAdvancePaymentToReceiptRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AllocateAdvancePaymentToReceiptAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AllocateAdvancePaymentToReceiptResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/applycreditnotetoinvoice/ </summary>
    public async Task<System.Boolean> applyCreditNoteToInvoiceAsync(applyCreditNoteToInvoiceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.applyCreditNoteToInvoiceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.applyCreditNoteToInvoiceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/attachfiletoreceipt/ </summary>
    public async Task<System.Int32> AttachFileToReceiptAsync(AttachFileToReceiptRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AttachFileToReceiptAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AttachFileToReceiptResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/autoauthip/ </summary>
    public async Task<System.Int32> AutoAuthIPAsync(AutoAuthIPRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AutoAuthIPAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AutoAuthIPResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/convertquotetoinvoice/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> ConvertQuoteToInvoiceAsync(ConvertQuoteToInvoiceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.ConvertQuoteToInvoiceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.ConvertQuoteToInvoiceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/createaccount/ </summary>
    public async Task<System.Int32> createAccountAsync(createAccountRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.Username)) request.Username = Username;
      if (string.IsNullOrEmpty(request.password)) request.password = Password;

      var resp = await Client.createAccountAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.createAccountResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/createbankaccount/ </summary>
    public async Task<System.Int32> CreateBankAccountAsync(CreateBankAccountRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.CreateBankAccountAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.CreateBankAccountResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletebanktransaction/ </summary>
    public async Task<System.Int32> DeleteBankTransactionAsync(DeleteBankTransactionRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteBankTransactionAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteBankTransactionResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletecustomer/ </summary>
    public async Task<System.Int32> DeleteCustomerAsync(DeleteCustomerRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteCustomerAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteCustomerResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoice/ </summary>
    public async Task<System.Int32> DeleteInvoiceAsync(DeleteInvoiceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoiceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteInvoiceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicebyid/ </summary>
    public async Task<System.Int32> DeleteInvoiceByIDAsync(DeleteInvoiceByIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoiceByIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteInvoiceByIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoiceline/ </summary>
    public async Task<System.Int32> DeleteInvoiceLineAsync(DeleteInvoiceLineRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoiceLineAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteInvoiceLineResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicelinewithinvoiceid/ </summary>
    public async Task<System.Int32> DeleteInvoiceLineWithInvoiceIDAsync(DeleteInvoiceLineWithInvoiceIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoiceLineWithInvoiceIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteInvoiceLineWithInvoiceIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicepayment/ </summary>
    public async Task DeleteInvoicePaymentAsync(DeleteInvoicePaymentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoicePaymentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletejournal/ </summary>
    public async Task<System.Int32> DeleteJournalAsync(DeleteJournalRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteJournalAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteJournalResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletejournalbyid/ </summary>
    public async Task<System.Int32> DeleteJournalByIDAsync(DeleteJournalByIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteJournalByIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteJournalByIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequote/ </summary>
    public async Task<System.Int32> DeleteQuoteAsync(DeleteQuoteRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteQuoteAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteQuoteResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequotebyid/ </summary>
    public async Task<System.Int32> DeleteQuoteByIDAsync(DeleteQuoteByIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteQuoteByIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteQuoteByIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequoteline/ </summary>
    public async Task<System.Int32> DeleteQuoteLineAsync(DeleteQuoteLineRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteQuoteLineAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteQuoteLineResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequotelinewithquoteid/ </summary>
    public async Task<System.Int32> DeleteQuoteLineWithQuoteIDAsync(DeleteQuoteLineWithQuoteIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteQuoteLineWithQuoteIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteQuoteLineWithQuoteIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceipt/ </summary>
    public async Task<System.Int32> DeleteReceiptAsync(DeleteReceiptRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptattachment/ </summary>
    public async Task<System.Int32> DeleteReceiptAttachmentAsync(DeleteReceiptAttachmentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptAttachmentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptAttachmentResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptbyid/ </summary>
    public async Task<System.Int32> DeleteReceiptByIDAsync(DeleteReceiptByIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptByIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptByIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptline/ </summary>
    public async Task<System.Int32> DeleteReceiptLineAsync(DeleteReceiptLineRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptLineAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptLineResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptlinewithreceiptid/ </summary>
    public async Task<System.Int32> DeleteReceiptLineWithReceiptIDAsync(DeleteReceiptLineWithReceiptIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptLineWithReceiptIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptLineWithReceiptIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptpayment/ </summary>
    public async Task<System.Int32> DeleteReceiptPaymentAsync(DeleteReceiptPaymentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptPaymentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptPaymentResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletesupplier/ </summary>
    public async Task<System.Int32> DeleteSupplierAsync(DeleteSupplierRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteSupplierAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteSupplierResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/emailinvoice/ </summary>
    public async Task EmailInvoiceAsync(EmailInvoiceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.EmailInvoiceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/emailpurchaseorder/ </summary>
    public async Task<System.String> EmailPurchaseOrderAsync(EmailPurchaseOrderRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.EmailPurchaseOrderAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.EmailPurchaseOrderResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getaccountoverview/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.AccountOverview> GetAccountOverviewAsync(GetAccountOverviewRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetAccountOverviewAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetAccountOverviewResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getagedcreditors/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.AgedDebtorsCreditors[]> GetAgedCreditorsAsync(GetAgedCreditorsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetAgedCreditorsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetAgedCreditorsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getageddebtors/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.AgedDebtorsCreditors[]> GetAgedDebtorsAsync(GetAgedDebtorsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetAgedDebtorsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetAgedDebtorsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbalancesheet/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BalanceSheet> GetBalanceSheetAsync(GetBalanceSheetRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBalanceSheetAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBalanceSheetResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankaccounts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankAccount[]> GetBankAccountsAsync(GetBankAccountsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankAccountsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankAccountsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankbalance/ </summary>
    public async Task<System.Decimal> GetBankBalanceAsync(GetBankBalanceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankBalanceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankBalanceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankoverview/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankOverview[]> GetBankOverviewAsync(GetBankOverviewRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankOverviewAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankOverviewResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbanktransactions/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankTransaction[]> GetBankTransactionsAsync(GetBankTransactionsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankTransactionsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankTransactionsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbanktxtypes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankTXType[]> GetBankTxTypesAsync(GetBankTxTypesRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankTxTypesAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankTxTypesResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcompanydetails/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.CompanyDetails> GetCompanyDetailsAsync(GetCompanyDetailsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCompanyDetailsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCompanyDetailsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcurrencies/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Currencies[]> GetCurrenciesAsync(GetCurrenciesRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCurrenciesAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCurrenciesResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomeradvancepayments/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankTransaction[]> GetCustomerAdvancePaymentsAsync(GetCustomerAdvancePaymentsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerAdvancePaymentsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerAdvancePaymentsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomer/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer> GetCustomerAsync(GetCustomerRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbalance/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.CustomerBalance> GetCustomerBalanceAsync(GetCustomerBalanceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerBalanceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerBalanceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbyemail/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer> GetCustomerByEmailAsync(GetCustomerByEmailRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerByEmailAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerByEmailResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer> GetCustomerByIDAsync(GetCustomerByIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerByIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerByIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomercurrency/ </summary>
    public async Task<System.String> GetCustomerCurrencyAsync(GetCustomerCurrencyRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerCurrencyAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerCurrencyResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomers/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer[]> GetCustomersAsync(GetCustomersRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomersAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomersResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersbypostcode/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer[]> GetCustomersByPostcodeAsync(GetCustomersByPostcodeRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomersByPostcodeAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomersByPostcodeResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersmodifiedsince/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer[]> GetCustomersModifiedSinceAsync(GetCustomersModifiedSinceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomersModifiedSinceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomersModifiedSinceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersources/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetCustomerSourcesAsync(GetCustomerSourcesRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerSourcesAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerSourcesResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomervatnumber/ </summary>
    public async Task<System.String> GetCustomerVATNumberAsync(GetCustomerVATNumberRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerVATNumberAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerVATNumberResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getdigitacsvfile/ </summary>
    public async Task<System.String> GetDigitaCSVFileAsync(GetDigitaCSVFileRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetDigitaCSVFileAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetDigitaCSVFileResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getincomebycustomer/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetIncomeByCustomerAsync(GetIncomeByCustomerRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetIncomeByCustomerAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetIncomeByCustomerResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicetypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined> GetInvoice_TypeDefinedAsync(GetInvoice_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoice_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoice_TypeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoice/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetInvoiceAsync(GetInvoiceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoiceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoiceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicebyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetInvoiceByIDAsync(GetInvoiceByIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoiceByIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoiceByIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicenotes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.InvoiceNotes[]> GetInvoiceNotesAsync(GetInvoiceNotesRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoiceNotesAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoiceNotesResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepayment/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Payment[]> GetInvoicePaymentAsync(GetInvoicePaymentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicePaymentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicePaymentResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepaymentsbydaterange/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Payment[]> GetInvoicePaymentsByDateRangeAsync(GetInvoicePaymentsByDateRangeRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicePaymentsByDateRangeAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicePaymentsByDateRangeResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepaymentscountfordaterange/ </summary>
    public async Task<System.Int32> GetInvoicePaymentsCountforDateRangeAsync(GetInvoicePaymentsCountforDateRangeRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicePaymentsCountforDateRangeAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicePaymentsCountforDateRangeResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesoverduetypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[]> GetInvoices_Overdue_TypeDefinedAsync(GetInvoices_Overdue_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_Overdue_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_Overdue_TypeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesoverdue/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoices_OverdueAsync(GetInvoices_OverdueRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_OverdueAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_OverdueResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesrecenttypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[]> GetInvoices_Recent_TypeDefinedAsync(GetInvoices_Recent_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_Recent_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_Recent_TypeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesrecent/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoices_RecentAsync(GetInvoices_RecentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_RecentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_RecentResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesunpaidtypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[]> GetInvoices_Unpaid_TypeDefinedAsync(GetInvoices_Unpaid_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_Unpaid_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_Unpaid_TypeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesunpaid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoices_UnpaidAsync(GetInvoices_UnpaidRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_UnpaidAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_UnpaidResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesbydaterange/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoicesByDateRangeAsync(GetInvoicesByDateRangeRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicesByDateRangeAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicesByDateRangeResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesforcustomertypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[]> GetInvoicesForCustomer_typeDefinedAsync(GetInvoicesForCustomer_typeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicesForCustomer_typeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicesForCustomer_typeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesforcustomer/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoicesForCustomerAsync(GetInvoicesForCustomerRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicesForCustomerAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicesForCustomerResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvpaymethods/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.PaymentMethod[]> GetInvPayMethodsAsync(GetInvPayMethodsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvPayMethodsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvPayMethodsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getjournal/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.JournalEntry> GetJournalAsync(GetJournalRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetJournalAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetJournalResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getjournals/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.JournalEntry[]> GetJournalsAsync(GetJournalsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetJournalsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetJournalsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getkpis/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetKPIsAsync(GetKPIsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetKPIsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetKPIsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getmonthlyprofitandloss/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.MonthlyPL[]> GetMonthlyProfitAndLossAsync(GetMonthlyProfitAndLossRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetMonthlyProfitAndLossAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetMonthlyProfitAndLossResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalcodes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.NominalCode[]> GetNominalCodesAsync(GetNominalCodesRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetNominalCodesAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetNominalCodesResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalcodesextended/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.NominalCodeExtended[]> GetNominalCodesExtendedAsync(GetNominalCodesExtendedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetNominalCodesExtendedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetNominalCodesExtendedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalledger/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.TransactionInformation[]> GetNominalLedgerAsync(GetNominalLedgerRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetNominalLedgerAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetNominalLedgerResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getpaypallink/ </summary>
    public async Task<System.String> GetPaypalLinkAsync(GetPaypalLinkRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetPaypalLinkAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetPaypalLinkResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getproducts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Product[]> GetProductsAsync(GetProductsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProductsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProductsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getproductswithsubproducts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.ProductsFull[]> GetProductsWithSubProductsAsync(GetProductsWithSubProductsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProductsWithSubProductsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProductsWithSubProductsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprofitandloss/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.ProfitAndLoss> GetProfitAndLossAsync(GetProfitAndLossRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProfitAndLossAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProfitAndLossResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Project> GetProjectByIdAsync(GetProjectByIdRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjectByIdAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjectByIdResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyname/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Project> GetProjectByNameAsync(GetProjectByNameRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjectByNameAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjectByNameResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyref/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Project> GetProjectByRefAsync(GetProjectByRefRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjectByRefAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjectByRefResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectsfull/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Project[]> GetProjects_FullAsync(GetProjects_FullRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjects_FullAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjects_FullResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojects/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetProjectsAsync(GetProjectsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjectsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjectsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotebyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetQuoteByIDAsync(GetQuoteByIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuoteByIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuoteByIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotebynumber/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetQuoteByNumberAsync(GetQuoteByNumberRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuoteByNumberAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuoteByNumberResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotesrecent/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetQuotes_RecentAsync(GetQuotes_RecentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuotes_RecentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuotes_RecentResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetQuotesAsync(GetQuotesRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuotesAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuotesResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotesforcustomer/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetQuotesForCustomerAsync(GetQuotesForCustomerRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuotesForCustomerAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuotesForCustomerResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipttypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined> GetReceipt_TypeDefinedAsync(GetReceipt_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceipt_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceipt_TypeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipt/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetReceiptAsync(GetReceiptRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptattachments/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.ReceiptAttachment[]> GetReceiptAttachmentsAsync(GetReceiptAttachmentsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptAttachmentsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptAttachmentsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptnotes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.ReceiptNotes[]> GetReceiptNotesAsync(GetReceiptNotesRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptNotesAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptNotesResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptpayment/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Payment[]> GetReceiptPaymentAsync(GetReceiptPaymentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptPaymentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptPaymentResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptsrecent/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetReceipts_RecentAsync(GetReceipts_RecentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceipts_RecentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceipts_RecentResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetReceiptsAsync(GetReceiptsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptsforsupplier/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetReceiptsForSupplierAsync(GetReceiptsForSupplierRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptsForSupplierAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptsForSupplierResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptswithpaging/ </summary>
    public async Task<PagingResult<TipsTrade.KashFlow.KashFlowAPI.Invoice[]>> GetReceiptsWithPagingAsync(GetReceiptsWithPagingRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptsWithPagingAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };


      return new PagingResult<Invoice[]>() {
        TotalPages = resp.TotalPages,
        TotalRecords = resp.TotalRecords,
        Result = resp.GetReceiptsWithPagingResult
      };
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getrecpaymethods/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.PaymentMethod[]> GetRecPayMethodsAsync(GetRecPayMethodsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetRecPayMethodsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetRecPayMethodsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getremoteloginurl/ </summary>
    public async Task<System.String> GetRemoteLoginURLAsync(GetRemoteLoginURLRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetRemoteLoginURLAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetRemoteLoginURLResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproductbycode/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.SubProduct> GetSubProductByCodeAsync(GetSubProductByCodeRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSubProductByCodeAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSubProductByCodeResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproductbyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.SubProduct> GetSubProductByIDAsync(GetSubProductByIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSubProductByIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSubProductByIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproducts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.SubProduct[]> GetSubProductsAsync(GetSubProductsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSubProductsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSubProductsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsupplier/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Supplier> GetSupplierAsync(GetSupplierRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSupplierAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSupplierResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsupplierbyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Supplier> GetSupplierByIDAsync(GetSupplierByIDRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSupplierByIDAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSupplierByIDResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliercurrency/ </summary>
    public async Task<System.String> GetSupplierCurrencyAsync(GetSupplierCurrencyRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSupplierCurrencyAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSupplierCurrencyResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliers/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Supplier[]> GetSuppliersAsync(GetSuppliersRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSuppliersAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSuppliersResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliervatnumber/ </summary>
    public async Task<System.String> GetSupplierVATNumberAsync(GetSupplierVATNumberRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSupplierVATNumberAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSupplierVATNumberResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/gettrialbalance/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.NominalCode[]> GetTrialBalanceAsync(GetTrialBalanceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetTrialBalanceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetTrialBalanceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/gettrialbalancewithopeningbalances/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.NominalCodeBalance[]> GetTrialBalanceWithOpeningBalancesAsync(GetTrialBalanceWithOpeningBalancesRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetTrialBalanceWithOpeningBalancesAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetTrialBalanceWithOpeningBalancesResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getuseraccountdefaultstypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.UserAccountDefaults_TypeDefined> GetUserAccountDefaults_TypeDefinedAsync(GetUserAccountDefaults_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetUserAccountDefaults_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetUserAccountDefaults_TypeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getuseraccountdefaults/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.UserAccountDefaults> GetUserAccountDefaultsAsync(GetUserAccountDefaultsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetUserAccountDefaultsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetUserAccountDefaultsResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getvatrates/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetVATRatesAsync(GetVATRatesRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetVATRatesAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetVATRatesResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/getvatreport/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.VATReport> GetVATReportAsync(GetVATReportRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetVATReportAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetVATReportResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertbanktransaction/ </summary>
    public async Task<System.Int32> InsertBankTransactionAsync(InsertBankTransactionRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertBankTransactionAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertBankTransactionResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertcustomer/ </summary>
    public async Task<System.Int32> InsertCustomerAsync(InsertCustomerRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertCustomerAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertCustomerResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicetypedefined/ </summary>
    public async Task<System.Int32> InsertInvoice_TypeDefinedAsync(InsertInvoice_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoice_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoice_TypeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoice/ </summary>
    public async Task<System.Int32> InsertInvoiceAsync(InsertInvoiceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoiceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoiceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoiceline/ </summary>
    public async Task<System.Int32> InsertInvoiceLineAsync(InsertInvoiceLineRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoiceLineAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoiceLineResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicelinewithinvoicenumber/ </summary>
    public async Task<System.Int32> InsertInvoiceLineWithInvoiceNumberAsync(InsertInvoiceLineWithInvoiceNumberRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoiceLineWithInvoiceNumberAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoiceLineWithInvoiceNumberResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicenote/ </summary>
    public async Task<System.Boolean> InsertInvoiceNoteAsync(InsertInvoiceNoteRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoiceNoteAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoiceNoteResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicepayment/ </summary>
    public async Task<System.Int32> InsertInvoicePaymentAsync(InsertInvoicePaymentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoicePaymentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoicePaymentResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertjournal/ </summary>
    public async Task<System.Int32> InsertJournalAsync(InsertJournalRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertJournalAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertJournalResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertnominalcode/ </summary>
    public async Task<System.Int32> InsertNominalCodeAsync(InsertNominalCodeRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertNominalCodeAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertNominalCodeResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertorupdateproject/ </summary>
    public async Task<System.Int32> InsertOrUpdateProjectAsync(InsertOrUpdateProjectRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertOrUpdateProjectAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertOrUpdateProjectResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertquote/ </summary>
    public async Task<System.Int32> InsertQuoteAsync(InsertQuoteRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertQuoteAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertQuoteResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertquoteline/ </summary>
    public async Task<System.Int32> InsertQuoteLineAsync(InsertQuoteLineRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertQuoteLineAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertQuoteLineResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceipttypedefined/ </summary>
    public async Task<System.Int32> InsertReceipt_TypeDefinedAsync(InsertReceipt_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceipt_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceipt_TypeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceipt/ </summary>
    public async Task<System.Int32> InsertReceiptAsync(InsertReceiptRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptline/ </summary>
    public async Task<System.Int32> InsertReceiptLineAsync(InsertReceiptLineRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptLineAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptLineResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptlinefromnumber/ </summary>
    public async Task<System.Int32> InsertReceiptLineFromNumberAsync(InsertReceiptLineFromNumberRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptLineFromNumberAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptLineFromNumberResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptnote/ </summary>
    public async Task<System.Boolean> InsertReceiptNoteAsync(InsertReceiptNoteRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptNoteAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptNoteResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptpayment/ </summary>
    public async Task<System.Int32> InsertReceiptPaymentAsync(InsertReceiptPaymentRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptPaymentAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptPaymentResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertsupplier/ </summary>
    public async Task<System.Int32> InsertSupplierAsync(InsertSupplierRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertSupplierAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertSupplierResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/isonesaasenabled/ </summary>
    public async Task<System.Boolean> IsOneSaaSEnabledAsync(IsOneSaaSEnabledRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.IsOneSaaSEnabledAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.IsOneSaaSEnabledResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/isstillquote/ </summary>
    public async Task<System.Boolean> isStillQuoteAsync(isStillQuoteRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.isStillQuoteAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.isStillQuoteResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/isuservatregistered/ </summary>
    public async Task<System.Boolean> isUserVATRegisteredAsync(isUserVATRegisteredRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.isUserVATRegisteredAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.isUserVATRegisteredResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/printinvoice/ </summary>
    public async Task<System.String> PrintInvoiceAsync(PrintInvoiceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.PrintInvoiceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.PrintInvoiceResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/printpurchaseorder/ </summary>
    public async Task<System.String> PrintPurchaseOrderAsync(PrintPurchaseOrderRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.PrintPurchaseOrderAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.PrintPurchaseOrderResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/sagefile/ </summary>
    public async Task<System.String> SageFileAsync(Byte[] request, string reference, CancellationToken cancellationToken = default) {
      var resp = await Client.SageFileAsync(request, reference).WaitAsync(cancellationToken);

      return resp.SageFileResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/sagefileimport/ </summary>
    public async Task SageFileImportAsync(Int32 request, CancellationToken cancellationToken = default) {
      var resp = await Client.SageFileImportAsync(request).WaitAsync(cancellationToken);

    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/searchcustomerbycusttext/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer> SearchCustomerByCustTextAsync(SearchCustomerByCustTextRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SearchCustomerByCustTextAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SearchCustomerByCustTextResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/setcustomercurrency/ </summary>
    public async Task<System.Int32> SetCustomerCurrencyAsync(SetCustomerCurrencyRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SetCustomerCurrencyAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SetCustomerCurrencyResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/setcustomervatnumber/ </summary>
    public async Task<System.Int32> SetCustomerVATNumberAsync(SetCustomerVATNumberRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SetCustomerVATNumberAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SetCustomerVATNumberResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/setsuppliercurrency/ </summary>
    public async Task<System.Int32> SetSupplierCurrencyAsync(SetSupplierCurrencyRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SetSupplierCurrencyAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SetSupplierCurrencyResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/setsuppliervatnumber/ </summary>
    public async Task<System.Int32> SetSupplierVATNumberAsync(SetSupplierVATNumberRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SetSupplierVATNumberAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SetSupplierVATNumberResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatebanktransaction/ </summary>
    public async Task<System.Int32> UpdateBankTransactionAsync(UpdateBankTransactionRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateBankTransactionAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateBankTransactionResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatecustomer/ </summary>
    public async Task<System.String> UpdateCustomerAsync(UpdateCustomerRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateCustomerAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateCustomerResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoicetypedefined/ </summary>
    public async Task UpdateInvoice_TypeDefinedAsync(UpdateInvoice_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateInvoice_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoice/ </summary>
    public async Task UpdateInvoiceAsync(UpdateInvoiceRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateInvoiceAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoiceheader/ </summary>
    public async Task UpdateInvoiceHeaderAsync(UpdateInvoiceHeaderRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateInvoiceHeaderAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatejournal/ </summary>
    public async Task<System.Int32> UpdateJournalAsync(UpdateJournalRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateJournalAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateJournalResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatejournalheader/ </summary>
    public async Task<System.Int32> UpdateJournalHeaderAsync(UpdateJournalHeaderRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateJournalHeaderAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateJournalHeaderResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatequote/ </summary>
    public async Task<System.Int32> UpdateQuoteAsync(UpdateQuoteRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateQuoteAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateQuoteResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatequoteheader/ </summary>
    public async Task<System.Int32> UpdateQuoteHeaderAsync(UpdateQuoteHeaderRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateQuoteHeaderAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateQuoteHeaderResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceipttypedefined/ </summary>
    public async Task<System.Int32> UpdateReceipt_TypeDefinedAsync(UpdateReceipt_TypeDefinedRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateReceipt_TypeDefinedAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateReceipt_TypeDefinedResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceipt/ </summary>
    public async Task<System.Int32> UpdateReceiptAsync(UpdateReceiptRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateReceiptAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateReceiptResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceiptheader/ </summary>
    public async Task<System.Int32> UpdateReceiptHeaderAsync(UpdateReceiptHeaderRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateReceiptHeaderAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateReceiptHeaderResult;
    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatesupplier/ </summary>
    public async Task UpdateSupplierAsync(UpdateSupplierRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateSupplierAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

    ///<summary>See https://www.kashflow.com/developers/soap-api/vcftocustomerobjects/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer[]> VCFToCustomerObjectsAsync(VCFToCustomerObjectsRequest request, CancellationToken cancellationToken = default) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.VCFToCustomerObjectsAsync(request).WaitAsync(cancellationToken);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.VCFToCustomerObjectsResult;
    }

#pragma warning disable IDE0018, IDE1006
    #endregion
  }
}
