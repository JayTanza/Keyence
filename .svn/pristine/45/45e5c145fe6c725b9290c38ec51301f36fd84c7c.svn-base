using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace printBarcodeOffline
{
    public partial class printDatamatrixFeederMarkings : Form
    {
        public printDatamatrixFeederMarkings()
        {
            InitializeComponent();
        }
        public string startPath = Application.StartupPath.ToString();
        public static string conString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath.ToString().Trim()+"\\DB.rene";
        generateBarcode barcode = new generateBarcode();
        int iFrom = 0; int iTo = 0; int iTotal = 0;
        bool hasPrefix = false;
        int countPreZero = 0;
        private void txt_status_TextChanged(object sender, EventArgs e)
        {
            if (txt_status.Text.ToLower().Contains("success"))
            {
                txt_status.ForeColor= Color.Teal;
            }
            else if (txt_status.Text.ToLower().Contains("wait"))
            {
                txt_status.ForeColor = Color.Blue;
            }
            else if (txt_status.Text.ToLower().Contains("error"))
            {
                txt_status.ForeColor = Color.Red;
            }
            else
            {
                txt_status.ForeColor = Color.Black;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDatamatrixFeederMarkings_Load(object sender, EventArgs e)
        {
            barcode.VerifyBarcodeFolder();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure to exit application?", "Quit?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (bW_insert.IsBusy)
                {
                    bW_insert.CancelAsync();
                }

                if (bW_print.IsBusy)
                {
                    bW_print.CancelAsync();
                }
            }
        }

        private void printDatamatrixFeederMarkings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            
            if (chk_prefix.Checked )
            {
                if (string.IsNullOrEmpty(txt_prefix.Text.Trim()))
                {
                    hasPrefix = false;
                    MessageBox.Show("Please add prefix if you check (with prefix)!", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    countPreZero = txt_from.Text.Length;
                    hasPrefix = true;
                }
            }
            else
            {
                hasPrefix = false;
            }


            if (string.IsNullOrEmpty(txt_from.Text.Trim()))
            {
                MessageBox.Show("Please enter (Number From)!", "Invalid number", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txt_to.Text.Trim()))
            {
                MessageBox.Show("Please enter (Number To)!", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            try
            {
               iFrom= int.Parse(txt_from.Text);
            }
            catch
            {
                MessageBox.Show("Invalid entry!\nPlease enter number!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                iTo=int.Parse(txt_to.Text);
            }
            catch
            {
                MessageBox.Show("Invalid entry!\nPlease enter number!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (iFrom <= iTo)
            {
                
                iTotal = iTo - iFrom;
                enableControls(false);
                //MessageBox.Show("Condition passed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!bW_insert.IsBusy)
                {
                    bW_insert.RunWorkerAsync(500);
                }

            }
            else
            {
                MessageBox.Show("Out of Range!\n(Number To) must be greater than or equal to (Number From)!", "Out of Range!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            
        }

        private void data_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            appTools._dgvRows(sender,e,this.Font);
        }
        private void bW_print_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker = sender as BackgroundWorker;
            int startCount = 0;
            for (int i =iFrom; i <= iTo; i++)
            {
                if (e.Cancel)
                {
                    bW_insert.CancelAsync();
                }
                worker.ReportProgress(startCount++);
                if (hasPrefix)
                {
                    barcode.generateDataMatrix(i,txt_prefix.Text.Trim()+ i.ToString("D"+countPreZero.ToString()).Trim());
                }
                else
                {
                    barcode.generateDataMatrix(i, i.ToString().Trim());
                }
            }
        }

        private void bW_print_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            decimal dTotal = Convert.ToDecimal(iTotal);
            metroProgressBar1.Minimum = 0;
            metroProgressBar1.Maximum = iTotal;
            metroProgressBar1.Value = e.ProgressPercentage;
            txt_status.Text = "Status: Generating Datamatrix("+((Convert.ToDecimal(e.ProgressPercentage)/dTotal)*100).ToString("N1")+"%)...";
        }

        private void bW_print_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("You cancelled the operation!", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                bW_print.RunWorkerAsync(500);
            }
        }

        private void txt_from_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_to.Focus();
            }
        }

        private void txt_to_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_print_Click(sender,e);
            }
        }
        private void enableControls(bool isTrue)
        {
            btn_print.Enabled = isTrue;
            btn_close.Enabled = isTrue;
            txt_from.Enabled = isTrue;
            txt_to.Enabled = isTrue;
        }

        private void bW_print_DoWork_1(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker w = new BackgroundWorker();
            w = sender as BackgroundWorker;
            w.ReportProgress(1);
            barcode.printDataMatrix();
        }

        private void bW_print_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            txt_status.Text = "Status: Printing. Please wait. . .";
        }

        private void bW_print_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            metroProgressBar1.Value = 0;
            txt_status.Text = "Status: Print success!";
            enableControls(true);
            barcode.Reset();
        }

        private void printDatamatrixFeederMarkings_Shown(object sender, EventArgs e)
        {
            //string sysFileName = "C:\\keyenceOfflineDB\\Print Feeder Markings.exe";
            //if (!System.IO.File.Exists(sysFileName))
            //{
            //    new transfer_files().ShowDialog();
            //}
        }

        private void chk_prefix_CheckedChanged(object sender, EventArgs e)
        {
            txt_prefix.Enabled = chk_prefix.Checked ? true : false;
            txt_prefix.Focus(); 
        }

    }
}
