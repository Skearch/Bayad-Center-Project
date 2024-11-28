using Bayad_Center_Project.Entities;
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
    public partial class FrmReceipt : Form
    {
        Receipt receipt;
        public FrmReceipt(Receipt receipt)
        {
            InitializeComponent();
            this.receipt = receipt;
        }

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            tbDateIssued.Text = receipt.DateIssued.ToString();
            tbReceiptID.Text = receipt.ReceiptId.ToString();
            tbAmountToPay.Text = receipt.AmountToPay.ToString();
            tbPaymentAmount.Text = receipt.PaymentAmount.ToString();
            tbChangeAmount.Text = receipt.Change.ToString();
        }

        private void btnAction_Click(object sender, EventArgs e) => this.Close();
    }
}
