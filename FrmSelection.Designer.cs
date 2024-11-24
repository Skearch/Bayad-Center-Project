namespace Bayad_Center_Project
{
    partial class FrmSelection
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
            dgvSelection = new DataGridView();
            lblTitle = new Label();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSelection).BeginInit();
            SuspendLayout();
            // 
            // dgvSelection
            // 
            dgvSelection.AllowUserToAddRows = false;
            dgvSelection.AllowUserToDeleteRows = false;
            dgvSelection.AllowUserToResizeColumns = false;
            dgvSelection.AllowUserToResizeRows = false;
            dgvSelection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelection.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSelection.BackgroundColor = Color.FromArgb(230, 239, 245);
            dgvSelection.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvSelection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelection.GridColor = Color.FromArgb(230, 239, 245);
            dgvSelection.Location = new Point(12, 37);
            dgvSelection.MultiSelect = false;
            dgvSelection.Name = "dgvSelection";
            dgvSelection.ReadOnly = true;
            dgvSelection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSelection.ShowCellErrors = false;
            dgvSelection.ShowCellToolTips = false;
            dgvSelection.ShowEditingIcon = false;
            dgvSelection.ShowRowErrors = false;
            dgvSelection.Size = new Size(468, 303);
            dgvSelection.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(45, 25);
            lblTitle.TabIndex = 40;
            lblTitle.Text = "Text";
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Gray;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(321, 346);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(159, 45);
            btnSelect.TabIndex = 47;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // FrmSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 245);
            ClientSize = new Size(490, 401);
            Controls.Add(btnSelect);
            Controls.Add(lblTitle);
            Controls.Add(dgvSelection);
            Name = "FrmSelection";
            Text = "FrmSelection";
            Load += FrmSelection_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSelection).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSelection;
        private Label lblTitle;
        private Button btnSelect;
    }
}