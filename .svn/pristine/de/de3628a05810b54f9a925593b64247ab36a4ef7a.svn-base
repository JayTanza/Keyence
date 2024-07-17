using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier.MAINTENANCE
{
    public partial class uploadExcel_enterModel : Form
    {
        public uploadExcel_enterModel()
        {
            InitializeComponent();
        }
        public static bool isUpdated = false;
        public static string txtEntered = "";
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadExcel_enterModel_Load(object sender, EventArgs e)
        {
            isUpdated = false;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_model.Text.Trim()))
            {
                txtEntered = txt_model.Text.Trim();
                isUpdated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid model!", "Enter Model", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
