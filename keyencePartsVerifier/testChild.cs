using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier
{
    public partial class testChild : Form
    {
        public testChild()
        {
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sample");
        }
    }
}
