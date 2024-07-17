using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier.MAINTENANCE
{
    public partial class uploadExcelFormatGuide : Form
    {
        public uploadExcelFormatGuide()
        {
            InitializeComponent();
        }

        private void btn_openSampleFormat_Click(object sender, EventArgs e)
        {
            string file = @"\\kpsdev\apps\Chipmounter Parts Verifier (Keyence)\Excel Format Sample\feederAssignment.xlsx";
            if (File.Exists(file))
            {
                Process.Start(file);
            }
            else
            {
                MessageBox.Show("The file maybe deleted or renamed!\nPlease contact APC Department!", "File Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
