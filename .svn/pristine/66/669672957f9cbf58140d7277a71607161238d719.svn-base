using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier.PRINTBARCODE
{
    public partial class printBarcode_lineMachineTable : Form
    {
        public printBarcode_lineMachineTable()
        {
            InitializeComponent();
        }
        generateBarcode barcode = new generateBarcode();
        private void printBarcode_lineMachineTable_Load(object sender, EventArgs e)
        {
            loadLineMachineTable();
        }
        private void loadLineMachineTable()
        {
            SqlCommand cmdS = new SqlCommand("SELECT distinct lineName, machineName, tableName FROM tbl_web2_maintenance", gclass.con);
            gclass.con.Open();
            SqlDataReader dr = cmdS.ExecuteReader();
            while (dr.Read())
            {
                data.Rows.Add(0, dr["lineName"].ToString().Trim(), dr["machineName"].ToString().Trim(), dr["tableName"].ToString().Trim());
            }
            dr.Close();
            gclass.con.Close();
        }

        private void data_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gclass._dgvRows(sender,e,this.Font);
        }

        private void btn_printSingle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_line.Text))
            {
                MessageBox.Show("Please enter line!", "Invalid Line!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txt_machine.Text))
            {
                MessageBox.Show("Please enter machine!", "Invalid Machine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txt_table.Text))
            {
                MessageBox.Show("Please enter table!", "Invalid Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (inquireCombination(txt_line.Text, txt_machine.Text, txt_table.Text))
            {
                barcode.Reset();
                string barcodeValue = txt_line.Text.Trim() + "~" + txt_machine.Text.Trim() + "~" + txt_table.Text.Trim();
                string barcodeHeader= txt_line.Text.Trim() + "\r" + txt_machine.Text.Trim() + "\r" + txt_table.Text.Trim();
                barcode.QRCode(barcodeHeader, barcodeValue, barcodeValue, 4, 0);
                barcode.printBarcode_lineMachineTable(0);
                MessageBox.Show("Print successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Line~Machine~Table combination not found!", "Combination not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool inquireCombination(string lineName, string machineName, string tableName)
        {
            bool isExist = false;
            SqlCommand cmdS = new SqlCommand("SELECT COUNT(*) FROM tbl_web2_maintenance WHERE lineName='"+lineName.Trim()+"' AND machineName='"+machineName.Trim()+"' AND tableName='"+tableName.Trim()+"'", gclass.con);
            gclass.con.Open();
            Int32 count = (Int32)cmdS.ExecuteScalar();
            gclass.con.Close();
            if (count > 0)
            {
                isExist = true;
            }

            return isExist;
        }

        private void btn_printSelected_Click(object sender, EventArgs e)
        {
            barcode.Reset();
            bool hasSelected = false;
            if (data.Rows.Count > 0)
            {
                int order_id = 0;
                lbl_status.Text = "Status: Printing. Please wait. . .";
                foreach (DataGridViewRow row in data.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["dg_check"].Value) == true)
                    {
                        order_id++;
                        hasSelected = true;
                        string barcodeValue = row.Cells["dg_line"].Value.ToString().Trim() + "~" + row.Cells["dg_machine"].Value.ToString().Trim() + "~" + row.Cells["dg_table"].Value.ToString().Trim();
                        string barcodeHeader = row.Cells["dg_line"].Value.ToString().Trim() + "\r" + row.Cells["dg_machine"].Value.ToString().Trim() + "\r" + row.Cells["dg_table"].Value.ToString().Trim();
                        barcode.QRCode(barcodeHeader, barcodeValue, barcodeValue, 4, order_id);
                        
                    }
                }

                if (hasSelected)
                {
                    barcode.printBarcode_lineMachineTable(0);
                    //MessageBox.Show("Print successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    lbl_status.Text = "Status: Print successful!";
                }
                else
                {
                    //MessageBox.Show("Please select Line~Machine~Table!", "None selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_status.Text = "Status: Please select Line~Machine~Table!";
                    return;
                }
            }
            else
            {
                //MessageBox.Show("No Records found!", "No rows found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_status.Text = "Status: No rows found!";
            }
        }
    }
}
