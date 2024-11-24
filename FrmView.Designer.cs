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
            tpAccounts = new TabPage();
            dgvAccount = new DataGridView();
            btnAccountEdit = new PictureBox();
            btnAccountDelete = new PictureBox();
            btnAccountCreate = new PictureBox();
            btnAccountReload = new PictureBox();
            btnAccountView = new PictureBox();
            tpServices = new TabPage();
            dgvService = new DataGridView();
            btnServiceDelete = new PictureBox();
            btnServiceCreate = new PictureBox();
            btnServiceReload = new PictureBox();
            btnServiceView = new PictureBox();
            btnServiceEdit = new PictureBox();
            tpTransactions = new TabPage();
            dgvTransaction = new DataGridView();
            btnTransactionDelete = new PictureBox();
            btnTransactionCreate = new PictureBox();
            btnTransactionReload = new PictureBox();
            btnTransactionView = new PictureBox();
            pnlTop = new Panel();
            lblUser = new Label();
            btnMinimize = new PictureBox();
            btnExit = new PictureBox();
            pbIcon = new PictureBox();
            flpLeft = new FlowLayoutPanel();
            btnAccounts = new PictureBox();
            btnServices = new PictureBox();
            btnTransactions = new PictureBox();
            btnLogout = new PictureBox();
            tcMenu.SuspendLayout();
            tpAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountCreate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountView).BeginInit();
            tpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceCreate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceEdit).BeginInit();
            tpTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactionDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactionCreate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactionReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactionView).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            SuspendLayout();
            // 
            // tcMenu
            // 
            tcMenu.Controls.Add(tpAccounts);
            tcMenu.Controls.Add(tpServices);
            tcMenu.Controls.Add(tpTransactions);
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
            // tpAccounts
            // 
            tpAccounts.BackColor = Color.FromArgb(230, 239, 245);
            tpAccounts.Controls.Add(dgvAccount);
            tpAccounts.Controls.Add(btnAccountEdit);
            tpAccounts.Controls.Add(btnAccountDelete);
            tpAccounts.Controls.Add(btnAccountCreate);
            tpAccounts.Controls.Add(btnAccountReload);
            tpAccounts.Controls.Add(btnAccountView);
            tpAccounts.ForeColor = Color.Black;
            tpAccounts.Location = new Point(4, 24);
            tpAccounts.Margin = new Padding(0);
            tpAccounts.Name = "tpAccounts";
            tpAccounts.Size = new Size(700, 500);
            tpAccounts.TabIndex = 0;
            tpAccounts.Text = "Accounts";
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
            dgvAccount.TabIndex = 29;
            // 
            // btnAccountEdit
            // 
            btnAccountEdit.Image = (Image)resources.GetObject("btnAccountEdit.Image");
            btnAccountEdit.Location = new Point(370, 462);
            btnAccountEdit.Margin = new Padding(0, 5, 0, 10);
            btnAccountEdit.Name = "btnAccountEdit";
            btnAccountEdit.Size = new Size(80, 30);
            btnAccountEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAccountEdit.TabIndex = 18;
            btnAccountEdit.TabStop = false;
            btnAccountEdit.Click += btnAccountEdit_Click;
            // 
            // btnAccountDelete
            // 
            btnAccountDelete.Image = (Image)resources.GetObject("btnAccountDelete.Image");
            btnAccountDelete.Location = new Point(280, 462);
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
            btnAccountCreate.Location = new Point(189, 462);
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
            btnAccountReload.Location = new Point(95, 462);
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
            btnAccountView.Location = new Point(3, 462);
            btnAccountView.Margin = new Padding(0, 5, 0, 10);
            btnAccountView.Name = "btnAccountView";
            btnAccountView.Size = new Size(80, 30);
            btnAccountView.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAccountView.TabIndex = 13;
            btnAccountView.TabStop = false;
            btnAccountView.Click += btnAccountView_Click;
            // 
            // tpServices
            // 
            tpServices.BackColor = Color.FromArgb(230, 239, 245);
            tpServices.Controls.Add(dgvService);
            tpServices.Controls.Add(btnServiceDelete);
            tpServices.Controls.Add(btnServiceCreate);
            tpServices.Controls.Add(btnServiceReload);
            tpServices.Controls.Add(btnServiceView);
            tpServices.Controls.Add(btnServiceEdit);
            tpServices.Location = new Point(4, 24);
            tpServices.Name = "tpServices";
            tpServices.Padding = new Padding(3);
            tpServices.Size = new Size(700, 500);
            tpServices.TabIndex = 1;
            tpServices.Text = "Services";
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
            // tpTransactions
            // 
            tpTransactions.BackColor = Color.FromArgb(230, 239, 245);
            tpTransactions.Controls.Add(dgvTransaction);
            tpTransactions.Controls.Add(btnTransactionDelete);
            tpTransactions.Controls.Add(btnTransactionCreate);
            tpTransactions.Controls.Add(btnTransactionReload);
            tpTransactions.Controls.Add(btnTransactionView);
            tpTransactions.Location = new Point(4, 24);
            tpTransactions.Name = "tpTransactions";
            tpTransactions.Padding = new Padding(3);
            tpTransactions.Size = new Size(700, 500);
            tpTransactions.TabIndex = 2;
            tpTransactions.Text = "Transactions";
            // 
            // dgvTransaction
            // 
            dgvTransaction.AllowUserToAddRows = false;
            dgvTransaction.AllowUserToDeleteRows = false;
            dgvTransaction.AllowUserToResizeColumns = false;
            dgvTransaction.AllowUserToResizeRows = false;
            dgvTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransaction.BackgroundColor = Color.FromArgb(230, 239, 245);
            dgvTransaction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaction.GridColor = Color.FromArgb(230, 239, 245);
            dgvTransaction.Location = new Point(3, 3);
            dgvTransaction.MultiSelect = false;
            dgvTransaction.Name = "dgvTransaction";
            dgvTransaction.ReadOnly = true;
            dgvTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaction.ShowCellErrors = false;
            dgvTransaction.ShowCellToolTips = false;
            dgvTransaction.ShowEditingIcon = false;
            dgvTransaction.ShowRowErrors = false;
            dgvTransaction.Size = new Size(694, 451);
            dgvTransaction.TabIndex = 28;
            // 
            // btnTransactionDelete
            // 
            btnTransactionDelete.Image = (Image)resources.GetObject("btnTransactionDelete.Image");
            btnTransactionDelete.Location = new Point(268, 462);
            btnTransactionDelete.Margin = new Padding(0, 5, 0, 10);
            btnTransactionDelete.Name = "btnTransactionDelete";
            btnTransactionDelete.Size = new Size(80, 30);
            btnTransactionDelete.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTransactionDelete.TabIndex = 27;
            btnTransactionDelete.TabStop = false;
            btnTransactionDelete.Click += btnTransactionDelete_Click;
            // 
            // btnTransactionCreate
            // 
            btnTransactionCreate.Image = (Image)resources.GetObject("btnTransactionCreate.Image");
            btnTransactionCreate.Location = new Point(177, 462);
            btnTransactionCreate.Margin = new Padding(0, 5, 0, 10);
            btnTransactionCreate.Name = "btnTransactionCreate";
            btnTransactionCreate.Size = new Size(80, 30);
            btnTransactionCreate.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTransactionCreate.TabIndex = 26;
            btnTransactionCreate.TabStop = false;
            btnTransactionCreate.Click += btnTransactionCreate_Click;
            // 
            // btnTransactionReload
            // 
            btnTransactionReload.Image = (Image)resources.GetObject("btnTransactionReload.Image");
            btnTransactionReload.Location = new Point(90, 462);
            btnTransactionReload.Margin = new Padding(0, 5, 0, 10);
            btnTransactionReload.Name = "btnTransactionReload";
            btnTransactionReload.Size = new Size(80, 30);
            btnTransactionReload.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTransactionReload.TabIndex = 25;
            btnTransactionReload.TabStop = false;
            btnTransactionReload.Click += btnTransactionReload_Click;
            // 
            // btnTransactionView
            // 
            btnTransactionView.Image = (Image)resources.GetObject("btnTransactionView.Image");
            btnTransactionView.Location = new Point(3, 462);
            btnTransactionView.Margin = new Padding(0, 5, 0, 10);
            btnTransactionView.Name = "btnTransactionView";
            btnTransactionView.Size = new Size(80, 30);
            btnTransactionView.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTransactionView.TabIndex = 24;
            btnTransactionView.TabStop = false;
            btnTransactionView.Click += btnTransactionView_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(230, 239, 245);
            pnlTop.Controls.Add(lblUser);
            pnlTop.Controls.Add(btnMinimize);
            pnlTop.Controls.Add(btnExit);
            pnlTop.Controls.Add(pbIcon);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(889, 51);
            pnlTop.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(177, 177, 177);
            lblUser.Location = new Point(141, 17);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(90, 21);
            lblUser.TabIndex = 13;
            lblUser.Text = "Welcome, ";
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
            flpLeft.Controls.Add(btnTransactions);
            flpLeft.Controls.Add(btnLogout);
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
            btnAccounts.Click += btnAccounts_Click;
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
            btnServices.Click += btnServices_Click;
            btnServices.MouseEnter += btnServices_MouseEnter;
            btnServices.MouseLeave += btnServices_MouseLeave;
            // 
            // btnTransactions
            // 
            btnTransactions.Image = Properties.Resources.transactions;
            btnTransactions.Location = new Point(30, 121);
            btnTransactions.Margin = new Padding(0, 0, 0, 10);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(139, 20);
            btnTransactions.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTransactions.TabIndex = 12;
            btnTransactions.TabStop = false;
            btnTransactions.Click += btnTransactions_Click;
            btnTransactions.MouseEnter += btnTransactions_MouseEnter;
            btnTransactions.MouseLeave += btnTransactions_MouseLeave;
            // 
            // btnLogout
            // 
            btnLogout.Image = Properties.Resources.Logout;
            btnLogout.Location = new Point(30, 151);
            btnLogout.Margin = new Padding(0, 0, 0, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 20);
            btnLogout.SizeMode = PictureBoxSizeMode.AutoSize;
            btnLogout.TabIndex = 13;
            btnLogout.TabStop = false;
            btnLogout.Click += btnLogout_Click;
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
            tpAccounts.ResumeLayout(false);
            tpAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountCreate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountReload).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccountView).EndInit();
            tpServices.ResumeLayout(false);
            tpServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceCreate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceReload).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceView).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServiceEdit).EndInit();
            tpTransactions.ResumeLayout(false);
            tpTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactionDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactionCreate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactionReload).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactionView).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            flpLeft.ResumeLayout(false);
            flpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMenu;
        private TabPage tpAccounts;
        private TabPage tpServices;
        private TabPage tpTransactions;
        private Panel pnlTop;
        private PictureBox pbIcon;
        private PictureBox btnMinimize;
        private PictureBox btnExit;
        private FlowLayoutPanel flpLeft;
        private PictureBox btnAccounts;
        private PictureBox btnServices;
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
        private Panel panel1;
        private PictureBox btnTransactions;
        private DataGridView dgvTransaction;
        private PictureBox btnTransactionDelete;
        private PictureBox btnTransactionCreate;
        private PictureBox btnTransactionReload;
        private PictureBox btnTransactionView;
        private PictureBox btnAccountEdit;
        private Label lblUser;
        private DataGridView dgvAccount;
        private PictureBox btnLogout;
    }
}