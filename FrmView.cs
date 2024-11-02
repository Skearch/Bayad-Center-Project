using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Enums;
using Bayad_Center_Project.Properties;
using Bayad_Center_Project.Services;

namespace Bayad_Center_Project
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn.Apply(0, 0, Width, Height, 15, 15));
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

        private void FrmAdminView_Load(object sender, EventArgs e) 
        {
            new DraggableForm(pbIcon, this);
            new DraggableForm(pnlTop, this);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

            UpdateTables();
        }

        private void btnServiceCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmService frmService = new FrmService(FormRequest.Create, -1);
                frmService.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            UpdateTables();
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
            try
            {
                FrmService frmService = new FrmService(FormRequest.Edit, SelectedServiceId());
                frmService.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            UpdateTables();
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
                    ServiceContext.DeleteServiceById(SelectedServiceId());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

            UpdateTables();
        }

        private void tcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTables();
        }

        private void btnExit_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void btnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

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

        private void btnAccountReload_Click(object sender, EventArgs e) => UpdateTables();

        private void btnAccountCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccount frmAccount = new FrmAccount(FormRequest.Create, -1);
                frmAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            UpdateTables();
        }

        private void btnAccounts_MouseEnter(object sender, EventArgs e) => btnAccounts.Image = Resources.accounts_2;

        private void btnServices_MouseEnter(object sender, EventArgs e) => btnServices.Image = Resources.services_2;

        private void btnAccounts_MouseLeave(object sender, EventArgs e) => btnAccounts.Image = Resources.accounts;

        private void btnServices_MouseLeave(object sender, EventArgs e) => btnServices.Image = Resources.services;
    }
}
