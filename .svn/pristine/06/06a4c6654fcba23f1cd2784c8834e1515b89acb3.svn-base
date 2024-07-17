using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier.PRINTBARCODE
{
    public partial class printBarcode_feederMarkings : Form
    {
        public printBarcode_feederMarkings()
        {
            InitializeComponent();
        }
        generateBarcode barcode = new generateBarcode();
        private void btn_printfeeder2_Click(object sender, EventArgs e)
        {
            //barcode.Reset();
            //int iFrom = Convert.ToInt32(nud_from.Value);
            //int iTo = Convert.ToInt32(nud_to.Value);
            //if (iFrom <= iTo)
            //{
            //    lbl_status2.Text = "Status: Printing. . .";
            //    for (int i = iFrom; i <= iTo; i++)
            //    {
            //        barcode.QRCode("Feeder", i.ToString().Trim() + "R", i.ToString().Trim() + "R", 4, i);
            //        //barcode.QRCode("Feeder", i.ToString().Trim() + "L", i.ToString().Trim() + "L", 4, i);
            //    }

            //    barcode.printBarcode_feederLocation(0);
            //    lbl_status2.Text = "Status: Print successful!";
            //}

            barcode.generateDataMatrix("10001");
        }
    }
}
