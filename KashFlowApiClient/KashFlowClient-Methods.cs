using TipsTrade.KashFlow.KashFlowAPI;
using System;
using System.Threading.Tasks;

namespace TipsTrade.KashFlow {
  public partial class KashFlowClient {
    #region Automatically generated methods
#pragma warning disable IDE0018, IDE1006
#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/addorupdatesubproduct/ </summary>
    public System.Int32 AddOrUpdateSubProduct(AddOrUpdateSubProductRequest request) {
      return Task.Run(async () => await AddOrUpdateSubProductAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/addorupdatesubproduct/ </summary>
    public async Task<System.Int32> AddOrUpdateSubProductAsync(AddOrUpdateSubProductRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AddOrUpdateSubProductAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AddOrUpdateSubProductResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/allocateadvancepaymenttoinvoice/ </summary>
    public System.Int32 AllocateAdvancePaymentToInvoice(AllocateAdvancePaymentToInvoiceRequest request) {
      return Task.Run(async () => await AllocateAdvancePaymentToInvoiceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/allocateadvancepaymenttoinvoice/ </summary>
    public async Task<System.Int32> AllocateAdvancePaymentToInvoiceAsync(AllocateAdvancePaymentToInvoiceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AllocateAdvancePaymentToInvoiceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AllocateAdvancePaymentToInvoiceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/allocateadvancepaymenttoreceipt/ </summary>
    public System.Int32 AllocateAdvancePaymentToReceipt(AllocateAdvancePaymentToReceiptRequest request) {
      return Task.Run(async () => await AllocateAdvancePaymentToReceiptAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/allocateadvancepaymenttoreceipt/ </summary>
    public async Task<System.Int32> AllocateAdvancePaymentToReceiptAsync(AllocateAdvancePaymentToReceiptRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AllocateAdvancePaymentToReceiptAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AllocateAdvancePaymentToReceiptResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/applycreditnotetoinvoice/ </summary>
    public System.Boolean applyCreditNoteToInvoice(applyCreditNoteToInvoiceRequest request) {
      return Task.Run(async () => await applyCreditNoteToInvoiceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/applycreditnotetoinvoice/ </summary>
    public async Task<System.Boolean> applyCreditNoteToInvoiceAsync(applyCreditNoteToInvoiceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.applyCreditNoteToInvoiceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.applyCreditNoteToInvoiceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/attachfiletoreceipt/ </summary>
    public System.Int32 AttachFileToReceipt(AttachFileToReceiptRequest request) {
      return Task.Run(async () => await AttachFileToReceiptAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/attachfiletoreceipt/ </summary>
    public async Task<System.Int32> AttachFileToReceiptAsync(AttachFileToReceiptRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AttachFileToReceiptAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AttachFileToReceiptResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/autoauthip/ </summary>
    public System.Int32 AutoAuthIP(AutoAuthIPRequest request) {
      return Task.Run(async () => await AutoAuthIPAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/autoauthip/ </summary>
    public async Task<System.Int32> AutoAuthIPAsync(AutoAuthIPRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.AutoAuthIPAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.AutoAuthIPResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/convertquotetoinvoice/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice ConvertQuoteToInvoice(ConvertQuoteToInvoiceRequest request) {
      return Task.Run(async () => await ConvertQuoteToInvoiceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/convertquotetoinvoice/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> ConvertQuoteToInvoiceAsync(ConvertQuoteToInvoiceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.ConvertQuoteToInvoiceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.ConvertQuoteToInvoiceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/createaccount/ </summary>
    public System.Int32 createAccount(createAccountRequest request) {
      return Task.Run(async () => await createAccountAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/createaccount/ </summary>
    public async Task<System.Int32> createAccountAsync(createAccountRequest request) {
      if (string.IsNullOrEmpty(request.Username)) request.Username = Username;
      if (string.IsNullOrEmpty(request.password)) request.password = Password;

      var resp = await Client.createAccountAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.createAccountResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/createbankaccount/ </summary>
    public System.Int32 CreateBankAccount(CreateBankAccountRequest request) {
      return Task.Run(async () => await CreateBankAccountAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/createbankaccount/ </summary>
    public async Task<System.Int32> CreateBankAccountAsync(CreateBankAccountRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.CreateBankAccountAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.CreateBankAccountResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletebanktransaction/ </summary>
    public System.Int32 DeleteBankTransaction(DeleteBankTransactionRequest request) {
      return Task.Run(async () => await DeleteBankTransactionAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletebanktransaction/ </summary>
    public async Task<System.Int32> DeleteBankTransactionAsync(DeleteBankTransactionRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteBankTransactionAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteBankTransactionResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletecustomer/ </summary>
    public System.Int32 DeleteCustomer(DeleteCustomerRequest request) {
      return Task.Run(async () => await DeleteCustomerAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletecustomer/ </summary>
    public async Task<System.Int32> DeleteCustomerAsync(DeleteCustomerRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteCustomerAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteCustomerResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoice/ </summary>
    public System.Int32 DeleteInvoice(DeleteInvoiceRequest request) {
      return Task.Run(async () => await DeleteInvoiceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoice/ </summary>
    public async Task<System.Int32> DeleteInvoiceAsync(DeleteInvoiceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoiceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteInvoiceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicebyid/ </summary>
    public System.Int32 DeleteInvoiceByID(DeleteInvoiceByIDRequest request) {
      return Task.Run(async () => await DeleteInvoiceByIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicebyid/ </summary>
    public async Task<System.Int32> DeleteInvoiceByIDAsync(DeleteInvoiceByIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoiceByIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteInvoiceByIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoiceline/ </summary>
    public System.Int32 DeleteInvoiceLine(DeleteInvoiceLineRequest request) {
      return Task.Run(async () => await DeleteInvoiceLineAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoiceline/ </summary>
    public async Task<System.Int32> DeleteInvoiceLineAsync(DeleteInvoiceLineRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoiceLineAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteInvoiceLineResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicelinewithinvoiceid/ </summary>
    public System.Int32 DeleteInvoiceLineWithInvoiceID(DeleteInvoiceLineWithInvoiceIDRequest request) {
      return Task.Run(async () => await DeleteInvoiceLineWithInvoiceIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicelinewithinvoiceid/ </summary>
    public async Task<System.Int32> DeleteInvoiceLineWithInvoiceIDAsync(DeleteInvoiceLineWithInvoiceIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoiceLineWithInvoiceIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteInvoiceLineWithInvoiceIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicepayment/ </summary>
    public void DeleteInvoicePayment(DeleteInvoicePaymentRequest request) {
      Task.Run(async () => await DeleteInvoicePaymentAsync(request)).Wait();
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deleteinvoicepayment/ </summary>
    public async Task DeleteInvoicePaymentAsync(DeleteInvoicePaymentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteInvoicePaymentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletejournal/ </summary>
    public System.Int32 DeleteJournal(DeleteJournalRequest request) {
      return Task.Run(async () => await DeleteJournalAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletejournal/ </summary>
    public async Task<System.Int32> DeleteJournalAsync(DeleteJournalRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteJournalAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteJournalResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletejournalbyid/ </summary>
    public System.Int32 DeleteJournalByID(DeleteJournalByIDRequest request) {
      return Task.Run(async () => await DeleteJournalByIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletejournalbyid/ </summary>
    public async Task<System.Int32> DeleteJournalByIDAsync(DeleteJournalByIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteJournalByIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteJournalByIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequote/ </summary>
    public System.Int32 DeleteQuote(DeleteQuoteRequest request) {
      return Task.Run(async () => await DeleteQuoteAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequote/ </summary>
    public async Task<System.Int32> DeleteQuoteAsync(DeleteQuoteRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteQuoteAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteQuoteResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequotebyid/ </summary>
    public System.Int32 DeleteQuoteByID(DeleteQuoteByIDRequest request) {
      return Task.Run(async () => await DeleteQuoteByIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequotebyid/ </summary>
    public async Task<System.Int32> DeleteQuoteByIDAsync(DeleteQuoteByIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteQuoteByIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteQuoteByIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequoteline/ </summary>
    public System.Int32 DeleteQuoteLine(DeleteQuoteLineRequest request) {
      return Task.Run(async () => await DeleteQuoteLineAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequoteline/ </summary>
    public async Task<System.Int32> DeleteQuoteLineAsync(DeleteQuoteLineRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteQuoteLineAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteQuoteLineResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequotelinewithquoteid/ </summary>
    public System.Int32 DeleteQuoteLineWithQuoteID(DeleteQuoteLineWithQuoteIDRequest request) {
      return Task.Run(async () => await DeleteQuoteLineWithQuoteIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletequotelinewithquoteid/ </summary>
    public async Task<System.Int32> DeleteQuoteLineWithQuoteIDAsync(DeleteQuoteLineWithQuoteIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteQuoteLineWithQuoteIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteQuoteLineWithQuoteIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceipt/ </summary>
    public System.Int32 DeleteReceipt(DeleteReceiptRequest request) {
      return Task.Run(async () => await DeleteReceiptAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceipt/ </summary>
    public async Task<System.Int32> DeleteReceiptAsync(DeleteReceiptRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptattachment/ </summary>
    public System.Int32 DeleteReceiptAttachment(DeleteReceiptAttachmentRequest request) {
      return Task.Run(async () => await DeleteReceiptAttachmentAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptattachment/ </summary>
    public async Task<System.Int32> DeleteReceiptAttachmentAsync(DeleteReceiptAttachmentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptAttachmentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptAttachmentResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptbyid/ </summary>
    public System.Int32 DeleteReceiptByID(DeleteReceiptByIDRequest request) {
      return Task.Run(async () => await DeleteReceiptByIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptbyid/ </summary>
    public async Task<System.Int32> DeleteReceiptByIDAsync(DeleteReceiptByIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptByIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptByIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptline/ </summary>
    public System.Int32 DeleteReceiptLine(DeleteReceiptLineRequest request) {
      return Task.Run(async () => await DeleteReceiptLineAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptline/ </summary>
    public async Task<System.Int32> DeleteReceiptLineAsync(DeleteReceiptLineRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptLineAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptLineResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptlinewithreceiptid/ </summary>
    public System.Int32 DeleteReceiptLineWithReceiptID(DeleteReceiptLineWithReceiptIDRequest request) {
      return Task.Run(async () => await DeleteReceiptLineWithReceiptIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptlinewithreceiptid/ </summary>
    public async Task<System.Int32> DeleteReceiptLineWithReceiptIDAsync(DeleteReceiptLineWithReceiptIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptLineWithReceiptIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptLineWithReceiptIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptpayment/ </summary>
    public System.Int32 DeleteReceiptPayment(DeleteReceiptPaymentRequest request) {
      return Task.Run(async () => await DeleteReceiptPaymentAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletereceiptpayment/ </summary>
    public async Task<System.Int32> DeleteReceiptPaymentAsync(DeleteReceiptPaymentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteReceiptPaymentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteReceiptPaymentResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/deletesupplier/ </summary>
    public System.Int32 DeleteSupplier(DeleteSupplierRequest request) {
      return Task.Run(async () => await DeleteSupplierAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/deletesupplier/ </summary>
    public async Task<System.Int32> DeleteSupplierAsync(DeleteSupplierRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.DeleteSupplierAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.DeleteSupplierResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/emailinvoice/ </summary>
    public void EmailInvoice(EmailInvoiceRequest request) {
      Task.Run(async () => await EmailInvoiceAsync(request)).Wait();
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/emailinvoice/ </summary>
    public async Task EmailInvoiceAsync(EmailInvoiceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.EmailInvoiceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/emailpurchaseorder/ </summary>
    public System.String EmailPurchaseOrder(EmailPurchaseOrderRequest request) {
      return Task.Run(async () => await EmailPurchaseOrderAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/emailpurchaseorder/ </summary>
    public async Task<System.String> EmailPurchaseOrderAsync(EmailPurchaseOrderRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.EmailPurchaseOrderAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.EmailPurchaseOrderResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getaccountoverview/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.AccountOverview GetAccountOverview(GetAccountOverviewRequest request) {
      return Task.Run(async () => await GetAccountOverviewAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getaccountoverview/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.AccountOverview> GetAccountOverviewAsync(GetAccountOverviewRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetAccountOverviewAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetAccountOverviewResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getagedcreditors/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.AgedDebtorsCreditors[] GetAgedCreditors(GetAgedCreditorsRequest request) {
      return Task.Run(async () => await GetAgedCreditorsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getagedcreditors/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.AgedDebtorsCreditors[]> GetAgedCreditorsAsync(GetAgedCreditorsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetAgedCreditorsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetAgedCreditorsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getageddebtors/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.AgedDebtorsCreditors[] GetAgedDebtors(GetAgedDebtorsRequest request) {
      return Task.Run(async () => await GetAgedDebtorsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getageddebtors/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.AgedDebtorsCreditors[]> GetAgedDebtorsAsync(GetAgedDebtorsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetAgedDebtorsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetAgedDebtorsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getbalancesheet/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BalanceSheet GetBalanceSheet(GetBalanceSheetRequest request) {
      return Task.Run(async () => await GetBalanceSheetAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbalancesheet/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BalanceSheet> GetBalanceSheetAsync(GetBalanceSheetRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBalanceSheetAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBalanceSheetResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankaccounts/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BankAccount[] GetBankAccounts(GetBankAccountsRequest request) {
      return Task.Run(async () => await GetBankAccountsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankaccounts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankAccount[]> GetBankAccountsAsync(GetBankAccountsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankAccountsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankAccountsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankbalance/ </summary>
    public System.Decimal GetBankBalance(GetBankBalanceRequest request) {
      return Task.Run(async () => await GetBankBalanceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankbalance/ </summary>
    public async Task<System.Decimal> GetBankBalanceAsync(GetBankBalanceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankBalanceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankBalanceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankoverview/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BankOverview[] GetBankOverview(GetBankOverviewRequest request) {
      return Task.Run(async () => await GetBankOverviewAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbankoverview/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankOverview[]> GetBankOverviewAsync(GetBankOverviewRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankOverviewAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankOverviewResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getbanktransactions/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BankTransaction[] GetBankTransactions(GetBankTransactionsRequest request) {
      return Task.Run(async () => await GetBankTransactionsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbanktransactions/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankTransaction[]> GetBankTransactionsAsync(GetBankTransactionsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankTransactionsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankTransactionsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getbanktxtypes/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BankTXType[] GetBankTxTypes(GetBankTxTypesRequest request) {
      return Task.Run(async () => await GetBankTxTypesAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getbanktxtypes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankTXType[]> GetBankTxTypesAsync(GetBankTxTypesRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetBankTxTypesAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetBankTxTypesResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcompanydetails/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.CompanyDetails GetCompanyDetails(GetCompanyDetailsRequest request) {
      return Task.Run(async () => await GetCompanyDetailsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcompanydetails/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.CompanyDetails> GetCompanyDetailsAsync(GetCompanyDetailsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCompanyDetailsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCompanyDetailsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcurrencies/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Currencies[] GetCurrencies(GetCurrenciesRequest request) {
      return Task.Run(async () => await GetCurrenciesAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcurrencies/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Currencies[]> GetCurrenciesAsync(GetCurrenciesRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCurrenciesAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCurrenciesResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomeradvancepayments/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BankTransaction[] GetCustomerAdvancePayments(GetCustomerAdvancePaymentsRequest request) {
      return Task.Run(async () => await GetCustomerAdvancePaymentsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomeradvancepayments/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BankTransaction[]> GetCustomerAdvancePaymentsAsync(GetCustomerAdvancePaymentsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerAdvancePaymentsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerAdvancePaymentsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomer/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Customer GetCustomer(GetCustomerRequest request) {
      return Task.Run(async () => await GetCustomerAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomer/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer> GetCustomerAsync(GetCustomerRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbalance/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.CustomerBalance GetCustomerBalance(GetCustomerBalanceRequest request) {
      return Task.Run(async () => await GetCustomerBalanceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbalance/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.CustomerBalance> GetCustomerBalanceAsync(GetCustomerBalanceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerBalanceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerBalanceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbyemail/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Customer GetCustomerByEmail(GetCustomerByEmailRequest request) {
      return Task.Run(async () => await GetCustomerByEmailAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbyemail/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer> GetCustomerByEmailAsync(GetCustomerByEmailRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerByEmailAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerByEmailResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbyid/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Customer GetCustomerByID(GetCustomerByIDRequest request) {
      return Task.Run(async () => await GetCustomerByIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomerbyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer> GetCustomerByIDAsync(GetCustomerByIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerByIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerByIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomercurrency/ </summary>
    public System.String GetCustomerCurrency(GetCustomerCurrencyRequest request) {
      return Task.Run(async () => await GetCustomerCurrencyAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomercurrency/ </summary>
    public async Task<System.String> GetCustomerCurrencyAsync(GetCustomerCurrencyRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerCurrencyAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerCurrencyResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomers/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Customer[] GetCustomers(GetCustomersRequest request) {
      return Task.Run(async () => await GetCustomersAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomers/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer[]> GetCustomersAsync(GetCustomersRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomersAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomersResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersbypostcode/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Customer[] GetCustomersByPostcode(GetCustomersByPostcodeRequest request) {
      return Task.Run(async () => await GetCustomersByPostcodeAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersbypostcode/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer[]> GetCustomersByPostcodeAsync(GetCustomersByPostcodeRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomersByPostcodeAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomersByPostcodeResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersmodifiedsince/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Customer[] GetCustomersModifiedSince(GetCustomersModifiedSinceRequest request) {
      return Task.Run(async () => await GetCustomersModifiedSinceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersmodifiedsince/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer[]> GetCustomersModifiedSinceAsync(GetCustomersModifiedSinceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomersModifiedSinceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomersModifiedSinceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersources/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BasicDataset[] GetCustomerSources(GetCustomerSourcesRequest request) {
      return Task.Run(async () => await GetCustomerSourcesAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomersources/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetCustomerSourcesAsync(GetCustomerSourcesRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerSourcesAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerSourcesResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomervatnumber/ </summary>
    public System.String GetCustomerVATNumber(GetCustomerVATNumberRequest request) {
      return Task.Run(async () => await GetCustomerVATNumberAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getcustomervatnumber/ </summary>
    public async Task<System.String> GetCustomerVATNumberAsync(GetCustomerVATNumberRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetCustomerVATNumberAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetCustomerVATNumberResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getdigitacsvfile/ </summary>
    public System.String GetDigitaCSVFile(GetDigitaCSVFileRequest request) {
      return Task.Run(async () => await GetDigitaCSVFileAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getdigitacsvfile/ </summary>
    public async Task<System.String> GetDigitaCSVFileAsync(GetDigitaCSVFileRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetDigitaCSVFileAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetDigitaCSVFileResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getincomebycustomer/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BasicDataset[] GetIncomeByCustomer(GetIncomeByCustomerRequest request) {
      return Task.Run(async () => await GetIncomeByCustomerAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getincomebycustomer/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetIncomeByCustomerAsync(GetIncomeByCustomerRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetIncomeByCustomerAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetIncomeByCustomerResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicetypedefined/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined GetInvoice_TypeDefined(GetInvoice_TypeDefinedRequest request) {
      return Task.Run(async () => await GetInvoice_TypeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicetypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined> GetInvoice_TypeDefinedAsync(GetInvoice_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoice_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoice_TypeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoice/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice GetInvoice(GetInvoiceRequest request) {
      return Task.Run(async () => await GetInvoiceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoice/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetInvoiceAsync(GetInvoiceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoiceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoiceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicebyid/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice GetInvoiceByID(GetInvoiceByIDRequest request) {
      return Task.Run(async () => await GetInvoiceByIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicebyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetInvoiceByIDAsync(GetInvoiceByIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoiceByIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoiceByIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicenotes/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.InvoiceNotes[] GetInvoiceNotes(GetInvoiceNotesRequest request) {
      return Task.Run(async () => await GetInvoiceNotesAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicenotes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.InvoiceNotes[]> GetInvoiceNotesAsync(GetInvoiceNotesRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoiceNotesAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoiceNotesResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepayment/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Payment[] GetInvoicePayment(GetInvoicePaymentRequest request) {
      return Task.Run(async () => await GetInvoicePaymentAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepayment/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Payment[]> GetInvoicePaymentAsync(GetInvoicePaymentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicePaymentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicePaymentResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepaymentsbydaterange/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Payment[] GetInvoicePaymentsByDateRange(GetInvoicePaymentsByDateRangeRequest request) {
      return Task.Run(async () => await GetInvoicePaymentsByDateRangeAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepaymentsbydaterange/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Payment[]> GetInvoicePaymentsByDateRangeAsync(GetInvoicePaymentsByDateRangeRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicePaymentsByDateRangeAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicePaymentsByDateRangeResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepaymentscountfordaterange/ </summary>
    public System.Int32 GetInvoicePaymentsCountforDateRange(GetInvoicePaymentsCountforDateRangeRequest request) {
      return Task.Run(async () => await GetInvoicePaymentsCountforDateRangeAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicepaymentscountfordaterange/ </summary>
    public async Task<System.Int32> GetInvoicePaymentsCountforDateRangeAsync(GetInvoicePaymentsCountforDateRangeRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicePaymentsCountforDateRangeAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicePaymentsCountforDateRangeResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesoverduetypedefined/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[] GetInvoices_Overdue_TypeDefined(GetInvoices_Overdue_TypeDefinedRequest request) {
      return Task.Run(async () => await GetInvoices_Overdue_TypeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesoverduetypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[]> GetInvoices_Overdue_TypeDefinedAsync(GetInvoices_Overdue_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_Overdue_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_Overdue_TypeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesoverdue/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetInvoices_Overdue(GetInvoices_OverdueRequest request) {
      return Task.Run(async () => await GetInvoices_OverdueAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesoverdue/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoices_OverdueAsync(GetInvoices_OverdueRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_OverdueAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_OverdueResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesrecenttypedefined/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[] GetInvoices_Recent_TypeDefined(GetInvoices_Recent_TypeDefinedRequest request) {
      return Task.Run(async () => await GetInvoices_Recent_TypeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesrecenttypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[]> GetInvoices_Recent_TypeDefinedAsync(GetInvoices_Recent_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_Recent_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_Recent_TypeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesrecent/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetInvoices_Recent(GetInvoices_RecentRequest request) {
      return Task.Run(async () => await GetInvoices_RecentAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesrecent/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoices_RecentAsync(GetInvoices_RecentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_RecentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_RecentResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesunpaidtypedefined/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[] GetInvoices_Unpaid_TypeDefined(GetInvoices_Unpaid_TypeDefinedRequest request) {
      return Task.Run(async () => await GetInvoices_Unpaid_TypeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesunpaidtypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[]> GetInvoices_Unpaid_TypeDefinedAsync(GetInvoices_Unpaid_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_Unpaid_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_Unpaid_TypeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesunpaid/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetInvoices_Unpaid(GetInvoices_UnpaidRequest request) {
      return Task.Run(async () => await GetInvoices_UnpaidAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesunpaid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoices_UnpaidAsync(GetInvoices_UnpaidRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoices_UnpaidAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoices_UnpaidResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesbydaterange/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetInvoicesByDateRange(GetInvoicesByDateRangeRequest request) {
      return Task.Run(async () => await GetInvoicesByDateRangeAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesbydaterange/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoicesByDateRangeAsync(GetInvoicesByDateRangeRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicesByDateRangeAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicesByDateRangeResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesforcustomertypedefined/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[] GetInvoicesForCustomer_typeDefined(GetInvoicesForCustomer_typeDefinedRequest request) {
      return Task.Run(async () => await GetInvoicesForCustomer_typeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesforcustomertypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined[]> GetInvoicesForCustomer_typeDefinedAsync(GetInvoicesForCustomer_typeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicesForCustomer_typeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicesForCustomer_typeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesforcustomer/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetInvoicesForCustomer(GetInvoicesForCustomerRequest request) {
      return Task.Run(async () => await GetInvoicesForCustomerAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvoicesforcustomer/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetInvoicesForCustomerAsync(GetInvoicesForCustomerRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvoicesForCustomerAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvoicesForCustomerResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvpaymethods/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.PaymentMethod[] GetInvPayMethods(GetInvPayMethodsRequest request) {
      return Task.Run(async () => await GetInvPayMethodsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getinvpaymethods/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.PaymentMethod[]> GetInvPayMethodsAsync(GetInvPayMethodsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetInvPayMethodsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetInvPayMethodsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getjournal/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.JournalEntry GetJournal(GetJournalRequest request) {
      return Task.Run(async () => await GetJournalAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getjournal/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.JournalEntry> GetJournalAsync(GetJournalRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetJournalAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetJournalResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getjournals/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.JournalEntry[] GetJournals(GetJournalsRequest request) {
      return Task.Run(async () => await GetJournalsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getjournals/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.JournalEntry[]> GetJournalsAsync(GetJournalsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetJournalsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetJournalsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getkpis/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BasicDataset[] GetKPIs(GetKPIsRequest request) {
      return Task.Run(async () => await GetKPIsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getkpis/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetKPIsAsync(GetKPIsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetKPIsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetKPIsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getmonthlyprofitandloss/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.MonthlyPL[] GetMonthlyProfitAndLoss(GetMonthlyProfitAndLossRequest request) {
      return Task.Run(async () => await GetMonthlyProfitAndLossAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getmonthlyprofitandloss/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.MonthlyPL[]> GetMonthlyProfitAndLossAsync(GetMonthlyProfitAndLossRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetMonthlyProfitAndLossAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetMonthlyProfitAndLossResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalcodes/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.NominalCode[] GetNominalCodes(GetNominalCodesRequest request) {
      return Task.Run(async () => await GetNominalCodesAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalcodes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.NominalCode[]> GetNominalCodesAsync(GetNominalCodesRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetNominalCodesAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetNominalCodesResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalcodesextended/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.NominalCodeExtended[] GetNominalCodesExtended(GetNominalCodesExtendedRequest request) {
      return Task.Run(async () => await GetNominalCodesExtendedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalcodesextended/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.NominalCodeExtended[]> GetNominalCodesExtendedAsync(GetNominalCodesExtendedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetNominalCodesExtendedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetNominalCodesExtendedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalledger/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.TransactionInformation[] GetNominalLedger(GetNominalLedgerRequest request) {
      return Task.Run(async () => await GetNominalLedgerAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getnominalledger/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.TransactionInformation[]> GetNominalLedgerAsync(GetNominalLedgerRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetNominalLedgerAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetNominalLedgerResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getpaypallink/ </summary>
    public System.String GetPaypalLink(GetPaypalLinkRequest request) {
      return Task.Run(async () => await GetPaypalLinkAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getpaypallink/ </summary>
    public async Task<System.String> GetPaypalLinkAsync(GetPaypalLinkRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetPaypalLinkAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetPaypalLinkResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getproducts/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Product[] GetProducts(GetProductsRequest request) {
      return Task.Run(async () => await GetProductsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getproducts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Product[]> GetProductsAsync(GetProductsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProductsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProductsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getproductswithsubproducts/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.ProductsFull[] GetProductsWithSubProducts(GetProductsWithSubProductsRequest request) {
      return Task.Run(async () => await GetProductsWithSubProductsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getproductswithsubproducts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.ProductsFull[]> GetProductsWithSubProductsAsync(GetProductsWithSubProductsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProductsWithSubProductsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProductsWithSubProductsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getprofitandloss/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.ProfitAndLoss GetProfitAndLoss(GetProfitAndLossRequest request) {
      return Task.Run(async () => await GetProfitAndLossAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprofitandloss/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.ProfitAndLoss> GetProfitAndLossAsync(GetProfitAndLossRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProfitAndLossAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProfitAndLossResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyid/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Project GetProjectById(GetProjectByIdRequest request) {
      return Task.Run(async () => await GetProjectByIdAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Project> GetProjectByIdAsync(GetProjectByIdRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjectByIdAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjectByIdResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyname/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Project GetProjectByName(GetProjectByNameRequest request) {
      return Task.Run(async () => await GetProjectByNameAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyname/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Project> GetProjectByNameAsync(GetProjectByNameRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjectByNameAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjectByNameResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyref/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Project GetProjectByRef(GetProjectByRefRequest request) {
      return Task.Run(async () => await GetProjectByRefAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectbyref/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Project> GetProjectByRefAsync(GetProjectByRefRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjectByRefAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjectByRefResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectsfull/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Project[] GetProjects_Full(GetProjects_FullRequest request) {
      return Task.Run(async () => await GetProjects_FullAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojectsfull/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Project[]> GetProjects_FullAsync(GetProjects_FullRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjects_FullAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjects_FullResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojects/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BasicDataset[] GetProjects(GetProjectsRequest request) {
      return Task.Run(async () => await GetProjectsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getprojects/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetProjectsAsync(GetProjectsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetProjectsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetProjectsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotebyid/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice GetQuoteByID(GetQuoteByIDRequest request) {
      return Task.Run(async () => await GetQuoteByIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotebyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetQuoteByIDAsync(GetQuoteByIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuoteByIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuoteByIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotebynumber/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice GetQuoteByNumber(GetQuoteByNumberRequest request) {
      return Task.Run(async () => await GetQuoteByNumberAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotebynumber/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetQuoteByNumberAsync(GetQuoteByNumberRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuoteByNumberAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuoteByNumberResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotesrecent/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetQuotes_Recent(GetQuotes_RecentRequest request) {
      return Task.Run(async () => await GetQuotes_RecentAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotesrecent/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetQuotes_RecentAsync(GetQuotes_RecentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuotes_RecentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuotes_RecentResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotes/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetQuotes(GetQuotesRequest request) {
      return Task.Run(async () => await GetQuotesAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetQuotesAsync(GetQuotesRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuotesAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuotesResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotesforcustomer/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetQuotesForCustomer(GetQuotesForCustomerRequest request) {
      return Task.Run(async () => await GetQuotesForCustomerAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getquotesforcustomer/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetQuotesForCustomerAsync(GetQuotesForCustomerRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetQuotesForCustomerAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetQuotesForCustomerResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipttypedefined/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined GetReceipt_TypeDefined(GetReceipt_TypeDefinedRequest request) {
      return Task.Run(async () => await GetReceipt_TypeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipttypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice_TypeDefined> GetReceipt_TypeDefinedAsync(GetReceipt_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceipt_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceipt_TypeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipt/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice GetReceipt(GetReceiptRequest request) {
      return Task.Run(async () => await GetReceiptAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipt/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice> GetReceiptAsync(GetReceiptRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptattachments/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.ReceiptAttachment[] GetReceiptAttachments(GetReceiptAttachmentsRequest request) {
      return Task.Run(async () => await GetReceiptAttachmentsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptattachments/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.ReceiptAttachment[]> GetReceiptAttachmentsAsync(GetReceiptAttachmentsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptAttachmentsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptAttachmentsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptnotes/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.ReceiptNotes[] GetReceiptNotes(GetReceiptNotesRequest request) {
      return Task.Run(async () => await GetReceiptNotesAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptnotes/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.ReceiptNotes[]> GetReceiptNotesAsync(GetReceiptNotesRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptNotesAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptNotesResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptpayment/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Payment[] GetReceiptPayment(GetReceiptPaymentRequest request) {
      return Task.Run(async () => await GetReceiptPaymentAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptpayment/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Payment[]> GetReceiptPaymentAsync(GetReceiptPaymentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptPaymentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptPaymentResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptsrecent/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetReceipts_Recent(GetReceipts_RecentRequest request) {
      return Task.Run(async () => await GetReceipts_RecentAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptsrecent/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetReceipts_RecentAsync(GetReceipts_RecentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceipts_RecentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceipts_RecentResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipts/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetReceipts(GetReceiptsRequest request) {
      return Task.Run(async () => await GetReceiptsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceipts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetReceiptsAsync(GetReceiptsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptsforsupplier/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Invoice[] GetReceiptsForSupplier(GetReceiptsForSupplierRequest request) {
      return Task.Run(async () => await GetReceiptsForSupplierAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptsforsupplier/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Invoice[]> GetReceiptsForSupplierAsync(GetReceiptsForSupplierRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptsForSupplierAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetReceiptsForSupplierResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptswithpaging/ </summary>
    public PagingResult< Invoice[]> GetReceiptsWithPaging(GetReceiptsWithPagingRequest request) {
      return Task.Run(async () => await GetReceiptsWithPagingAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getreceiptswithpaging/ </summary>
    public async Task<PagingResult<Invoice[]>> GetReceiptsWithPagingAsync(GetReceiptsWithPagingRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetReceiptsWithPagingAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return new PagingResult<Invoice[]>() {
        TotalPages = resp.TotalPages,
        TotalRecords = resp.TotalRecords,
        Result = resp.GetReceiptsWithPagingResult
      };
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getrecpaymethods/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.PaymentMethod[] GetRecPayMethods(GetRecPayMethodsRequest request) {
      return Task.Run(async () => await GetRecPayMethodsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getrecpaymethods/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.PaymentMethod[]> GetRecPayMethodsAsync(GetRecPayMethodsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetRecPayMethodsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetRecPayMethodsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getremoteloginurl/ </summary>
    public System.String GetRemoteLoginURL(GetRemoteLoginURLRequest request) {
      return Task.Run(async () => await GetRemoteLoginURLAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getremoteloginurl/ </summary>
    public async Task<System.String> GetRemoteLoginURLAsync(GetRemoteLoginURLRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetRemoteLoginURLAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetRemoteLoginURLResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproductbycode/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.SubProduct GetSubProductByCode(GetSubProductByCodeRequest request) {
      return Task.Run(async () => await GetSubProductByCodeAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproductbycode/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.SubProduct> GetSubProductByCodeAsync(GetSubProductByCodeRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSubProductByCodeAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSubProductByCodeResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproductbyid/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.SubProduct GetSubProductByID(GetSubProductByIDRequest request) {
      return Task.Run(async () => await GetSubProductByIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproductbyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.SubProduct> GetSubProductByIDAsync(GetSubProductByIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSubProductByIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSubProductByIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproducts/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.SubProduct[] GetSubProducts(GetSubProductsRequest request) {
      return Task.Run(async () => await GetSubProductsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsubproducts/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.SubProduct[]> GetSubProductsAsync(GetSubProductsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSubProductsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSubProductsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getsupplier/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Supplier GetSupplier(GetSupplierRequest request) {
      return Task.Run(async () => await GetSupplierAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsupplier/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Supplier> GetSupplierAsync(GetSupplierRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSupplierAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSupplierResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getsupplierbyid/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Supplier GetSupplierByID(GetSupplierByIDRequest request) {
      return Task.Run(async () => await GetSupplierByIDAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsupplierbyid/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Supplier> GetSupplierByIDAsync(GetSupplierByIDRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSupplierByIDAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSupplierByIDResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliercurrency/ </summary>
    public System.String GetSupplierCurrency(GetSupplierCurrencyRequest request) {
      return Task.Run(async () => await GetSupplierCurrencyAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliercurrency/ </summary>
    public async Task<System.String> GetSupplierCurrencyAsync(GetSupplierCurrencyRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSupplierCurrencyAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSupplierCurrencyResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliers/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Supplier[] GetSuppliers(GetSuppliersRequest request) {
      return Task.Run(async () => await GetSuppliersAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliers/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Supplier[]> GetSuppliersAsync(GetSuppliersRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSuppliersAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSuppliersResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliervatnumber/ </summary>
    public System.String GetSupplierVATNumber(GetSupplierVATNumberRequest request) {
      return Task.Run(async () => await GetSupplierVATNumberAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getsuppliervatnumber/ </summary>
    public async Task<System.String> GetSupplierVATNumberAsync(GetSupplierVATNumberRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetSupplierVATNumberAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetSupplierVATNumberResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/gettrialbalance/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.NominalCode[] GetTrialBalance(GetTrialBalanceRequest request) {
      return Task.Run(async () => await GetTrialBalanceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/gettrialbalance/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.NominalCode[]> GetTrialBalanceAsync(GetTrialBalanceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetTrialBalanceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetTrialBalanceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/gettrialbalancewithopeningbalances/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.NominalCodeBalance[] GetTrialBalanceWithOpeningBalances(GetTrialBalanceWithOpeningBalancesRequest request) {
      return Task.Run(async () => await GetTrialBalanceWithOpeningBalancesAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/gettrialbalancewithopeningbalances/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.NominalCodeBalance[]> GetTrialBalanceWithOpeningBalancesAsync(GetTrialBalanceWithOpeningBalancesRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetTrialBalanceWithOpeningBalancesAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetTrialBalanceWithOpeningBalancesResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getuseraccountdefaultstypedefined/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.UserAccountDefaults_TypeDefined GetUserAccountDefaults_TypeDefined(GetUserAccountDefaults_TypeDefinedRequest request) {
      return Task.Run(async () => await GetUserAccountDefaults_TypeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getuseraccountdefaultstypedefined/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.UserAccountDefaults_TypeDefined> GetUserAccountDefaults_TypeDefinedAsync(GetUserAccountDefaults_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetUserAccountDefaults_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetUserAccountDefaults_TypeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getuseraccountdefaults/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.UserAccountDefaults GetUserAccountDefaults(GetUserAccountDefaultsRequest request) {
      return Task.Run(async () => await GetUserAccountDefaultsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getuseraccountdefaults/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.UserAccountDefaults> GetUserAccountDefaultsAsync(GetUserAccountDefaultsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetUserAccountDefaultsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetUserAccountDefaultsResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getvatrates/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.BasicDataset[] GetVATRates(GetVATRatesRequest request) {
      return Task.Run(async () => await GetVATRatesAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getvatrates/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.BasicDataset[]> GetVATRatesAsync(GetVATRatesRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetVATRatesAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetVATRatesResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/getvatreport/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.VATReport GetVATReport(GetVATReportRequest request) {
      return Task.Run(async () => await GetVATReportAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/getvatreport/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.VATReport> GetVATReportAsync(GetVATReportRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.GetVATReportAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.GetVATReportResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertbanktransaction/ </summary>
    public System.Int32 InsertBankTransaction(InsertBankTransactionRequest request) {
      return Task.Run(async () => await InsertBankTransactionAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertbanktransaction/ </summary>
    public async Task<System.Int32> InsertBankTransactionAsync(InsertBankTransactionRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertBankTransactionAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertBankTransactionResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertcustomer/ </summary>
    public System.Int32 InsertCustomer(InsertCustomerRequest request) {
      return Task.Run(async () => await InsertCustomerAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertcustomer/ </summary>
    public async Task<System.Int32> InsertCustomerAsync(InsertCustomerRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertCustomerAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertCustomerResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicetypedefined/ </summary>
    public System.Int32 InsertInvoice_TypeDefined(InsertInvoice_TypeDefinedRequest request) {
      return Task.Run(async () => await InsertInvoice_TypeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicetypedefined/ </summary>
    public async Task<System.Int32> InsertInvoice_TypeDefinedAsync(InsertInvoice_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoice_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoice_TypeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoice/ </summary>
    public System.Int32 InsertInvoice(InsertInvoiceRequest request) {
      return Task.Run(async () => await InsertInvoiceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoice/ </summary>
    public async Task<System.Int32> InsertInvoiceAsync(InsertInvoiceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoiceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoiceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoiceline/ </summary>
    public System.Int32 InsertInvoiceLine(InsertInvoiceLineRequest request) {
      return Task.Run(async () => await InsertInvoiceLineAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoiceline/ </summary>
    public async Task<System.Int32> InsertInvoiceLineAsync(InsertInvoiceLineRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoiceLineAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoiceLineResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicelinewithinvoicenumber/ </summary>
    public System.Int32 InsertInvoiceLineWithInvoiceNumber(InsertInvoiceLineWithInvoiceNumberRequest request) {
      return Task.Run(async () => await InsertInvoiceLineWithInvoiceNumberAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicelinewithinvoicenumber/ </summary>
    public async Task<System.Int32> InsertInvoiceLineWithInvoiceNumberAsync(InsertInvoiceLineWithInvoiceNumberRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoiceLineWithInvoiceNumberAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoiceLineWithInvoiceNumberResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicenote/ </summary>
    public System.Boolean InsertInvoiceNote(InsertInvoiceNoteRequest request) {
      return Task.Run(async () => await InsertInvoiceNoteAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicenote/ </summary>
    public async Task<System.Boolean> InsertInvoiceNoteAsync(InsertInvoiceNoteRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoiceNoteAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoiceNoteResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicepayment/ </summary>
    public System.Int32 InsertInvoicePayment(InsertInvoicePaymentRequest request) {
      return Task.Run(async () => await InsertInvoicePaymentAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertinvoicepayment/ </summary>
    public async Task<System.Int32> InsertInvoicePaymentAsync(InsertInvoicePaymentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertInvoicePaymentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertInvoicePaymentResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertjournal/ </summary>
    public System.Int32 InsertJournal(InsertJournalRequest request) {
      return Task.Run(async () => await InsertJournalAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertjournal/ </summary>
    public async Task<System.Int32> InsertJournalAsync(InsertJournalRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertJournalAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertJournalResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertnominalcode/ </summary>
    public System.Int32 InsertNominalCode(InsertNominalCodeRequest request) {
      return Task.Run(async () => await InsertNominalCodeAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertnominalcode/ </summary>
    public async Task<System.Int32> InsertNominalCodeAsync(InsertNominalCodeRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertNominalCodeAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertNominalCodeResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertorupdateproject/ </summary>
    public System.Int32 InsertOrUpdateProject(InsertOrUpdateProjectRequest request) {
      return Task.Run(async () => await InsertOrUpdateProjectAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertorupdateproject/ </summary>
    public async Task<System.Int32> InsertOrUpdateProjectAsync(InsertOrUpdateProjectRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertOrUpdateProjectAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertOrUpdateProjectResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertquote/ </summary>
    public System.Int32 InsertQuote(InsertQuoteRequest request) {
      return Task.Run(async () => await InsertQuoteAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertquote/ </summary>
    public async Task<System.Int32> InsertQuoteAsync(InsertQuoteRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertQuoteAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertQuoteResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertquoteline/ </summary>
    public System.Int32 InsertQuoteLine(InsertQuoteLineRequest request) {
      return Task.Run(async () => await InsertQuoteLineAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertquoteline/ </summary>
    public async Task<System.Int32> InsertQuoteLineAsync(InsertQuoteLineRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertQuoteLineAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertQuoteLineResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceipttypedefined/ </summary>
    public System.Int32 InsertReceipt_TypeDefined(InsertReceipt_TypeDefinedRequest request) {
      return Task.Run(async () => await InsertReceipt_TypeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceipttypedefined/ </summary>
    public async Task<System.Int32> InsertReceipt_TypeDefinedAsync(InsertReceipt_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceipt_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceipt_TypeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceipt/ </summary>
    public System.Int32 InsertReceipt(InsertReceiptRequest request) {
      return Task.Run(async () => await InsertReceiptAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceipt/ </summary>
    public async Task<System.Int32> InsertReceiptAsync(InsertReceiptRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptline/ </summary>
    public System.Int32 InsertReceiptLine(InsertReceiptLineRequest request) {
      return Task.Run(async () => await InsertReceiptLineAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptline/ </summary>
    public async Task<System.Int32> InsertReceiptLineAsync(InsertReceiptLineRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptLineAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptLineResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptlinefromnumber/ </summary>
    public System.Int32 InsertReceiptLineFromNumber(InsertReceiptLineFromNumberRequest request) {
      return Task.Run(async () => await InsertReceiptLineFromNumberAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptlinefromnumber/ </summary>
    public async Task<System.Int32> InsertReceiptLineFromNumberAsync(InsertReceiptLineFromNumberRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptLineFromNumberAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptLineFromNumberResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptnote/ </summary>
    public System.Boolean InsertReceiptNote(InsertReceiptNoteRequest request) {
      return Task.Run(async () => await InsertReceiptNoteAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptnote/ </summary>
    public async Task<System.Boolean> InsertReceiptNoteAsync(InsertReceiptNoteRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptNoteAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptNoteResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptpayment/ </summary>
    public System.Int32 InsertReceiptPayment(InsertReceiptPaymentRequest request) {
      return Task.Run(async () => await InsertReceiptPaymentAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertreceiptpayment/ </summary>
    public async Task<System.Int32> InsertReceiptPaymentAsync(InsertReceiptPaymentRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertReceiptPaymentAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertReceiptPaymentResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/insertsupplier/ </summary>
    public System.Int32 InsertSupplier(InsertSupplierRequest request) {
      return Task.Run(async () => await InsertSupplierAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/insertsupplier/ </summary>
    public async Task<System.Int32> InsertSupplierAsync(InsertSupplierRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.InsertSupplierAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.InsertSupplierResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/isonesaasenabled/ </summary>
    public System.Boolean IsOneSaaSEnabled(IsOneSaaSEnabledRequest request) {
      return Task.Run(async () => await IsOneSaaSEnabledAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/isonesaasenabled/ </summary>
    public async Task<System.Boolean> IsOneSaaSEnabledAsync(IsOneSaaSEnabledRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.IsOneSaaSEnabledAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.IsOneSaaSEnabledResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/isstillquote/ </summary>
    public System.Boolean isStillQuote(isStillQuoteRequest request) {
      return Task.Run(async () => await isStillQuoteAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/isstillquote/ </summary>
    public async Task<System.Boolean> isStillQuoteAsync(isStillQuoteRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.isStillQuoteAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.isStillQuoteResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/isuservatregistered/ </summary>
    public System.Boolean isUserVATRegistered(isUserVATRegisteredRequest request) {
      return Task.Run(async () => await isUserVATRegisteredAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/isuservatregistered/ </summary>
    public async Task<System.Boolean> isUserVATRegisteredAsync(isUserVATRegisteredRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.isUserVATRegisteredAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.isUserVATRegisteredResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/printinvoice/ </summary>
    public System.String PrintInvoice(PrintInvoiceRequest request) {
      return Task.Run(async () => await PrintInvoiceAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/printinvoice/ </summary>
    public async Task<System.String> PrintInvoiceAsync(PrintInvoiceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.PrintInvoiceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.PrintInvoiceResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/printpurchaseorder/ </summary>
    public System.String PrintPurchaseOrder(PrintPurchaseOrderRequest request) {
      return Task.Run(async () => await PrintPurchaseOrderAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/printpurchaseorder/ </summary>
    public async Task<System.String> PrintPurchaseOrderAsync(PrintPurchaseOrderRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.PrintPurchaseOrderAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.PrintPurchaseOrderResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/sagefile/ </summary>
    public System.String SageFile(Byte[] request, string reference) {
      return Task.Run(async () => await SageFileAsync(request, reference)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/sagefile/ </summary>
    public async Task<System.String> SageFileAsync(Byte[] request, string reference) {
      var resp = await Client.SageFileAsync(request, reference);

      return resp.SageFileResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/sagefileimport/ </summary>
    public void SageFileImport(Int32 request) {
      Task.Run(async () => await SageFileImportAsync(request)).Wait();
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/sagefileimport/ </summary>
    public async Task SageFileImportAsync(Int32 request) {
      var resp = await Client.SageFileImportAsync(request);

    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/searchcustomerbycusttext/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Customer SearchCustomerByCustText(SearchCustomerByCustTextRequest request) {
      return Task.Run(async () => await SearchCustomerByCustTextAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/searchcustomerbycusttext/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer> SearchCustomerByCustTextAsync(SearchCustomerByCustTextRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SearchCustomerByCustTextAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SearchCustomerByCustTextResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/setcustomercurrency/ </summary>
    public System.Int32 SetCustomerCurrency(SetCustomerCurrencyRequest request) {
      return Task.Run(async () => await SetCustomerCurrencyAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/setcustomercurrency/ </summary>
    public async Task<System.Int32> SetCustomerCurrencyAsync(SetCustomerCurrencyRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SetCustomerCurrencyAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SetCustomerCurrencyResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/setcustomervatnumber/ </summary>
    public System.Int32 SetCustomerVATNumber(SetCustomerVATNumberRequest request) {
      return Task.Run(async () => await SetCustomerVATNumberAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/setcustomervatnumber/ </summary>
    public async Task<System.Int32> SetCustomerVATNumberAsync(SetCustomerVATNumberRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SetCustomerVATNumberAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SetCustomerVATNumberResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/setsuppliercurrency/ </summary>
    public System.Int32 SetSupplierCurrency(SetSupplierCurrencyRequest request) {
      return Task.Run(async () => await SetSupplierCurrencyAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/setsuppliercurrency/ </summary>
    public async Task<System.Int32> SetSupplierCurrencyAsync(SetSupplierCurrencyRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SetSupplierCurrencyAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SetSupplierCurrencyResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/setsuppliervatnumber/ </summary>
    public System.Int32 SetSupplierVATNumber(SetSupplierVATNumberRequest request) {
      return Task.Run(async () => await SetSupplierVATNumberAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/setsuppliervatnumber/ </summary>
    public async Task<System.Int32> SetSupplierVATNumberAsync(SetSupplierVATNumberRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.SetSupplierVATNumberAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.SetSupplierVATNumberResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatebanktransaction/ </summary>
    public System.Int32 UpdateBankTransaction(UpdateBankTransactionRequest request) {
      return Task.Run(async () => await UpdateBankTransactionAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatebanktransaction/ </summary>
    public async Task<System.Int32> UpdateBankTransactionAsync(UpdateBankTransactionRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateBankTransactionAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateBankTransactionResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatecustomer/ </summary>
    public System.String UpdateCustomer(UpdateCustomerRequest request) {
      return Task.Run(async () => await UpdateCustomerAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatecustomer/ </summary>
    public async Task<System.String> UpdateCustomerAsync(UpdateCustomerRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateCustomerAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateCustomerResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoicetypedefined/ </summary>
    public void UpdateInvoice_TypeDefined(UpdateInvoice_TypeDefinedRequest request) {
      Task.Run(async () => await UpdateInvoice_TypeDefinedAsync(request)).Wait();
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoicetypedefined/ </summary>
    public async Task UpdateInvoice_TypeDefinedAsync(UpdateInvoice_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateInvoice_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoice/ </summary>
    public void UpdateInvoice(UpdateInvoiceRequest request) {
      Task.Run(async () => await UpdateInvoiceAsync(request)).Wait();
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoice/ </summary>
    public async Task UpdateInvoiceAsync(UpdateInvoiceRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateInvoiceAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoiceheader/ </summary>
    public void UpdateInvoiceHeader(UpdateInvoiceHeaderRequest request) {
      Task.Run(async () => await UpdateInvoiceHeaderAsync(request)).Wait();
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updateinvoiceheader/ </summary>
    public async Task UpdateInvoiceHeaderAsync(UpdateInvoiceHeaderRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateInvoiceHeaderAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatejournal/ </summary>
    public System.Int32 UpdateJournal(UpdateJournalRequest request) {
      return Task.Run(async () => await UpdateJournalAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatejournal/ </summary>
    public async Task<System.Int32> UpdateJournalAsync(UpdateJournalRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateJournalAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateJournalResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatejournalheader/ </summary>
    public System.Int32 UpdateJournalHeader(UpdateJournalHeaderRequest request) {
      return Task.Run(async () => await UpdateJournalHeaderAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatejournalheader/ </summary>
    public async Task<System.Int32> UpdateJournalHeaderAsync(UpdateJournalHeaderRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateJournalHeaderAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateJournalHeaderResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatequote/ </summary>
    public System.Int32 UpdateQuote(UpdateQuoteRequest request) {
      return Task.Run(async () => await UpdateQuoteAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatequote/ </summary>
    public async Task<System.Int32> UpdateQuoteAsync(UpdateQuoteRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateQuoteAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateQuoteResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatequoteheader/ </summary>
    public System.Int32 UpdateQuoteHeader(UpdateQuoteHeaderRequest request) {
      return Task.Run(async () => await UpdateQuoteHeaderAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatequoteheader/ </summary>
    public async Task<System.Int32> UpdateQuoteHeaderAsync(UpdateQuoteHeaderRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateQuoteHeaderAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateQuoteHeaderResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceipttypedefined/ </summary>
    public System.Int32 UpdateReceipt_TypeDefined(UpdateReceipt_TypeDefinedRequest request) {
      return Task.Run(async () => await UpdateReceipt_TypeDefinedAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceipttypedefined/ </summary>
    public async Task<System.Int32> UpdateReceipt_TypeDefinedAsync(UpdateReceipt_TypeDefinedRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateReceipt_TypeDefinedAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateReceipt_TypeDefinedResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceipt/ </summary>
    public System.Int32 UpdateReceipt(UpdateReceiptRequest request) {
      return Task.Run(async () => await UpdateReceiptAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceipt/ </summary>
    public async Task<System.Int32> UpdateReceiptAsync(UpdateReceiptRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateReceiptAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateReceiptResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceiptheader/ </summary>
    public System.Int32 UpdateReceiptHeader(UpdateReceiptHeaderRequest request) {
      return Task.Run(async () => await UpdateReceiptHeaderAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatereceiptheader/ </summary>
    public async Task<System.Int32> UpdateReceiptHeaderAsync(UpdateReceiptHeaderRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateReceiptHeaderAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.UpdateReceiptHeaderResult;
    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/updatesupplier/ </summary>
    public void UpdateSupplier(UpdateSupplierRequest request) {
      Task.Run(async () => await UpdateSupplierAsync(request)).Wait();
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/updatesupplier/ </summary>
    public async Task UpdateSupplierAsync(UpdateSupplierRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.UpdateSupplierAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

    }

#if NET45
    ///<summary>See https://www.kashflow.com/developers/soap-api/vcftocustomerobjects/ </summary>
    public TipsTrade.KashFlow.KashFlowAPI.Customer[] VCFToCustomerObjects(VCFToCustomerObjectsRequest request) {
      return Task.Run(async () => await VCFToCustomerObjectsAsync(request)).Result;
    }
#endif

    ///<summary>See https://www.kashflow.com/developers/soap-api/vcftocustomerobjects/ </summary>
    public async Task<TipsTrade.KashFlow.KashFlowAPI.Customer[]> VCFToCustomerObjectsAsync(VCFToCustomerObjectsRequest request) {
      if (string.IsNullOrEmpty(request.UserName)) request.UserName = Username;
      if (string.IsNullOrEmpty(request.Password)) request.Password = Password;

      var resp = await Client.VCFToCustomerObjectsAsync(request);

      if (!string.IsNullOrEmpty(resp.StatusDetail))
        throw new KashFlowException(resp.StatusDetail) { Status = resp.Status };

      return resp.VCFToCustomerObjectsResult;
    }

#pragma warning disable IDE0018, IDE1006
    #endregion
  }
}
