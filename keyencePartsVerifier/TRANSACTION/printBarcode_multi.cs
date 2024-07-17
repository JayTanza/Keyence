using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier.TRANSACTION
{
    public partial class printBarcode_multi : Form
    {
        public printBarcode_multi()
        {
            InitializeComponent();
        }
        generateBarcode barcode = new generateBarcode();
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_single_value.Text))
            {
                MessageBox.Show("Please enter barcode value!", "Barcode Value Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            barcode.Reset();
            barcode.QRCode("Step 1 Process", txt_single_value.Text.Trim(), txt_single_value.Text.Trim(), 4,0);

            barcode.printBarcode(0);
        }
    }
}
