namespace Bayad_Center_Project
{
    partial class FrmService
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
            ofdImages = new OpenFileDialog();
            btnSetImage = new Button();
            pbIcon = new PictureBox();
            btnClearImage = new Button();
            label11 = new Label();
            label4 = new Label();
            rtbDescription = new RichTextBox();
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            lblRequiredFields = new Label();
            btnAction = new Button();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // ofdImages
            // 
            ofdImages.FileName = "openFileDialog1";
            // 
            // btnSetImage
            // 
            btnSetImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSetImage.BackColor = Color.Gray;
            btnSetImage.FlatAppearance.BorderSize = 0;
            btnSetImage.FlatStyle = FlatStyle.Flat;
            btnSetImage.ForeColor = Color.White;
            btnSetImage.Location = new Point(12, 292);
            btnSetImage.Name = "btnSetImage";
            btnSetImage.Size = new Size(79, 27);
            btnSetImage.TabIndex = 6;
            btnSetImage.Text = "Set";
            btnSetImage.UseVisualStyleBackColor = false;
            btnSetImage.Click += btnSetImage_Click;
            // 
            // pbIcon
            // 
            pbIcon.BackColor = Color.Silver;
            pbIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pbIcon.Location = new Point(12, 66);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(220, 220);
            pbIcon.TabIndex = 7;
            pbIcon.TabStop = false;
            // 
            // btnClearImage
            // 
            btnClearImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClearImage.BackColor = Color.Gray;
            btnClearImage.FlatAppearance.BorderSize = 0;
            btnClearImage.FlatStyle = FlatStyle.Flat;
            btnClearImage.ForeColor = Color.White;
            btnClearImage.Location = new Point(97, 292);
            btnClearImage.Name = "btnClearImage";
            btnClearImage.Size = new Size(82, 27);
            btnClearImage.TabIndex = 8;
            btnClearImage.Text = "Clear";
            btnClearImage.UseVisualStyleBackColor = false;
            btnClearImage.Click += btnClearImage_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(12, 24);
            label11.Name = "label11";
            label11.Size = new Size(124, 15);
            label11.TabIndex = 39;
            label11.Text = "Service Informations";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 50);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 40;
            label4.Text = "Icon 220x220 *";
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.Silver;
            rtbDescription.BorderStyle = BorderStyle.None;
            rtbDescription.ForeColor = Color.Black;
            rtbDescription.Location = new Point(238, 103);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(211, 183);
            rtbDescription.TabIndex = 41;
            rtbDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(238, 50);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 43;
            label1.Text = "Name *";
            // 
            // tbName
            // 
            tbName.BackColor = Color.Silver;
            tbName.BorderStyle = BorderStyle.None;
            tbName.ForeColor = Color.Black;
            tbName.Location = new Point(238, 68);
            tbName.Name = "tbName";
            tbName.Size = new Size(211, 16);
            tbName.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(238, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 44;
            label2.Text = "Description";
            // 
            // lblRequiredFields
            // 
            lblRequiredFields.AutoSize = true;
            lblRequiredFields.ForeColor = Color.Red;
            lblRequiredFields.Location = new Point(12, 9);
            lblRequiredFields.Name = "lblRequiredFields";
            lblRequiredFields.Size = new Size(140, 15);
            lblRequiredFields.TabIndex = 45;
            lblRequiredFields.Text = "Fields with * are required.";
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Gray;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(290, 292);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(159, 45);
            btnAction.TabIndex = 46;
            btnAction.Text = "Action";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // FrmService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 245);
            ClientSize = new Size(461, 349);
            Controls.Add(btnAction);
            Controls.Add(lblRequiredFields);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbName);
            Controls.Add(rtbDescription);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(btnClearImage);
            Controls.Add(pbIcon);
            Controls.Add(btnSetImage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmService";
            Load += FrmService_Load;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog ofdImages;
        private Button btnSetImage;
        private PictureBox pbIcon;
        private Button btnClearImage;
        private Label label11;
        private Label label4;
        private RichTextBox rtbDescription;
        private Label label1;
        private TextBox tbName;
        private Label label2;
        private Label lblRequiredFields;
        private Button btnAction;
    }
}