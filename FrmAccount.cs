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
        public int userID = -1;

        public FrmAccount(FormRequest AccountFormRequest, int UserID)
        {
            InitializeComponent();
            userID = UserID;
            accountFormRequest = AccountFormRequest;

            List<AccountType> accountTypes = Enum.GetValues(typeof(AccountType)).Cast<AccountType>().ToList();
            cbAccountType.DataSource = accountTypes;
            cbAccountType.SelectedItem = AccountType.Teller;
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {

            AccountContext _ = new AccountContext();
            var accountService = new AccountService(_);
            if (accountFormRequest.Equals(FormRequest.Edit) || accountFormRequest.Equals(FormRequest.View))
            {
                User user = accountService.GetUserById(userID);
                tbUsername.Text = user.Username;
                tbPassword.Text = user.Password;
                cbAccountType.SelectedItem = Enum.Parse(typeof(AccountType), user.AccountType.ToString());
                tbFirstName.Text = user.FirstName;
                tbMiddleName.Text = user.MiddleName;
                tbLastName.Text = user.LastName;
                dtpBirthdate.Value = user.Birthdate;
                tbEmailAddress.Text = user.EmailAddress;
                tbPhoneNumber.Text = user.PhoneNumber;
                rtbAddress.Text = user.Address;
            }

            switch (accountFormRequest)
            {
                case FormRequest.Edit:
                    btnAction.Text = "Save";
                    break;
                case FormRequest.View:
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
                        User userEdit = new User()
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

                        accountService.EditAccountById(userID, userEdit);
                        break;
                    case FormRequest.Create:
                        User userCreate = new User()
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
