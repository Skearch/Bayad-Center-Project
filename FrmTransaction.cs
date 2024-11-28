using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Enums;
using Bayad_Center_Project.Services;
using System.Data.SqlClient;

namespace Bayad_Center_Project
{
    public partial class FrmTransaction : Form
    {
        FormRequest transactionFormRequest;
        public Transaction transaction;
        public Account account;
        public Service service;

        public FrmTransaction(FormRequest transactionFormRequest, Account account, Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.transactionFormRequest = transactionFormRequest;
            this.account = account;
        }

        private void FrmTransaction_Load(object sender, EventArgs e)
        {
            switch (transactionFormRequest)
            {
                case FormRequest.View:
                    tbAccountNumber.Text = transaction.AccountNumber;
                    tbFullName.Text = transaction.AccountNumber;
                    tbEmail.Text = transaction.AccountNumber;
                    tbAmountToPay.Text = transaction.AccountNumber;
                    rtbMessage.Text = transaction.Message;

                    var databaseContext = new DatabaseContext();
                    var accountService = new AccountService(databaseContext);
                    tbIssuer.Text = accountService.GetAccountById((int)transaction.AccountId).Username;

                    var serviceService = new ServiceService(databaseContext);
                    tbServiceName.Text = serviceService.GetServiceById((int)transaction.ServiceId).Name;

                    var receiptService = new ReceiptService(databaseContext);
                    var receipt = receiptService.GetReceiptByTransactionId((int)transaction.TransactionID);
                    tbAmountToPay.Text = receipt.AmountToPay.ToString();
                    tbPaymentAmount.Text = receipt.PaymentAmount.ToString();
                    tbChange.Text = receipt.Change.ToString();

                    btnAction.Text = "Close";
                    btnSetService.Visible = false;
                    lblRequiredFields.Visible = false;

                    foreach (Control control in Controls)
                    {
                        if (control is TextBox textBox)
                            textBox.ReadOnly = true;

                        if (control is RichTextBox richTextBox)
                            richTextBox.ReadOnly = true;

                        if (control is Label)
                            control.Text = control.Text.Replace(" *", "");
                    }

                    break;
                case FormRequest.Create:
                    btnServiceView.Visible = false;
                    btnAccountView.Visible = false;
                    btnReceiptView.Visible = false;

                    btnAction.Text = "Create";
                    tbIssuer.Text = account.Username;
                    break;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                switch (transactionFormRequest)
                {
                    case FormRequest.Create:

                        if (account == null || service == null)
                            new Exception("Service or Teller cannot be null.");

                        var transactionCreate = new Transaction()
                        {
                            AccountId = account.AccountID,
                            ServiceId = service.ServiceID,
                            AccountNumber = string.IsNullOrEmpty(tbAccountNumber.Text) ? null : tbAccountNumber.Text,
                            FullName = string.IsNullOrEmpty(tbFullName.Text) ? null : tbFullName.Text,
                            Email = string.IsNullOrEmpty(tbEmail.Text) ? null : tbEmail.Text,
                            Message = string.IsNullOrEmpty(rtbMessage.Text) ? null : rtbMessage.Text,
                        };

                        var transactionService = new TransactionService(new DatabaseContext());
                        transactionService.AddTransaction(transactionCreate);

                        var receiptCreate = new Receipt()
                        {
                            TransactionId = transactionCreate.TransactionID,
                            AccountID = account.AccountID,
                            DateIssued = DateTime.Now,
                            AmountToPay = string.IsNullOrEmpty(tbAmountToPay.Text) ? 0 : decimal.Parse(tbAmountToPay.Text),
                            PaymentAmount = string.IsNullOrEmpty(tbPaymentAmount.Text) ? 0 : decimal.Parse(tbPaymentAmount.Text),
                            Change = string.IsNullOrEmpty(tbChange.Text) ? 0 : decimal.Parse(tbChange.Text),
                        };

                        var receiptService = new ReceiptService(new DatabaseContext());
                        receiptService.CreateReceipt(receiptCreate);

                        break;
                }

                this.Hide();
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAccountView_Click(object sender, EventArgs e)
        {
            try
            {
                AccountService accountService = new AccountService(new DatabaseContext());
                Account account = accountService.GetAccountById((int)transaction.AccountId);
                FrmAccount frmAccount = new FrmAccount(FormRequest.View, account);
                frmAccount.Show();
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnServiceView_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceService serviceService = new ServiceService(new DatabaseContext());
                Service service = serviceService.GetServiceById((int)transaction.ServiceId);
                FrmService frmService = new FrmService(FormRequest.View, service);
                frmService.Show();
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnSetService_Click(object sender, EventArgs e)
        {
            string title = "Please select a service";
            var serviceContext = new DatabaseContext();
            var serviceService = new ServiceService(serviceContext);
            var services = serviceService.GetAllServices();
            var test = services.Select(s => new
            {
                s.ServiceID,
                s.Name,
            }).ToList();

            List<object> objectList = test.Cast<object>().ToList();
            FrmSelection frmSelection = new FrmSelection(title, objectList);

            frmSelection.Show();

            frmSelection.FormClosed += (s, args) =>
            {
                if (frmSelection.selectedID == null)
                {
                    service = null;
                    tbServiceName.Text = "";
                    return;
                }

                int selectedID = frmSelection.selectedID.Value;
                service = serviceService.GetServiceById(selectedID);
                tbServiceName.Text = service.Name;
            };
        }

        private void tbAmountToPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amountToPay = decimal.Parse(tbAmountToPay.Text);
                decimal paymentAmount = decimal.Parse(tbPaymentAmount.Text);

                tbChange.Text = (paymentAmount - amountToPay).ToString();
            }
            catch { }
        }

        private void btnReceiptView_Click(object sender, EventArgs e)
        {
            try
            {
                var receiptService = new ReceiptService(new DatabaseContext());
                var receipt = receiptService.GetReceiptByTransactionId((int)transaction.TransactionID);
                var frmReceipt = new FrmReceipt(receipt);
                frmReceipt.Show();
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}