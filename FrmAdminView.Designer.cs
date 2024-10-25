namespace Bayad_Center_Project
{
    partial class FrmAdminView
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
            panel1 = new Panel();
            btnAccountView = new Button();
            btnAccountReload = new Button();
            btnAccountDelete = new Button();
            btnAccountCreate = new Button();
            btnAccountEdit = new Button();
            dgvAccount = new DataGridView();
            tbServices = new TabPage();
            btnServiceCreate = new Button();
            dataGridView2 = new DataGridView();
            btnServiceEdit = new Button();
            btnServiceDelete = new Button();
            tbPayBills = new TabPage();
            tcMenu.SuspendLayout();
            tbAccounts.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            tbServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            tcMenu.Size = new Size(1071, 567);
            tcMenu.TabIndex = 0;
            // 
            // tbAccounts
            // 
            tbAccounts.Controls.Add(panel1);
            tbAccounts.Controls.Add(dgvAccount);
            tbAccounts.Location = new Point(4, 24);
            tbAccounts.Name = "tbAccounts";
            tbAccounts.Padding = new Padding(3);
            tbAccounts.Size = new Size(1063, 539);
            tbAccounts.TabIndex = 0;
            tbAccounts.Text = "Accounts";
            tbAccounts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAccountView);
            panel1.Controls.Add(btnAccountReload);
            panel1.Controls.Add(btnAccountDelete);
            panel1.Controls.Add(btnAccountCreate);
            panel1.Controls.Add(btnAccountEdit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 507);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 29);
            panel1.TabIndex = 8;
            // 
            // btnAccountView
            // 
            btnAccountView.Location = new Point(100, 3);
            btnAccountView.Name = "btnAccountView";
            btnAccountView.Size = new Size(89, 23);
            btnAccountView.TabIndex = 9;
            btnAccountView.Text = "View";
            btnAccountView.UseVisualStyleBackColor = true;
            btnAccountView.Click += btnAccountView_Click;
            // 
            // btnAccountReload
            // 
            btnAccountReload.Location = new Point(383, 3);
            btnAccountReload.Name = "btnAccountReload";
            btnAccountReload.Size = new Size(89, 23);
            btnAccountReload.TabIndex = 8;
            btnAccountReload.Text = "Reload";
            btnAccountReload.UseVisualStyleBackColor = true;
            btnAccountReload.Click += btnAccountReload_Click;
            // 
            // btnAccountDelete
            // 
            btnAccountDelete.Location = new Point(288, 3);
            btnAccountDelete.Name = "btnAccountDelete";
            btnAccountDelete.Size = new Size(89, 23);
            btnAccountDelete.TabIndex = 5;
            btnAccountDelete.Text = "Delete";
            btnAccountDelete.UseVisualStyleBackColor = true;
            btnAccountDelete.Click += btnAccountDelete_Click;
            // 
            // btnAccountCreate
            // 
            btnAccountCreate.Location = new Point(193, 3);
            btnAccountCreate.Name = "btnAccountCreate";
            btnAccountCreate.Size = new Size(89, 23);
            btnAccountCreate.TabIndex = 7;
            btnAccountCreate.Text = "Create";
            btnAccountCreate.UseVisualStyleBackColor = true;
            btnAccountCreate.Click += btnAccountCreate_Click;
            // 
            // btnAccountEdit
            // 
            btnAccountEdit.Location = new Point(5, 3);
            btnAccountEdit.Name = "btnAccountEdit";
            btnAccountEdit.Size = new Size(89, 23);
            btnAccountEdit.TabIndex = 6;
            btnAccountEdit.Text = "Edit";
            btnAccountEdit.UseVisualStyleBackColor = true;
            btnAccountEdit.Click += btnAccountEdit_Click;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.AllowUserToResizeColumns = false;
            dgvAccount.AllowUserToResizeRows = false;
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
            dgvAccount.Size = new Size(1057, 533);
            dgvAccount.TabIndex = 0;
            // 
            // tbServices
            // 
            tbServices.Controls.Add(btnServiceCreate);
            tbServices.Controls.Add(dataGridView2);
            tbServices.Controls.Add(btnServiceEdit);
            tbServices.Controls.Add(btnServiceDelete);
            tbServices.Location = new Point(4, 24);
            tbServices.Name = "tbServices";
            tbServices.Padding = new Padding(3);
            tbServices.Size = new Size(1063, 539);
            tbServices.TabIndex = 1;
            tbServices.Text = "Services";
            tbServices.UseVisualStyleBackColor = true;
            // 
            // btnServiceCreate
            // 
            btnServiceCreate.Location = new Point(196, 263);
            btnServiceCreate.Name = "btnServiceCreate";
            btnServiceCreate.Size = new Size(89, 23);
            btnServiceCreate.TabIndex = 10;
            btnServiceCreate.Text = "Create";
            btnServiceCreate.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(506, 251);
            dataGridView2.TabIndex = 1;
            // 
            // btnServiceEdit
            // 
            btnServiceEdit.Location = new Point(101, 263);
            btnServiceEdit.Name = "btnServiceEdit";
            btnServiceEdit.Size = new Size(89, 23);
            btnServiceEdit.TabIndex = 9;
            btnServiceEdit.Text = "Edit";
            btnServiceEdit.UseVisualStyleBackColor = true;
            // 
            // btnServiceDelete
            // 
            btnServiceDelete.Location = new Point(6, 263);
            btnServiceDelete.Name = "btnServiceDelete";
            btnServiceDelete.Size = new Size(89, 23);
            btnServiceDelete.TabIndex = 8;
            btnServiceDelete.Text = "Delete";
            btnServiceDelete.UseVisualStyleBackColor = true;
            // 
            // tbPayBills
            // 
            tbPayBills.Location = new Point(4, 24);
            tbPayBills.Name = "tbPayBills";
            tbPayBills.Padding = new Padding(3);
            tbPayBills.Size = new Size(1063, 539);
            tbPayBills.TabIndex = 2;
            tbPayBills.Text = "Pay Bills";
            tbPayBills.UseVisualStyleBackColor = true;
            // 
            // FrmAdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 567);
            Controls.Add(tcMenu);
            Name = "FrmAdminView";
            Text = "FrmAdminView";
            Load += FrmAdminView_Load;
            tcMenu.ResumeLayout(false);
            tbAccounts.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            tbServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Button btnServiceCreate;
        private DataGridView dataGridView2;
        private Button btnServiceEdit;
        private Button btnServiceDelete;
        private TabPage tbPayBills;
        private Panel panel1;
        private Button btnAccountReload;
        private Button btnAccountView;
    }
}