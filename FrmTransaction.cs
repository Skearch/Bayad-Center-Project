using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Enums;
using Bayad_Center_Project.Services;

namespace Bayad_Center_Project
{
    public partial class FrmTransaction : Form
    {
        FormRequest transactionFormRequest;
        public Transaction transaction;
        public Account user;
        public Service service;

        public FrmTransaction(FormRequest transactionFormRequest, Account user, Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.transactionFormRequest = transactionFormRequest;
            this.user = user;
        }

        private void FrmTransaction_Load(object sender, EventArgs e)
        {
            switch (transactionFormRequest)
            {
                case FormRequest.View:
                    tbAccountNumber.Text = transaction.AccountNumber;
                    tbFullName.Text = transaction.AccountNumber;
                    tbEmail.Text = transaction.AccountNumber;
                    tbAmount.Text = transaction.AccountNumber;
                    rtbMessage.Text = transaction.Message;

                    AccountContext userContext = new AccountContext();
                    AccountService accountService = new AccountService(userContext);
                    tbUser.Text = accountService.GetAccountById((int)transaction.AccountId).Username;

                    ServiceContext serviceContext = new ServiceContext();
                    ServiceService serviceService = new ServiceService(serviceContext);
                    tbServiceName.Text = serviceService.GetServiceById((int)transaction.ServiceId).Name;

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

                    btnAction.Text = "Create";
                    tbUser.Text = user.Username;
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

                        if (user == null || service == null)
                            new Exception("Service or Teller cannot be null.");

                        Transaction transactionCreate = new Transaction()
                        {
                            AccountId = user.Id,
                            ServiceId = service.Id,
                            Amount = string.IsNullOrEmpty(tbAmount.Text) ? 0 : decimal.Parse(tbAmount.Text),
                            AccountNumber = string.IsNullOrEmpty(tbAccountNumber.Text) ? null : tbAccountNumber.Text,
                            FullName = string.IsNullOrEmpty(tbFullName.Text) ? null : tbFullName.Text,
                            Email = string.IsNullOrEmpty(tbEmail.Text) ? null : tbEmail.Text,
                            Message = string.IsNullOrEmpty(rtbMessage.Text) ? null : rtbMessage.Text,
                        };

                        TransactionContext _ = new TransactionContext();
                        var transactionService = new TransactionService(_);
                        transactionService.AddTransaction(transactionCreate);
                        break;
                }

                this.Hide();
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
                AccountService accountService = new AccountService(new AccountContext());
                Account account = accountService.GetAccountById((int)transaction.AccountId);
                FrmAccount frmAccount = new FrmAccount(FormRequest.View, account);
                frmAccount.Show();
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
                ServiceService serviceService = new ServiceService(new ServiceContext());
                Service service = serviceService.GetServiceById((int)transaction.ServiceId);
                FrmService frmService = new FrmService(FormRequest.View, service);
                frmService.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnSetService_Click(object sender, EventArgs e)
        {
            string title = "Please select a service";
            var serviceContext = new ServiceContext();
            var serviceService = new ServiceService(serviceContext);
            var services = serviceService.GetAllServices();
            var test = services.Select(s => new
            {
                s.Id,
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
    }
}