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
            tcMenu = new TabControl();
            tbAccounts = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAccountEdit = new Button();
            btnAccountView = new Button();
            btnAccountReload = new Button();
            btnAccountCreate = new Button();
            btnAccountDelete = new Button();
            dgvAccount = new DataGridView();
            tbServices = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnServiceEdit = new Button();
            btnServiceView = new Button();
            btnServiceReload = new Button();
            btnServiceCreate = new Button();
            btnServiceDelete = new Button();
            dgvService = new DataGridView();
            tbPayBills = new TabPage();
            tcMenu.SuspendLayout();
            tbAccounts.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            tbServices.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            SuspendLayout();
            // 
            // tcMenu
            // 
            tcMenu.Controls.Add(tbAccounts);
            tcMenu.Controls.Add(tbServices);
            tcMenu.Controls.Add(tbPayBills);
            tcMenu.Dock = DockStyle.Fill;
            tcMenu.Location = new Point(0, 0);
            tcMenu.Name = "tcMenu";
            tcMenu.SelectedIndex = 0;
            tcMenu.Size = new Size(1040, 571);
            tcMenu.TabIndex = 0;
            // 
            // tbAccounts
            // 
            tbAccounts.BackColor = Color.FromArgb(30, 30, 30);
            tbAccounts.Controls.Add(flowLayoutPanel1);
            tbAccounts.Controls.Add(dgvAccount);
            tbAccounts.Location = new Point(4, 24);
            tbAccounts.Name = "tbAccounts";
            tbAccounts.Padding = new Padding(3);
            tbAccounts.Size = new Size(1032, 543);
            tbAccounts.TabIndex = 0;
            tbAccounts.Text = "Accounts";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(30, 30, 30);
            flowLayoutPanel1.Controls.Add(btnAccountEdit);
            flowLayoutPanel1.Controls.Add(btnAccountView);
            flowLayoutPanel1.Controls.Add(btnAccountReload);
            flowLayoutPanel1.Controls.Add(btnAccountCreate);
            flowLayoutPanel1.Controls.Add(btnAccountDelete);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(3, 507);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1026, 33);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // btnAccountEdit
            // 
            btnAccountEdit.AutoSize = true;
            btnAccountEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccountEdit.BackColor = Color.FromArgb(60, 60, 60);
            btnAccountEdit.Dock = DockStyle.Fill;
            btnAccountEdit.FlatStyle = FlatStyle.Flat;
            btnAccountEdit.ForeColor = Color.White;
            btnAccountEdit.Location = new Point(3, 3);
            btnAccountEdit.Name = "btnAccountEdit";
            btnAccountEdit.Size = new Size(39, 27);
            btnAccountEdit.TabIndex = 6;
            btnAccountEdit.Text = "Edit";
            btnAccountEdit.UseVisualStyleBackColor = false;
            btnAccountEdit.Click += btnAccountEdit_Click;
            // 
            // btnAccountView
            // 
            btnAccountView.AutoSize = true;
            btnAccountView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccountView.BackColor = Color.FromArgb(60, 60, 60);
            btnAccountView.Dock = DockStyle.Fill;
            btnAccountView.FlatStyle = FlatStyle.Flat;
            btnAccountView.ForeColor = Color.White;
            btnAccountView.Location = new Point(48, 3);
            btnAccountView.Name = "btnAccountView";
            btnAccountView.Size = new Size(44, 27);
            btnAccountView.TabIndex = 9;
            btnAccountView.Text = "View";
            btnAccountView.UseVisualStyleBackColor = false;
            btnAccountView.Click += btnAccountView_Click;
            // 
            // btnAccountReload
            // 
            btnAccountReload.AutoSize = true;
            btnAccountReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccountReload.BackColor = Color.FromArgb(60, 60, 60);
            btnAccountReload.Dock = DockStyle.Fill;
            btnAccountReload.FlatStyle = FlatStyle.Flat;
            btnAccountReload.ForeColor = Color.White;
            btnAccountReload.Location = new Point(98, 3);
            btnAccountReload.Name = "btnAccountReload";
            btnAccountReload.Size = new Size(55, 27);
            btnAccountReload.TabIndex = 8;
            btnAccountReload.Text = "Reload";
            btnAccountReload.UseVisualStyleBackColor = false;
            btnAccountReload.Click += btnAccountReload_Click;
            // 
            // btnAccountCreate
            // 
            btnAccountCreate.AutoSize = true;
            btnAccountCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccountCreate.BackColor = Color.FromArgb(60, 60, 60);
            btnAccountCreate.Dock = DockStyle.Fill;
            btnAccountCreate.FlatStyle = FlatStyle.Flat;
            btnAccountCreate.ForeColor = Color.White;
            btnAccountCreate.Location = new Point(159, 3);
            btnAccountCreate.Name = "btnAccountCreate";
            btnAccountCreate.Size = new Size(53, 27);
            btnAccountCreate.TabIndex = 7;
            btnAccountCreate.Text = "Create";
            btnAccountCreate.UseVisualStyleBackColor = false;
            btnAccountCreate.Click += btnAccountCreate_Click;
            // 
            // btnAccountDelete
            // 
            btnAccountDelete.AutoSize = true;
            btnAccountDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccountDelete.BackColor = Color.FromArgb(60, 60, 60);
            btnAccountDelete.Dock = DockStyle.Fill;
            btnAccountDelete.FlatStyle = FlatStyle.Flat;
            btnAccountDelete.ForeColor = Color.White;
            btnAccountDelete.Location = new Point(218, 3);
            btnAccountDelete.Name = "btnAccountDelete";
            btnAccountDelete.Size = new Size(52, 27);
            btnAccountDelete.TabIndex = 5;
            btnAccountDelete.Text = "Delete";
            btnAccountDelete.UseVisualStyleBackColor = false;
            btnAccountDelete.Click += btnAccountDelete_Click;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.AllowUserToResizeColumns = false;
            dgvAccount.AllowUserToResizeRows = false;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAccount.BackgroundColor = Color.FromArgb(60, 60, 60);
            dgvAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Dock = DockStyle.Fill;
            dgvAccount.Location = new Point(3, 3);
            dgvAccount.MultiSelect = false;
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccount.ShowCellErrors = false;
            dgvAccount.ShowCellToolTips = false;
            dgvAccount.ShowEditingIcon = false;
            dgvAccount.ShowRowErrors = false;
            dgvAccount.Size = new Size(1026, 537);
            dgvAccount.TabIndex = 0;
            // 
            // tbServices
            // 
            tbServices.Controls.Add(flowLayoutPanel2);
            tbServices.Controls.Add(dgvService);
            tbServices.Location = new Point(4, 24);
            tbServices.Name = "tbServices";
            tbServices.Padding = new Padding(3);
            tbServices.Size = new Size(1032, 543);
            tbServices.TabIndex = 1;
            tbServices.Text = "Services";
            tbServices.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(30, 30, 30);
            flowLayoutPanel2.Controls.Add(btnServiceEdit);
            flowLayoutPanel2.Controls.Add(btnServiceView);
            flowLayoutPanel2.Controls.Add(btnServiceReload);
            flowLayoutPanel2.Controls.Add(btnServiceCreate);
            flowLayoutPanel2.Controls.Add(btnServiceDelete);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(3, 507);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1026, 33);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // btnServiceEdit
            // 
            btnServiceEdit.AutoSize = true;
            btnServiceEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnServiceEdit.BackColor = Color.FromArgb(60, 60, 60);
            btnServiceEdit.Dock = DockStyle.Fill;
            btnServiceEdit.FlatStyle = FlatStyle.Flat;
            btnServiceEdit.ForeColor = Color.White;
            btnServiceEdit.Location = new Point(3, 3);
            btnServiceEdit.Name = "btnServiceEdit";
            btnServiceEdit.Size = new Size(39, 27);
            btnServiceEdit.TabIndex = 6;
            btnServiceEdit.Text = "Edit";
            btnServiceEdit.UseVisualStyleBackColor = false;
            btnServiceEdit.Click += btnServiceEdit_Click;
            // 
            // btnServiceView
            // 
            btnServiceView.AutoSize = true;
            btnServiceView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnServiceView.BackColor = Color.FromArgb(60, 60, 60);
            btnServiceView.Dock = DockStyle.Fill;
            btnServiceView.FlatStyle = FlatStyle.Flat;
            btnServiceView.ForeColor = Color.White;
            btnServiceView.Location = new Point(48, 3);
            btnServiceView.Name = "btnServiceView";
            btnServiceView.Size = new Size(44, 27);
            btnServiceView.TabIndex = 9;
            btnServiceView.Text = "View";
            btnServiceView.UseVisualStyleBackColor = false;
            btnServiceView.Click += btnServiceView_Click;
            // 
            // btnServiceReload
            // 
            btnServiceReload.AutoSize = true;
            btnServiceReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnServiceReload.BackColor = Color.FromArgb(60, 60, 60);
            btnServiceReload.Dock = DockStyle.Fill;
            btnServiceReload.FlatStyle = FlatStyle.Flat;
            btnServiceReload.ForeColor = Color.White;
            btnServiceReload.Location = new Point(98, 3);
            btnServiceReload.Name = "btnServiceReload";
            btnServiceReload.Size = new Size(55, 27);
            btnServiceReload.TabIndex = 8;
            btnServiceReload.Text = "Reload";
            btnServiceReload.UseVisualStyleBackColor = false;
            btnServiceReload.Click += btnServiceReload_Click;
            // 
            // btnServiceCreate
            // 
            btnServiceCreate.AutoSize = true;
            btnServiceCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnServiceCreate.BackColor = Color.FromArgb(60, 60, 60);
            btnServiceCreate.Dock = DockStyle.Fill;
            btnServiceCreate.FlatStyle = FlatStyle.Flat;
            btnServiceCreate.ForeColor = Color.White;
            btnServiceCreate.Location = new Point(159, 3);
            btnServiceCreate.Name = "btnServiceCreate";
            btnServiceCreate.Size = new Size(53, 27);
            btnServiceCreate.TabIndex = 7;
            btnServiceCreate.Text = "Create";
            btnServiceCreate.UseVisualStyleBackColor = false;
            btnServiceCreate.Click += btnServiceCreate_Click;
            // 
            // btnServiceDelete
            // 
            btnServiceDelete.AutoSize = true;
            btnServiceDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnServiceDelete.BackColor = Color.FromArgb(60, 60, 60);
            btnServiceDelete.Dock = DockStyle.Fill;
            btnServiceDelete.FlatStyle = FlatStyle.Flat;
            btnServiceDelete.ForeColor = Color.White;
            btnServiceDelete.Location = new Point(218, 3);
            btnServiceDelete.Name = "btnServiceDelete";
            btnServiceDelete.Size = new Size(52, 27);
            btnServiceDelete.TabIndex = 5;
            btnServiceDelete.Text = "Delete";
            btnServiceDelete.UseVisualStyleBackColor = false;
            btnServiceDelete.Click += btnServiceDelete_Click;
            // 
            // dgvService
            // 
            dgvService.AllowUserToAddRows = false;
            dgvService.AllowUserToDeleteRows = false;
            dgvService.AllowUserToResizeColumns = false;
            dgvService.AllowUserToResizeRows = false;
            dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvService.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvService.BackgroundColor = Color.FromArgb(60, 60, 60);
            dgvService.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.Dock = DockStyle.Fill;
            dgvService.Location = new Point(3, 3);
            dgvService.MultiSelect = false;
            dgvService.Name = "dgvService";
            dgvService.ReadOnly = true;
            dgvService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvService.ShowCellErrors = false;
            dgvService.ShowCellToolTips = false;
            dgvService.ShowEditingIcon = false;
            dgvService.ShowRowErrors = false;
            dgvService.Size = new Size(1026, 537);
            dgvService.TabIndex = 1;
            // 
            // tbPayBills
            // 
            tbPayBills.Location = new Point(4, 24);
            tbPayBills.Name = "tbPayBills";
            tbPayBills.Padding = new Padding(3);
            tbPayBills.Size = new Size(1032, 543);
            tbPayBills.TabIndex = 2;
            tbPayBills.Text = "Pay Bills";
            tbPayBills.UseVisualStyleBackColor = true;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1040, 571);
            Controls.Add(tcMenu);
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdminView";
            Load += FrmAdminView_Load;
            tcMenu.ResumeLayout(false);
            tbAccounts.ResumeLayout(false);
            tbAccounts.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            tbServices.ResumeLayout(false);
            tbServices.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMenu;
        private TabPage tbAccounts;
        private TabPage tbServices;
        private DataGridView dgvAccount;
        private Button btnAccountCreate;
        private Button btnAccountEdit;
        private Button btnAccountDelete;
        private TabPage tbPayBills;
        private Button btnAccountReload;
        private Button btnAccountView;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnServiceEdit;
        private Button btnServiceView;
        private Button btnServiceReload;
        private Button btnServiceCreate;
        private Button btnServiceDelete;
        private DataGridView dgvService;
    }
}