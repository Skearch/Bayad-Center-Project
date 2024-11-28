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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            cbRememberLogin = new CheckBox();
            pbIcon = new PictureBox();
            pictureBox6 = new PictureBox();
            btnAdmin = new PictureBox();
            btnExit = new PictureBox();
            btnMinimize = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(142, 162);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(228, 32);
            tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.White;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 18F);
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(142, 239);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(228, 32);
            tbPassword.TabIndex = 1;
            // 
            // cbRememberLogin
            // 
            cbRememberLogin.AutoSize = true;
            cbRememberLogin.BackColor = Color.FromArgb(230, 239, 245);
            cbRememberLogin.ForeColor = Color.White;
            cbRememberLogin.Location = new Point(196, 286);
            cbRememberLogin.Name = "cbRememberLogin";
            cbRememberLogin.Size = new Size(15, 14);
            cbRememberLogin.TabIndex = 7;
            cbRememberLogin.UseVisualStyleBackColor = false;
            // 
            // pbIcon
            // 
            pbIcon.Image = (Image)resources.GetObject("pbIcon.Image");
            pbIcon.Location = new Point(10, 10);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(171, 32);
            pbIcon.TabIndex = 8;
            pbIcon.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(217, 289);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(62, 11);
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // btnAdmin
            // 
            btnAdmin.Image = Properties.Resources.Login;
            btnAdmin.Location = new Point(128, 318);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(256, 40);
            btnAdmin.TabIndex = 14;
            btnAdmin.TabStop = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(477, 17);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(18, 18);
            btnExit.TabIndex = 15;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(453, 17);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(18, 18);
            btnMinimize.TabIndex = 16;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(128, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(256, 63);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(128, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 63);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 245);
            ClientSize = new Size(512, 468);
            Controls.Add(btnMinimize);
            Controls.Add(btnExit);
            Controls.Add(tbPassword);
            Controls.Add(btnAdmin);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(pbIcon);
            Controls.Add(cbRememberLogin);
            Controls.Add(tbUsername);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private TextBox tbPassword;
        private CheckBox cbRememberLogin;
        private PictureBox pbIcon;
        private PictureBox pictureBox6;
        private PictureBox btnAdmin;
        private PictureBox btnExit;
        private PictureBox btnMinimize;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}