using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Enums;
using Bayad_Center_Project.Services;

namespace Bayad_Center_Project
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void UpdateTables()
        {
            try
            {
                var accountContext = new AccountContext();
                var accountService = new AccountService(accountContext);
                accountService.PopulateUserTable(dgvAccount);

                var serviceContext = new ServiceContext();
                var serviceService = new ServiceService(serviceContext);
                serviceService.PopulateTable(dgvService);
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

        private int SelectedServiceId()
        {
            if (dgvService.SelectedRows.Count < 0)
                throw new Exception("Please select a service to edit.");

            DataGridViewRow selectedRow = dgvService.SelectedRows[0];
            return Convert.ToInt32(selectedRow.Cells[0].Value);
        }

        private void FrmAdminView_Load(object sender, EventArgs e) => UpdateTables();

        private void btnAccountReload_Click(object sender, EventArgs e) => UpdateTables();

        private void btnAccountCreate_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount(FormRequest.Create, -1);
            frmAccount.Show();

            UpdateTables();
        }

        private void btnAccountEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccount frmAccount = new FrmAccount(FormRequest.Edit, SelectedUserId());
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            UpdateTables();
        }

        private void btnAccountView_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccount frmAccount = new FrmAccount(FormRequest.View, SelectedUserId());
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            UpdateTables();
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
            FrmService frmService = new FrmService(FormRequest.Create, 0);
            frmService.Show();
        }

        private void btnServiceView_Click(object sender, EventArgs e)
        {
            try
            {
                FrmService frmService = new FrmService(FormRequest.View, SelectedServiceId());
                frmService.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            UpdateTables();
        }

        private void btnServiceEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceReload_Click(object sender, EventArgs e) => UpdateTables();
    }
}
