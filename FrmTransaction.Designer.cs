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
            tbAmount = new TextBox();
            label3 = new Label();
            rtbMessage = new RichTextBox();
            lblRequiredFields = new Label();
            label5 = new Label();
            tbServiceName = new TextBox();
            btnSetService = new Button();
            btnAction = new Button();
            tbUser = new TextBox();
            label6 = new Label();
            btnServiceView = new Button();
            btnAccountView = new Button();
            label11 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
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
            label2.Location = new Point(12, 159);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 32;
            label2.Text = "Amount *";
            // 
            // tbAmount
            // 
            tbAmount.BackColor = Color.Silver;
            tbAmount.BorderStyle = BorderStyle.None;
            tbAmount.ForeColor = Color.Black;
            tbAmount.Location = new Point(12, 177);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(176, 16);
            tbAmount.TabIndex = 31;
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
            rtbMessage.Size = new Size(296, 159);
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
            label5.Location = new Point(12, 196);
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
            tbServiceName.Location = new Point(12, 214);
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
            btnSetService.Location = new Point(61, 3);
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
            btnAction.Location = new Point(344, 288);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(159, 45);
            btnAction.TabIndex = 50;
            btnAction.Text = "Action";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // tbUser
            // 
            tbUser.BackColor = Color.Silver;
            tbUser.BorderStyle = BorderStyle.None;
            tbUser.ForeColor = Color.Black;
            tbUser.Location = new Point(12, 284);
            tbUser.Name = "tbUser";
            tbUser.ReadOnly = true;
            tbUser.Size = new Size(176, 16);
            tbUser.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 266);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 51;
            label6.Text = "Teller Issuer *";
            // 
            // btnServiceView
            // 
            btnServiceView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnServiceView.BackColor = Color.Gray;
            btnServiceView.FlatAppearance.BorderSize = 0;
            btnServiceView.FlatStyle = FlatStyle.Flat;
            btnServiceView.ForeColor = Color.White;
            btnServiceView.Location = new Point(3, 3);
            btnServiceView.Name = "btnServiceView";
            btnServiceView.Size = new Size(52, 27);
            btnServiceView.TabIndex = 53;
            btnServiceView.Text = "View";
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
            btnAccountView.Location = new Point(12, 306);
            btnAccountView.Name = "btnAccountView";
            btnAccountView.Size = new Size(53, 27);
            btnAccountView.TabIndex = 54;
            btnAccountView.Text = "View";
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnServiceView);
            flowLayoutPanel1.Controls.Add(btnSetService);
            flowLayoutPanel1.Location = new Point(12, 232);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 34);
            flowLayoutPanel1.TabIndex = 56;
            // 
            // FrmTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 245);
            ClientSize = new Size(514, 342);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label11);
            Controls.Add(btnAccountView);
            Controls.Add(tbUser);
            Controls.Add(label6);
            Controls.Add(btnAction);
            Controls.Add(tbServiceName);
            Controls.Add(label5);
            Controls.Add(lblRequiredFields);
            Controls.Add(rtbMessage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbAmount);
            Controls.Add(label1);
            Controls.Add(tbFullName);
            Controls.Add(lblEmail);
            Controls.Add(tbEmail);
            Controls.Add(label4);
            Controls.Add(tbAccountNumber);
            Name = "FrmTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTransaction";
            Load += FrmTransaction_Load;
            flowLayoutPanel1.ResumeLayout(false);
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
        private TextBox tbAmount;
        private Label label3;
        private RichTextBox rtbMessage;
        private Label lblRequiredFields;
        private Label label5;
        private TextBox tbServiceName;
        private Button btnSetService;
        private Button btnAction;
        private TextBox tbUser;
        private Label label6;
        private Button btnServiceView;
        private Button btnAccountView;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}