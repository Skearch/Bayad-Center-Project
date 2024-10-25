namespace Bayad_Center_Project
{
    partial class FrmLogin
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
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAdmin = new Button();
            btnTeller = new Button();
            label3 = new Label();
            cbRememberLogin = new CheckBox();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(96, 70);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(184, 23);
            tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(96, 114);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(184, 23);
            tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 52);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 96);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(96, 186);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(89, 23);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnTeller
            // 
            btnTeller.Location = new Point(191, 186);
            btnTeller.Name = "btnTeller";
            btnTeller.Size = new Size(89, 23);
            btnTeller.TabIndex = 5;
            btnTeller.Text = "Teller";
            btnTeller.UseVisualStyleBackColor = true;
            btnTeller.Click += btnTeller_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 168);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Login as:";
            // 
            // cbRememberLogin
            // 
            cbRememberLogin.AutoSize = true;
            cbRememberLogin.Location = new Point(96, 143);
            cbRememberLogin.Name = "cbRememberLogin";
            cbRememberLogin.Size = new Size(84, 19);
            cbRememberLogin.TabIndex = 7;
            cbRememberLogin.Text = "Remember";
            cbRememberLogin.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 266);
            Controls.Add(cbRememberLogin);
            Controls.Add(label3);
            Controls.Add(btnTeller);
            Controls.Add(btnAdmin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Button btnAdmin;
        private Button btnTeller;
        private Label label3;
        private CheckBox cbRememberLogin;
    }
}