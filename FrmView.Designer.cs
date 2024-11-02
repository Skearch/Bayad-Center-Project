namespace Bayad_Center_Project
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            tcMenu = new TabControl();
            tbAccounts = new TabPage();
            btnAccountDelete = new PictureBox();
            btnAccountCreate = new PictureBox();
            btnAccountReload = new PictureBox();
            btnAccountView = new PictureBox();
            btnAccountEdit = new PictureBox();
            dgvAccount = new DataGridView();
            tbServices = new TabPage();
            dgvService = new DataGridView();
            btnServiceDelete = new PictureBox();
            btnServiceCreate = new PictureBox();
            btnServiceReload = new PictureBox();
            btnServiceView = new PictureBox();
            btnServiceEdit = new PictureBox();
            tbPayBills = new TabPage();
            pnlTop = new Panel();
            btnMinimize = new PictureBox();
            btnExit = new PictureBox();
            pbIcon = new PictureBox();
            flpLeft = new FlowLayoutPanel();
            btnAccounts = new PictureBox();
            btnServices = new PictureBox();
            tcMenu.SuspendLayout();
            tbAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAccountDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountCreate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            tbServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceCreate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceEdit).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServices).BeginInit();
            SuspendLayout();
            // 
            // tcMenu
            // 
            tcMenu.Controls.Add(tbAccounts);
            tcMenu.Controls.Add(tbServices);
            tcMenu.Controls.Add(tbPayBills);
            tcMenu.Dock = DockStyle.Fill;
            tcMenu.Location = new Point(181, 51);
            tcMenu.Margin = new Padding(0);
            tcMenu.Multiline = true;
            tcMenu.Name = "tcMenu";
            tcMenu.SelectedIndex = 0;
            tcMenu.Size = new Size(708, 528);
            tcMenu.TabIndex = 0;
            tcMenu.SelectedIndexChanged += tcMenu_SelectedIndexChanged;
            // 
            // tbAccounts
            // 
            tbAccounts.BackColor = Color.FromArgb(230, 239, 245);
            tbAccounts.Controls.Add(btnAccountDelete);
            tbAccounts.Controls.Add(btnAccountCreate);
            tbAccounts.Controls.Add(btnAccountReload);
            tbAccounts.Controls.Add(btnAccountView);
            tbAccounts.Controls.Add(btnAccountEdit);
            tbAccounts.Controls.Add(dgvAccount);
            tbAccounts.Location = new Point(4, 24);
            tbAccounts.Margin = new Padding(0);
            tbAccounts.Name = "tbAccounts";
            tbAccounts.Size = new Size(700, 500);
            tbAccounts.TabIndex = 0;
            tbAccounts.Text = "Accounts";
            // 
            // btnAccountDelete
            // 
            btnAccountDelete.Image = (Image)resources.GetObject("btnAccountDelete.Image");
            btnAccountDelete.Location = new Point(356, 462);
            btnAccountDelete.Margin = new Padding(0, 5, 0, 10);
            btnAccountDelete.Name = "btnAccountDelete";
            btnAccountDelete.Size = new Size(80, 30);
            btnAccountDelete.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAccountDelete.TabIndex = 16;
            btnAccountDelete.TabStop = false;
            btnAccountDelete.Click += btnAccountDelete_Click;
            // 
            // btnAccountCreate
            // 
            btnAccountCreate.Image = (Image)resources.GetObject("btnAccountCreate.Image");
            btnAccountCreate.Location = new Point(269, 462);
            btnAccountCreate.Margin = new Padding(0, 5, 0, 10);
            btnAccountCreate.Name = "btnAccountCreate";
            btnAccountCreate.Size = new Size(80, 30);
            btnAccountCreate.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAccountCreate.TabIndex = 15;
            btnAccountCreate.TabStop = false;
            btnAccountCreate.Click += btnAccountCreate_Click;
            // 
            // btnAccountReload
            // 
            btnAccountReload.Image = (Image)resources.GetObject("btnAccountReload.Image");
            btnAccountReload.Location = new Point(182, 462);
            btnAccountReload.Margin = new Padding(0, 5, 0, 10);
            btnAccountReload.Name = "btnAccountReload";
            btnAccountReload.Size = new Size(80, 30);
            btnAccountReload.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAccountReload.TabIndex = 14;
            btnAccountReload.TabStop = false;
            btnAccountReload.Click += btnAccountReload_Click;
            // 
            // btnAccountView
            // 
            btnAccountView.Image = (Image)resources.GetObject("btnAccountView.Image");
            btnAccountView.Location = new Point(95, 462);
            btnAccountView.Margin = new Padding(0, 5, 0, 10);
            btnAccountView.Name = "btnAccountView";
            btnAccountView.Size = new Size(80, 30);
            btnAccountView.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAccountView.TabIndex = 13;
            btnAccountView.TabStop = false;
            btnAccountView.Click += btnAccountView_Click;
            // 
            // btnAccountEdit
            // 
            btnAccountEdit.Image = (Image)resources.GetObject("btnAccountEdit.Image");
            btnAccountEdit.Location = new Point(7, 462);
            btnAccountEdit.Margin = new Padding(0, 5, 0, 10);
            btnAccountEdit.Name = "btnAccountEdit";
            btnAccountEdit.Size = new Size(80, 30);
            btnAccountEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAccountEdit.TabIndex = 12;
            btnAccountEdit.TabStop = false;
            btnAccountEdit.Click += btnAccountEdit_Click;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.AllowUserToResizeColumns = false;
            dgvAccount.AllowUserToResizeRows = false;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAccount.BackgroundColor = Color.FromArgb(230, 239, 245);
            dgvAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.GridColor = Color.FromArgb(230, 239, 245);
            dgvAccount.Location = new Point(3, 3);
            dgvAccount.MultiSelect = false;
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccount.ShowCellErrors = false;
            dgvAccount.ShowCellToolTips = false;
            dgvAccount.ShowEditingIcon = false;
            dgvAccount.ShowRowErrors = false;
            dgvAccount.Size = new Size(694, 451);
            dgvAccount.TabIndex = 0;
            // 
            // tbServices
            // 
            tbServices.BackColor = Color.FromArgb(230, 239, 245);
            tbServices.Controls.Add(dgvService);
            tbServices.Controls.Add(btnServiceDelete);
            tbServices.Controls.Add(btnServiceCreate);
            tbServices.Controls.Add(btnServiceReload);
            tbServices.Controls.Add(btnServiceView);
            tbServices.Controls.Add(btnServiceEdit);
            tbServices.Location = new Point(4, 24);
            tbServices.Name = "tbServices";
            tbServices.Padding = new Padding(3);
            tbServices.Size = new Size(700, 500);
            tbServices.TabIndex = 1;
            tbServices.Text = "Services";
            // 
            // dgvService
            // 
            dgvService.AllowUserToAddRows = false;
            dgvService.AllowUserToDeleteRows = false;
            dgvService.AllowUserToResizeColumns = false;
            dgvService.AllowUserToResizeRows = false;
            dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvService.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvService.BackgroundColor = Color.FromArgb(230, 239, 245);
            dgvService.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.GridColor = Color.FromArgb(230, 239, 245);
            dgvService.Location = new Point(3, 3);
            dgvService.MultiSelect = false;
            dgvService.Name = "dgvService";
            dgvService.ReadOnly = true;
            dgvService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvService.ShowCellErrors = false;
            dgvService.ShowCellToolTips = false;
            dgvService.ShowEditingIcon = false;
            dgvService.ShowRowErrors = false;
            dgvService.Size = new Size(694, 451);
            dgvService.TabIndex = 22;
            // 
            // btnServiceDelete
            // 
            btnServiceDelete.Image = (Image)resources.GetObject("btnServiceDelete.Image");
            btnServiceDelete.Location = new Point(356, 462);
            btnServiceDelete.Margin = new Padding(0, 5, 0, 10);
            btnServiceDelete.Name = "btnServiceDelete";
            btnServiceDelete.Size = new Size(80, 30);
            btnServiceDelete.SizeMode = PictureBoxSizeMode.AutoSize;
            btnServiceDelete.TabIndex = 21;
            btnServiceDelete.TabStop = false;
            btnServiceDelete.Click += btnServiceDelete_Click;
            // 
            // btnServiceCreate
            // 
            btnServiceCreate.Image = (Image)resources.GetObject("btnServiceCreate.Image");
            btnServiceCreate.Location = new Point(269, 462);
            btnServiceCreate.Margin = new Padding(0, 5, 0, 10);
            btnServiceCreate.Name = "btnServiceCreate";
            btnServiceCreate.Size = new Size(80, 30);
            btnServiceCreate.SizeMode = PictureBoxSizeMode.AutoSize;
            btnServiceCreate.TabIndex = 20;
            btnServiceCreate.TabStop = false;
            btnServiceCreate.Click += btnServiceCreate_Click;
            // 
            // btnServiceReload
            // 
            btnServiceReload.Image = (Image)resources.GetObject("btnServiceReload.Image");
            btnServiceReload.Location = new Point(182, 462);
            btnServiceReload.Margin = new Padding(0, 5, 0, 10);
            btnServiceReload.Name = "btnServiceReload";
            btnServiceReload.Size = new Size(80, 30);
            btnServiceReload.SizeMode = PictureBoxSizeMode.AutoSize;
            btnServiceReload.TabIndex = 19;
            btnServiceReload.TabStop = false;
            btnServiceReload.Click += btnServiceReload_Click;
            // 
            // btnServiceView
            // 
            btnServiceView.Image = (Image)resources.GetObject("btnServiceView.Image");
            btnServiceView.Location = new Point(95, 462);
            btnServiceView.Margin = new Padding(0, 5, 0, 10);
            btnServiceView.Name = "btnServiceView";
            btnServiceView.Size = new Size(80, 30);
            btnServiceView.SizeMode = PictureBoxSizeMode.AutoSize;
            btnServiceView.TabIndex = 18;
            btnServiceView.TabStop = false;
            btnServiceView.Click += btnServiceView_Click;
            // 
            // btnServiceEdit
            // 
            btnServiceEdit.Image = (Image)resources.GetObject("btnServiceEdit.Image");
            btnServiceEdit.Location = new Point(7, 462);
            btnServiceEdit.Margin = new Padding(0, 5, 0, 10);
            btnServiceEdit.Name = "btnServiceEdit";
            btnServiceEdit.Size = new Size(80, 30);
            btnServiceEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnServiceEdit.TabIndex = 17;
            btnServiceEdit.TabStop = false;
            btnServiceEdit.Click += btnServiceEdit_Click;
            // 
            // tbPayBills
            // 
            tbPayBills.Location = new Point(4, 24);
            tbPayBills.Name = "tbPayBills";
            tbPayBills.Padding = new Padding(3);
            tbPayBills.Size = new Size(700, 500);
            tbPayBills.TabIndex = 2;
            tbPayBills.Text = "Pay Bills";
            tbPayBills.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(230, 239, 245);
            pnlTop.Controls.Add(btnMinimize);
            pnlTop.Controls.Add(btnExit);
            pnlTop.Controls.Add(pbIcon);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(889, 51);
            pnlTop.TabIndex = 2;
            // 
            // btnMinimize
            // 
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(836, 17);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(18, 18);
            btnMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMinimize.TabIndex = 18;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(860, 17);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(18, 18);
            btnExit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnExit.TabIndex = 17;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // pbIcon
            // 
            pbIcon.Image = (Image)resources.GetObject("pbIcon.Image");
            pbIcon.Location = new Point(10, 10);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(171, 32);
            pbIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            pbIcon.TabIndex = 9;
            pbIcon.TabStop = false;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(btnAccounts);
            flpLeft.Controls.Add(btnServices);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 51);
            flpLeft.Margin = new Padding(0);
            flpLeft.Name = "flpLeft";
            flpLeft.Padding = new Padding(30, 61, 30, 31);
            flpLeft.Size = new Size(181, 528);
            flpLeft.TabIndex = 0;
            // 
            // btnAccounts
            // 
            btnAccounts.Image = Properties.Resources.accounts;
            btnAccounts.Location = new Point(30, 61);
            btnAccounts.Margin = new Padding(0, 0, 0, 10);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(113, 20);
            btnAccounts.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAccounts.TabIndex = 10;
            btnAccounts.TabStop = false;
            btnAccounts.MouseEnter += btnAccounts_MouseEnter;
            btnAccounts.MouseLeave += btnAccounts_MouseLeave;
            // 
            // btnServices
            // 
            btnServices.Image = Properties.Resources.services;
            btnServices.Location = new Point(30, 91);
            btnServices.Margin = new Padding(0, 0, 0, 10);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(107, 20);
            btnServices.SizeMode = PictureBoxSizeMode.AutoSize;
            btnServices.TabIndex = 11;
            btnServices.TabStop = false;
            btnServices.MouseEnter += btnServices_MouseEnter;
            btnServices.MouseLeave += btnServices_MouseLeave;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 245);
            ClientSize = new Size(889, 579);
            Controls.Add(tcMenu);
            Controls.Add(flpLeft);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdminView";
            Load += FrmAdminView_Load;
            tcMenu.ResumeLayout(false);
            tbAccounts.ResumeLayout(false);
            tbAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAccountDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountCreate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountReload).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountView).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            tbServices.ResumeLayout(false);
            tbServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceCreate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceReload).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceView).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceEdit).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            flpLeft.ResumeLayout(false);
            flpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMenu;
        private TabPage tbAccounts;
        private TabPage tbServices;
        private DataGridView dgvAccount;
        private TabPage tbPayBills;
        private Panel pnlTop;
        private PictureBox pbIcon;
        private PictureBox btnMinimize;
        private PictureBox btnExit;
        private FlowLayoutPanel flpLeft;
        private PictureBox btnAccounts;
        private PictureBox btnServices;
        private PictureBox btnAccountEdit;
        private PictureBox btnAccountView;
        private PictureBox btnAccountDelete;
        private PictureBox btnAccountCreate;
        private PictureBox btnAccountReload;
        private PictureBox btnServiceDelete;
        private PictureBox btnServiceCreate;
        private PictureBox btnServiceReload;
        private PictureBox btnServiceView;
        private PictureBox btnServiceEdit;
        private DataGridView dgvService;
    }
}