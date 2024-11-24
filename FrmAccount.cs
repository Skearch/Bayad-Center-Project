using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Enums;
using Bayad_Center_Project.Services;
using System.Data;

namespace Bayad_Center_Project
{
    public partial class FrmAccount : Form
    {
        FormRequest accountFormRequest;
        Account account;

        public FrmAccount(FormRequest AccountFormRequest, Account account)
        {
            InitializeComponent();
            this.account = account;
            accountFormRequest = AccountFormRequest;

            List<AccountType> accountTypes = Enum.GetValues(typeof(AccountType)).Cast<AccountType>().ToList();
            cbAccountType.DataSource = accountTypes;
            cbAccountType.SelectedItem = AccountType.Teller;
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            if (accountFormRequest.Equals(FormRequest.Edit) || accountFormRequest.Equals(FormRequest.View))
            {
                tbUsername.Text = account.Username;
                tbPassword.Text = account.Password;
                cbAccountType.SelectedItem = Enum.Parse(typeof(AccountType), account.AccountType.ToString());
                tbFirstName.Text = account.FirstName;
                tbMiddleName.Text = account.MiddleName;
                tbLastName.Text = account.LastName;
                dtpBirthdate.Value = account.Birthdate;
                tbEmailAddress.Text = account.EmailAddress;
                tbPhoneNumber.Text = account.PhoneNumber;
                rtbAddress.Text = account.Address;
            }

            switch (accountFormRequest)
            {
                case FormRequest.Edit:
                    btnAction.Text = "Save";
                    break;
                case FormRequest.View:
                    tbPassword.PasswordChar = char.Parse("*");
                    btnAction.Text = "Close";
                    lblRequiredFields.Visible = false;

                    foreach (Control control in Controls)
                    {
                        if (control is TextBox textBox)
                            textBox.ReadOnly = true;

                        if (control is RichTextBox richTextBox)
                            richTextBox.ReadOnly = true;

                        if (control is DateTimePicker || control is ComboBox)
                            control.Enabled = false;

                        if (control is Label)
                            control.Text = control.Text.Replace(" *", "");
                    }
                    break;
                case FormRequest.Create:
                    btnAction.Text = "Create";
                    break;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                AccountContext _ = new AccountContext();
                var accountService = new AccountService(_);

                switch (accountFormRequest)
                {
                    case FormRequest.Edit:
                        Account userEdit = new Account()
                        {
                            Username = string.IsNullOrEmpty(tbUsername.Text) ? null : tbUsername.Text,
                            Password = string.IsNullOrEmpty(tbPassword.Text) ? null : tbPassword.Text,
                            AccountType = (AccountType)cbAccountType.SelectedValue,
                            FirstName = string.IsNullOrEmpty(tbFirstName.Text) ? null : tbFirstName.Text,
                            MiddleName = string.IsNullOrEmpty(tbMiddleName.Text) ? null : tbMiddleName.Text,
                            LastName = string.IsNullOrEmpty(tbLastName.Text) ? null : tbLastName.Text,
                            Birthdate = dtpBirthdate.Value,
                            EmailAddress = string.IsNullOrEmpty(tbEmailAddress.Text) ? null : tbEmailAddress.Text,
                            PhoneNumber = string.IsNullOrEmpty(tbPhoneNumber.Text) ? null : tbPhoneNumber.Text,
                            Address = string.IsNullOrEmpty(rtbAddress.Text) ? null : rtbAddress.Text
                        };

                        accountService.EditAccountById(account.Id.Value, userEdit);
                        break;
                    case FormRequest.Create:
                        Account userCreate = new Account()
                        {
                            Username = string.IsNullOrEmpty(tbUsername.Text) ? null : tbUsername.Text,
                            Password = string.IsNullOrEmpty(tbPassword.Text) ? null : tbPassword.Text,
                            AccountType = (AccountType)cbAccountType.SelectedValue,
                            FirstName = string.IsNullOrEmpty(tbFirstName.Text) ? null : tbFirstName.Text,
                            MiddleName = string.IsNullOrEmpty(tbMiddleName.Text) ? null : tbMiddleName.Text,
                            LastName = string.IsNullOrEmpty(tbLastName.Text) ? null : tbLastName.Text,
                            Birthdate = dtpBirthdate.Value,
                            EmailAddress = string.IsNullOrEmpty(tbEmailAddress.Text) ? null : tbEmailAddress.Text,
                            PhoneNumber = string.IsNullOrEmpty(tbPhoneNumber.Text) ? null : tbPhoneNumber.Text,
                            Address = string.IsNullOrEmpty(rtbAddress.Text) ? null : rtbAddress.Text
                        };

                        accountService.RegisterAccount(userCreate);
                        break;
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
