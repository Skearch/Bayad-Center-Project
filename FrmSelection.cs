using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bayad_Center_Project
{
    public partial class FrmSelection : Form
    {
        string title = "";
        public int? selectedID;
        List<object> source = new List<object>();

        public FrmSelection(string title, List<object> source)
        {
            InitializeComponent();
            this.title = title;
            this.source = source;
        }

        private void FrmSelection_Load(object sender, EventArgs e)
        {
            lblTitle.Text = title;
            dgvSelection.DataSource = source;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSelection.SelectedRows.Count < 0)
                throw new Exception("Please select an item.");

            DataGridViewRow selectedRow = dgvSelection.SelectedRows[0];
            this.selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);

            this.Close();
        }
    }
}
