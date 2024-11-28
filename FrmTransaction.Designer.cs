namespace Bayad_Center_Project
{
    partial class FrmTransaction
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
            label4 = new Label();
            tbAccountNumber = new TextBox();
            lblEmail = new Label();
            tbEmail = new TextBox();
            label1 = new Label();
            tbFullName = new TextBox();
            label2 = new Label();
            tbAmountToPay = new TextBox();
            label3 = new Label();
            rtbMessage = new RichTextBox();
            lblRequiredFields = new Label();
            label5 = new Label();
            tbServiceName = new TextBox();
            btnSetService = new Button();
            btnAction = new Button();
            tbIssuer = new TextBox();
            label6 = new Label();
            btnServiceView = new Button();
            btnAccountView = new Button();
            label11 = new Label();
            label7 = new Label();
            tbPaymentAmount = new TextBox();
            label8 = new Label();
            tbChange = new TextBox();
            btnReceiptView = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 48);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 26;
            label4.Text = "Account Number *";
            // 
            // tbAccountNumber
            // 
            tbAccountNumber.BackColor = Color.Silver;
            tbAccountNumber.BorderStyle = BorderStyle.None;
            tbAccountNumber.ForeColor = Color.Black;
            tbAccountNumber.Location = new Point(12, 66);
            tbAccountNumber.Name = "tbAccountNumber";
            tbAccountNumber.Size = new Size(176, 16);
            tbAccountNumber.TabIndex = 25;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(12, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email *";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.Silver;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.ForeColor = Color.Black;
            tbEmail.Location = new Point(12, 140);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(176, 16);
            tbEmail.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 30;
            label1.Text = "Full Name *";
            // 
            // tbFullName
            // 
            tbFullName.BackColor = Color.Silver;
            tbFullName.BorderStyle = BorderStyle.None;
            tbFullName.ForeColor = Color.Black;
            tbFullName.Location = new Point(12, 103);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(176, 16);
            tbFullName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 258);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 32;
            label2.Text = "Amount To Pay *";
            // 
            // tbAmountToPay
            // 
            tbAmountToPay.BackColor = Color.Silver;
            tbAmountToPay.BorderStyle = BorderStyle.None;
            tbAmountToPay.ForeColor = Color.Black;
            tbAmountToPay.Location = new Point(12, 276);
            tbAmountToPay.Name = "tbAmountToPay";
            tbAmountToPay.Size = new Size(176, 16);
            tbAmountToPay.TabIndex = 31;
            tbAmountToPay.TextChanged += tbAmountToPay_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(207, 48);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 33;
            label3.Text = "Message";
            // 
            // rtbMessage
            // 
            rtbMessage.BackColor = Color.Silver;
            rtbMessage.BorderStyle = BorderStyle.None;
            rtbMessage.ForeColor = Color.Black;
            rtbMessage.Location = new Point(207, 66);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(375, 159);
            rtbMessage.TabIndex = 42;
            rtbMessage.Text = "";
            // 
            // lblRequiredFields
            // 
            lblRequiredFields.AutoSize = true;
            lblRequiredFields.ForeColor = Color.Red;
            lblRequiredFields.Location = new Point(12, 9);
            lblRequiredFields.Name = "lblRequiredFields";
            lblRequiredFields.Size = new Size(140, 15);
            lblRequiredFields.TabIndex = 46;
            lblRequiredFields.Text = "Fields with * are required.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 159);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 47;
            label5.Text = "Service *";
            // 
            // tbServiceName
            // 
            tbServiceName.BackColor = Color.Silver;
            tbServiceName.BorderStyle = BorderStyle.None;
            tbServiceName.ForeColor = Color.Black;
            tbServiceName.Location = new Point(12, 177);
            tbServiceName.Name = "tbServiceName";
            tbServiceName.ReadOnly = true;
            tbServiceName.Size = new Size(176, 16);
            tbServiceName.TabIndex = 48;
            // 
            // btnSetService
            // 
            btnSetService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSetService.BackColor = Color.Gray;
            btnSetService.FlatAppearance.BorderSize = 0;
            btnSetService.FlatStyle = FlatStyle.Flat;
            btnSetService.ForeColor = Color.White;
            btnSetService.Location = new Point(12, 199);
            btnSetService.Name = "btnSetService";
            btnSetService.Size = new Size(44, 27);
            btnSetService.TabIndex = 49;
            btnSetService.Text = "Set";
            btnSetService.UseVisualStyleBackColor = false;
            btnSetService.Click += btnSetService_Click;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Gray;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(423, 411);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(159, 45);
            btnAction.TabIndex = 50;
            btnAction.Text = "Action";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // tbIssuer
            // 
            tbIssuer.BackColor = Color.Silver;
            tbIssuer.BorderStyle = BorderStyle.None;
            tbIssuer.ForeColor = Color.Black;
            tbIssuer.Location = new Point(204, 276);
            tbIssuer.Name = "tbIssuer";
            tbIssuer.ReadOnly = true;
            tbIssuer.Size = new Size(176, 16);
            tbIssuer.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(207, 258);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 51;
            label6.Text = "Issued By *";
            // 
            // btnServiceView
            // 
            btnServiceView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnServiceView.BackColor = Color.Gray;
            btnServiceView.FlatAppearance.BorderSize = 0;
            btnServiceView.FlatStyle = FlatStyle.Flat;
            btnServiceView.ForeColor = Color.White;
            btnServiceView.Location = new Point(305, 430);
            btnServiceView.Name = "btnServiceView";
            btnServiceView.Size = new Size(112, 26);
            btnServiceView.TabIndex = 53;
            btnServiceView.Text = "View Service";
            btnServiceView.UseVisualStyleBackColor = false;
            btnServiceView.Click += btnServiceView_Click;
            // 
            // btnAccountView
            // 
            btnAccountView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccountView.BackColor = Color.Gray;
            btnAccountView.FlatAppearance.BorderSize = 0;
            btnAccountView.FlatStyle = FlatStyle.Flat;
            btnAccountView.ForeColor = Color.White;
            btnAccountView.Location = new Point(197, 430);
            btnAccountView.Name = "btnAccountView";
            btnAccountView.Size = new Size(102, 26);
            btnAccountView.TabIndex = 54;
            btnAccountView.Text = "View Issuer";
            btnAccountView.UseVisualStyleBackColor = false;
            btnAccountView.Click += btnAccountView_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(12, 24);
            label11.Name = "label11";
            label11.Size = new Size(111, 15);
            label11.TabIndex = 55;
            label11.Text = "Transaction Details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 298);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 58;
            label7.Text = "Payment Amount *";
            // 
            // tbPaymentAmount
            // 
            tbPaymentAmount.BackColor = Color.Silver;
            tbPaymentAmount.BorderStyle = BorderStyle.None;
            tbPaymentAmount.ForeColor = Color.Black;
            tbPaymentAmount.Location = new Point(12, 316);
            tbPaymentAmount.Name = "tbPaymentAmount";
            tbPaymentAmount.Size = new Size(176, 16);
            tbPaymentAmount.TabIndex = 57;
            tbPaymentAmount.TextChanged += tbAmountToPay_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 335);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 60;
            label8.Text = "Change *";
            // 
            // tbChange
            // 
            tbChange.BackColor = Color.Silver;
            tbChange.BorderStyle = BorderStyle.None;
            tbChange.ForeColor = Color.Black;
            tbChange.Location = new Point(12, 353);
            tbChange.Name = "tbChange";
            tbChange.ReadOnly = true;
            tbChange.Size = new Size(176, 16);
            tbChange.TabIndex = 59;
            // 
            // btnReceiptView
            // 
            btnReceiptView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReceiptView.BackColor = Color.Gray;
            btnReceiptView.FlatAppearance.BorderSize = 0;
            btnReceiptView.FlatStyle = FlatStyle.Flat;
            btnReceiptView.ForeColor = Color.White;
            btnReceiptView.Location = new Point(82, 430);
            btnReceiptView.Name = "btnReceiptView";
            btnReceiptView.Size = new Size(109, 26);
            btnReceiptView.TabIndex = 61;
            btnReceiptView.Text = "View Receipt";
            btnReceiptView.UseVisualStyleBackColor = false;
            btnReceiptView.Click += btnReceiptView_Click;
            // 
            // FrmTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 245);
            ClientSize = new Size(591, 466);
            Controls.Add(btnReceiptView);
            Controls.Add(btnSetService);
            Controls.Add(btnServiceView);
            Controls.Add(label8);
            Controls.Add(tbChange);
            Controls.Add(label7);
            Controls.Add(tbPaymentAmount);
            Controls.Add(label11);
            Controls.Add(btnAccountView);
            Controls.Add(tbIssuer);
            Controls.Add(label6);
            Controls.Add(btnAction);
            Controls.Add(tbServiceName);
            Controls.Add(label5);
            Controls.Add(lblRequiredFields);
            Controls.Add(rtbMessage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbAmountToPay);
            Controls.Add(label1);
            Controls.Add(tbFullName);
            Controls.Add(lblEmail);
            Controls.Add(tbEmail);
            Controls.Add(label4);
            Controls.Add(tbAccountNumber);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTransaction";
            Load += FrmTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox tbAccountNumber;
        private Label lblEmail;
        private TextBox tbEmail;
        private Label label1;
        private TextBox tbFullName;
        private Label label2;
        private TextBox tbAmountToPay;
        private Label label3;
        private RichTextBox rtbMessage;
        private Label lblRequiredFields;
        private Label label5;
        private TextBox tbServiceName;
        private Button btnSetService;
        private Button btnAction;
        private TextBox tbIssuer;
        private Label label6;
        private Button btnServiceView;
        private Button btnAccountView;
        private Label label11;
        private Label label7;
        private TextBox tbPaymentAmount;
        private Label label8;
        private TextBox tbChange;
        private Button btnReceiptView;
    }
}