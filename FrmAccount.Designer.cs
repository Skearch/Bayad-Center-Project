namespace Bayad_Center_Project
{
    partial class FrmAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            tbLastName = new TextBox();
            label5 = new Label();
            tbMiddleName = new TextBox();
            label4 = new Label();
            tbFirstName = new TextBox();
            dtpBirthdate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            tbPassword = new TextBox();
            label1 = new Label();
            tbUsername = new TextBox();
            btnAction = new Button();
            label7 = new Label();
            tbEmailAddress = new TextBox();
            label8 = new Label();
            tbPhoneNumber = new TextBox();
            lblRequiredFields = new Label();
            label11 = new Label();
            rtbAddress = new RichTextBox();
            label12 = new Label();
            label13 = new Label();
            cbAccountType = new ComboBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(362, 48);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 28;
            label6.Text = "Last Name *";
            // 
            // tbLastName
            // 
            tbLastName.BackColor = Color.Silver;
            tbLastName.BorderStyle = BorderStyle.None;
            tbLastName.ForeColor = Color.Black;
            tbLastName.Location = new Point(362, 66);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(169, 16);
            tbLastName.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(187, 48);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 26;
            label5.Text = "Middle Name";
            // 
            // tbMiddleName
            // 
            tbMiddleName.BackColor = Color.Silver;
            tbMiddleName.BorderStyle = BorderStyle.None;
            tbMiddleName.ForeColor = Color.Black;
            tbMiddleName.Location = new Point(187, 66);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(169, 16);
            tbMiddleName.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 48);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 24;
            label4.Text = "First Name *";
            // 
            // tbFirstName
            // 
            tbFirstName.BackColor = Color.Silver;
            tbFirstName.BorderStyle = BorderStyle.None;
            tbFirstName.ForeColor = Color.Black;
            tbFirstName.Location = new Point(12, 66);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(169, 16);
            tbFirstName.TabIndex = 23;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.CalendarForeColor = Color.White;
            dtpBirthdate.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
            dtpBirthdate.Format = DateTimePickerFormat.Short;
            dtpBirthdate.Location = new Point(12, 110);
            dtpBirthdate.MaxDate = new DateTime(2050, 1, 1, 0, 0, 0, 0);
            dtpBirthdate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(169, 23);
            dtpBirthdate.TabIndex = 22;
            dtpBirthdate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 21;
            label3.Text = "Birthdate *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 299);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 20;
            label2.Text = "Password *";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.Silver;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(12, 317);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(169, 16);
            tbPassword.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 262);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 18;
            label1.Text = "Username *";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.Silver;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(12, 280);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(169, 16);
            tbUsername.TabIndex = 17;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Gray;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(372, 306);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(159, 45);
            btnAction.TabIndex = 30;
            btnAction.Text = "Action";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(187, 92);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 32;
            label7.Text = "Email Address";
            // 
            // tbEmailAddress
            // 
            tbEmailAddress.BackColor = Color.Silver;
            tbEmailAddress.BorderStyle = BorderStyle.None;
            tbEmailAddress.ForeColor = Color.Black;
            tbEmailAddress.Location = new Point(187, 110);
            tbEmailAddress.Name = "tbEmailAddress";
            tbEmailAddress.Size = new Size(169, 16);
            tbEmailAddress.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(362, 92);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 34;
            label8.Text = "Phone Number";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.BackColor = Color.Silver;
            tbPhoneNumber.BorderStyle = BorderStyle.None;
            tbPhoneNumber.ForeColor = Color.Black;
            tbPhoneNumber.Location = new Point(362, 110);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(169, 16);
            tbPhoneNumber.TabIndex = 33;
            // 
            // lblRequiredFields
            // 
            lblRequiredFields.AutoSize = true;
            lblRequiredFields.ForeColor = Color.Red;
            lblRequiredFields.Location = new Point(12, 9);
            lblRequiredFields.Name = "lblRequiredFields";
            lblRequiredFields.Size = new Size(140, 15);
            lblRequiredFields.TabIndex = 35;
            lblRequiredFields.Text = "Fields with * are required.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(12, 24);
            label11.Name = "label11";
            label11.Size = new Size(129, 15);
            label11.TabIndex = 38;
            label11.Text = "Personal Informations";
            // 
            // rtbAddress
            // 
            rtbAddress.BackColor = Color.Silver;
            rtbAddress.BorderStyle = BorderStyle.None;
            rtbAddress.ForeColor = Color.Black;
            rtbAddress.Location = new Point(12, 154);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(344, 75);
            rtbAddress.TabIndex = 39;
            rtbAddress.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(12, 136);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 40;
            label12.Text = "Address *";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(12, 247);
            label13.Name = "label13";
            label13.Size = new Size(128, 15);
            label13.TabIndex = 41;
            label13.Text = "Account Informations";
            // 
            // cbAccountType
            // 
            cbAccountType.BackColor = Color.Silver;
            cbAccountType.FlatStyle = FlatStyle.Flat;
            cbAccountType.ForeColor = Color.Black;
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Items.AddRange(new object[] { "Administrator", "Teller" });
            cbAccountType.Location = new Point(187, 280);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(169, 23);
            cbAccountType.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(187, 262);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 43;
            label10.Text = "Account Type *";
            // 
            // FrmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 245);
            ClientSize = new Size(539, 361);
            Controls.Add(label10);
            Controls.Add(cbAccountType);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(rtbAddress);
            Controls.Add(label11);
            Controls.Add(lblRequiredFields);
            Controls.Add(label8);
            Controls.Add(tbPhoneNumber);
            Controls.Add(label7);
            Controls.Add(tbEmailAddress);
            Controls.Add(btnAction);
            Controls.Add(label6);
            Controls.Add(tbLastName);
            Controls.Add(label5);
            Controls.Add(tbMiddleName);
            Controls.Add(label4);
            Controls.Add(tbFirstName);
            Controls.Add(dtpBirthdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(label1);
            Controls.Add(tbUsername);
            Name = "FrmAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAccount";
            TopMost = true;
            Load += FrmAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private TextBox tbLastName;
        private Label label5;
        private TextBox tbMiddleName;
        private Label label4;
        private TextBox tbFirstName;
        private DateTimePicker dtpBirthdate;
        private Label label3;
        private Label label2;
        private TextBox tbPassword;
        private Label label1;
        private TextBox tbUsername;
        private Button btnAction;
        private Label label7;
        private TextBox tbEmailAddress;
        private Label label8;
        private TextBox tbPhoneNumber;
        private Label lblRequiredFields;
        private Label label11;
        private RichTextBox rtbAddress;
        private Label label12;
        private Label label13;
        private ComboBox cbAccountType;
        private Label label10;
    }
}