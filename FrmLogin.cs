using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Enums;
using Bayad_Center_Project.Services;
using System.Data.SQLite;
using System.Diagnostics;

namespace Bayad_Center_Project
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string dbName = "bayadcenter.db";
            if (!File.Exists(dbName)) 
                SQLiteConnection.CreateFile(dbName);

            using (var databaseContext = new DatabaseContext())
            {
                databaseContext.Database.EnsureCreated();
            }

            try
            {
                AccountContext _ = new AccountContext();
                var accountService = new AccountService(_);

                User user = new User()
                {
                    Username = "admin",
                    Password = "123",
                    AccountType = AccountType.Admin,
                    FirstName = "adminFirstName",
                    LastName = "adminLastName",
                    Birthdate = DateTime.Now,
                    Address = "adminAddress"
                };

                accountService.RegisterAccount(user);
            }
            catch
            {}

            tbUsername.Text = Properties.Settings.Default.Username;
            tbPassword.Text = Properties.Settings.Default.Password;
            cbRememberLogin.Checked = Properties.Settings.Default.Remember;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                AccountContext _ = new AccountContext();
                var accountService = new AccountService(_);
                accountService.ValidateLogin(tbUsername.Text, tbPassword.Text, AccountType.Admin);

                FrmView frmAdminView = new FrmView();
                frmAdminView.Show();
                this.Hide();

                Settings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error"); 
            }
        }

        private void btnTeller_Click(object sender, EventArgs e)
        {
            try
            {
                AccountContext _ = new AccountContext();
                var accountService = new AccountService(_);
                accountService.ValidateLogin(tbUsername.Text, tbPassword.Text, AccountType.Teller);

                FrmView frmAdminView = new FrmView();
                frmAdminView.Show();
                this.Hide();

                Settings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed trying to login: " + ex.Message, "Error");
            }
        }

        private void Settings()
        {
            if (cbRememberLogin.Checked)
            {
                Properties.Settings.Default.Username = tbUsername.Text;
                Properties.Settings.Default.Password = tbPassword.Text;
                Properties.Settings.Default.Remember = cbRememberLogin.Checked;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}