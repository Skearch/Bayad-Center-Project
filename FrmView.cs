using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Enums;
using Bayad_Center_Project.Properties;
using Bayad_Center_Project.Services;
using Bayad_Center_Project.Utilities;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Bayad_Center_Project
{
    public partial class FrmView : Form
    {
        Account user;

        public FrmView(Account user)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn.Apply(0, 0, Width, Height, 15, 15));
            this.user = user;
        }

        private void UpdateTables()
        {
            try
            {
                var accountContext = new AccountContext();
                var accountService = new AccountService(accountContext);
                var accounts = accountService.GetAllAccounts();
                dgvAccount.DataSource = accounts.Select(s => new
                {
                    s.Id,
                    s.Username,
                    FullName = string.IsNullOrEmpty(s.MiddleName) ? $"{s.FirstName} {s.LastName}" : $"{s.FirstName} {s.MiddleName.ToCharArray().First()}. {s.LastName}",
                    BirthDate = s.Birthdate,
                    Account = s.AccountType
                }).ToList();

                var serviceContext = new ServiceContext();
                var serviceService = new ServiceService(serviceContext);
                var services = serviceService.GetAllServices();
                dgvService.DataSource = services.Select(s => new
                {
                    s.Id,
                    s.Name,
                }).ToList();

                var transactionContext = new TransactionContext();
                var transactionService = new TransactionService(transactionContext);
                var transactions = transactionService.GetAllTransactions();
                dgvTransaction.DataSource = transactions.Select(s => new
                {
                    s.Id,
                    s.AccountNumber,
                    s.Amount,
                    Service = serviceService.GetServiceById((int)s.ServiceId).Name,
                    Teller = accountService.GetAccountById((int)s.AccountId).Username,
                }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private Account SelectedAccount()
        {
            if (dgvAccount.SelectedRows.Count < 0)
                throw new Exception("Please select an Account.");

            DataGridViewRow selectedRow = dgvAccount.SelectedRows[0];
            int selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);

            AccountContext accountContext = new AccountContext();
            AccountService accountService = new AccountService(accountContext);
            Account account = accountService.GetAccountById(selectedID);

            return account;
        }

        private Service SelectedService()
        {
            if (dgvService.SelectedRows.Count < 0)
                throw new Exception("Please select a Service.");

            DataGridViewRow selectedRow = dgvService.SelectedRows[0];
            int selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);

            ServiceContext serviceContext = new ServiceContext();
            ServiceService serviceService = new ServiceService(serviceContext);
            Service service = serviceService.GetServiceById(selectedID);

            return service;
        }

        private Transaction SelectedTransaction()
        {
            if (dgvTransaction.SelectedRows.Count < 0)
                throw new Exception("Please select a Transaction.");

            DataGridViewRow selectedRow = dgvTransaction.SelectedRows[0];
            int selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);

            TransactionContext transactionContext = new TransactionContext();
            TransactionService transactionService = new TransactionService(transactionContext);
            Transaction transaction = transactionService.GetTransactionById(selectedID);

            return transaction;
        }

        private void FrmAdminView_Load(object sender, EventArgs e)
        {
            new DraggableForm(pbIcon, this);
            new DraggableForm(pnlTop, this);
            new DraggableForm(lblUser, this);

            tcMenu.ItemSize = new Size(0, 1);
            tcMenu.SizeMode = TabSizeMode.Fixed;
            new TabPadding(tcMenu);

            var accountService = new AccountService(new AccountContext());
            Account currentUser = accountService.GetAccountById(user.Id.Value);
            lblUser.Text = $"Welcome, {currentUser.FirstName}!";

            if (currentUser.AccountType.Equals(AccountType.Teller))
            {
                btnAccounts.Visible = false;
                btnServices.Visible = false;
                tcMenu.SelectTab(tpTransactions);
            }

            UpdateTables();
        }

        private void btnAccountView_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccount frmAccount = new FrmAccount(FormRequest.View, SelectedAccount());
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    var accountService = new AccountService(new AccountContext());
                    accountService.DeleteAccountById(SelectedAccount().Id.Value);
                    UpdateTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnServiceCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmService frmService = new FrmService(FormRequest.Create, null);
                frmService.Show();
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
                FrmService frmService = new FrmService(FormRequest.View, SelectedService());
                frmService.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnServiceEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmService frmService = new FrmService(FormRequest.Edit, SelectedService());
                frmService.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnServiceReload_Click(object sender, EventArgs e) => UpdateTables();

        private void btnServiceDelete_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete this service?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    var ServiceContext = new ServiceService(new ServiceContext());
                    ServiceContext.DeleteService(SelectedService().Id.Value);
                    UpdateTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void tcMenu_SelectedIndexChanged(object sender, EventArgs e) => UpdateTables();

        private void btnExit_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void btnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnAccountEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccount frmAccount = new FrmAccount(FormRequest.Edit, SelectedAccount());
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAccountReload_Click(object sender, EventArgs e) => UpdateTables();

        private void btnAccountCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccount frmAccount = new FrmAccount(FormRequest.Create, null);
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAccounts_MouseEnter(object sender, EventArgs e) => btnAccounts.Image = Resources.accounts_2;

        private void btnServices_MouseEnter(object sender, EventArgs e) => btnServices.Image = Resources.services_2;

        private void btnAccounts_MouseLeave(object sender, EventArgs e) => btnAccounts.Image = Resources.accounts;

        private void btnServices_MouseLeave(object sender, EventArgs e) => btnServices.Image = Resources.services;

        private void btnAccounts_Click(object sender, EventArgs e) => tcMenu.SelectTab(tpAccounts);

        private void btnServices_Click(object sender, EventArgs e) => tcMenu.SelectTab(tpServices);

        private void btnTransactions_MouseEnter(object sender, EventArgs e) => btnTransactions.Image = Resources.transactions_2;

        private void btnTransactions_MouseLeave(object sender, EventArgs e) => btnTransactions.Image = Resources.transactions;

        private void btnTransactions_Click(object sender, EventArgs e) => tcMenu.SelectTab(tpTransactions);

        private void btnTransactionCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTransaction frmAccount = new FrmTransaction(FormRequest.Create, user, null);
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnTransactionReload_Click(object sender, EventArgs e) => UpdateTables();

        private void btnTransactionView_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTransaction frmAccount = new FrmTransaction(FormRequest.View, null, SelectedTransaction());
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnTransactionDelete_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    var transactionService = new TransactionService(new TransactionContext());
                    transactionService.DeleteTransaction(SelectedTransaction());
                    UpdateTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
