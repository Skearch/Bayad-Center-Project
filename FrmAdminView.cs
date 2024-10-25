using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Services;
using System.Data;
using System.Windows.Forms;

namespace Bayad_Center_Project
{
    public partial class FrmAdminView : Form
    {
        public FrmAdminView()
        {
            InitializeComponent();
        }

        private void UpdateDGVAccount() 
        {
            try
            {
                var _ = new AccountContext();
                var accountService = new AccountService(_);
                accountService.PopulateUserTable(dgvAccount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private int SelectedUserId() 
        {
            if (dgvAccount.SelectedRows.Count < 0)
                throw new Exception("Please select an account to edit.");

            DataGridViewRow selectedRow = dgvAccount.SelectedRows[0];
            return Convert.ToInt32(selectedRow.Cells[0].Value);
        }

        private void FrmAdminView_Load(object sender, EventArgs e)
        {
            var _ = new AccountContext();
            var accountService = new AccountService(_);
            accountService.PopulateUserTable(dgvAccount);
        }

        private void btnAccountReload_Click(object sender, EventArgs e)
        {
            UpdateDGVAccount();
        }

        private void btnAccountCreate_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount(AccountFormRequest.Create, -1);
            frmAccount.Show();

            UpdateDGVAccount();
        }

        private void btnAccountEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccount frmAccount = new FrmAccount(AccountFormRequest.Edit, SelectedUserId());
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            UpdateDGVAccount();
        }

        private void btnAccountView_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccount frmAccount = new FrmAccount(AccountFormRequest.View, SelectedUserId());
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            UpdateDGVAccount();
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    var accountService = new AccountService(new AccountContext());
                    accountService.DeleteAccountById(SelectedUserId());
                    UpdateDGVAccount();
                    MessageBox.Show("Account deleted successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
