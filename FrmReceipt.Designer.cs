namespace Bayad_Center_Project
{
    partial class FrmReceipt
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
            label11 = new Label();
            label1 = new Label();
            tbAmountToPay = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbPaymentAmount = new TextBox();
            label4 = new Label();
            tbChangeAmount = new TextBox();
            label5 = new Label();
            tbReceiptID = new TextBox();
            tbDateIssued = new TextBox();
            btnAction = new Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(125, 15);
            label11.TabIndex = 40;
            label11.Text = "Receipt Informations";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(241, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 45;
            label1.Text = "Amount To Pay";
            // 
            // tbAmountToPay
            // 
            tbAmountToPay.BackColor = Color.Silver;
            tbAmountToPay.BorderStyle = BorderStyle.None;
            tbAmountToPay.ForeColor = Color.Black;
            tbAmountToPay.Location = new Point(241, 42);
            tbAmountToPay.Name = "tbAmountToPay";
            tbAmountToPay.ReadOnly = true;
            tbAmountToPay.Size = new Size(211, 16);
            tbAmountToPay.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 47;
            label2.Text = "Date Issued";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(241, 61);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 49;
            label3.Text = "Payment Amount";
            // 
            // tbPaymentAmount
            // 
            tbPaymentAmount.BackColor = Color.Silver;
            tbPaymentAmount.BorderStyle = BorderStyle.None;
            tbPaymentAmount.ForeColor = Color.Black;
            tbPaymentAmount.Location = new Point(241, 79);
            tbPaymentAmount.Name = "tbPaymentAmount";
            tbPaymentAmount.ReadOnly = true;
            tbPaymentAmount.Size = new Size(211, 16);
            tbPaymentAmount.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(241, 98);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 51;
            label4.Text = "Change Amount";
            // 
            // tbChangeAmount
            // 
            tbChangeAmount.BackColor = Color.Silver;
            tbChangeAmount.BorderStyle = BorderStyle.None;
            tbChangeAmount.ForeColor = Color.Black;
            tbChangeAmount.Location = new Point(241, 116);
            tbChangeAmount.Name = "tbChangeAmount";
            tbChangeAmount.ReadOnly = true;
            tbChangeAmount.Size = new Size(211, 16);
            tbChangeAmount.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 61);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 53;
            label5.Text = "Receipt ID";
            // 
            // tbReceiptID
            // 
            tbReceiptID.BackColor = Color.Silver;
            tbReceiptID.BorderStyle = BorderStyle.None;
            tbReceiptID.ForeColor = Color.Black;
            tbReceiptID.Location = new Point(12, 79);
            tbReceiptID.Name = "tbReceiptID";
            tbReceiptID.ReadOnly = true;
            tbReceiptID.Size = new Size(211, 16);
            tbReceiptID.TabIndex = 52;
            // 
            // tbDateIssued
            // 
            tbDateIssued.BackColor = Color.Silver;
            tbDateIssued.BorderStyle = BorderStyle.None;
            tbDateIssued.ForeColor = Color.Black;
            tbDateIssued.Location = new Point(12, 42);
            tbDateIssued.Name = "tbDateIssued";
            tbDateIssued.ReadOnly = true;
            tbDateIssued.Size = new Size(211, 16);
            tbDateIssued.TabIndex = 54;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Gray;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(293, 245);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(159, 45);
            btnAction.TabIndex = 55;
            btnAction.Text = "Close";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // FrmReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 299);
            Controls.Add(btnAction);
            Controls.Add(tbDateIssued);
            Controls.Add(label5);
            Controls.Add(tbReceiptID);
            Controls.Add(label4);
            Controls.Add(tbChangeAmount);
            Controls.Add(label3);
            Controls.Add(tbPaymentAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbAmountToPay);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReceipt";
            Load += FrmReceipt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label1;
        private TextBox tbAmountToPay;
        private Label label2;
        private Label label3;
        private TextBox tbPaymentAmount;
        private Label label4;
        private TextBox tbChangeAmount;
        private Label label5;
        private TextBox tbReceiptID;
        private TextBox tbDateIssued;
        private Button btnAction;
    }
}