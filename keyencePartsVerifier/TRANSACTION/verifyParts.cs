using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier.TRANSACTION
{
    public partial class verifyParts : Form
    {
        public verifyParts()
        {
            InitializeComponent();
        }
        public SqlConnection con_timer = new SqlConnection("Data Source=KPSPRD; Initial Catalog=handHeldDB; User ID=sa; Password=saPRD2016cebu");
        private void verifyParts_Load(object sender, EventArgs e)
        {
            _loadTransByBatch();
            _verifyParts();
        }
        private void _loadTransByBatch()
        {
            try
            {
                timer1.Enabled = false;
                data.Rows.Clear();
                SqlCommand cmdS = new SqlCommand("SELECT * FROM tbl_web_feeder_parts_assign "+
                    "ORDER BY productName, lineName, tableName, feederName, partsName", gclass.con);
                gclass.con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(cmdS);
                //dt = new DataTable();
                //da.Fill(dt);
                SqlDataReader dr = cmdS.ExecuteReader();
                while(dr.Read())
                {
                    data.Rows.Add(null, dr["productName"].ToString().Trim(), dr["lineName"].ToString().Trim(),
                        dr["tableName"].ToString().Trim(), dr["feederName"].ToString().Trim(), dr["partsName"].ToString().Trim(), 0);
                }
                dr.Close();
                gclass.con.Close();

                //data.DataSource = dt;

                timer1.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: SQL", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void _verifyParts()
        {
            foreach (DataGridViewRow row in data.Rows)
            {
                if (_ifVerified(row.Cells["dg_productName"].Value.ToString().Trim(), row.Cells["dg_lineName"].Value.ToString().Trim(),
                    row.Cells["dg_tableName"].Value.ToString().Trim(), row.Cells["dg_feederName"].Value.ToString().Trim(), 
                    row.Cells["dg_partsName"].Value.ToString().Trim())>0)
                {
                    ((DataGridViewImageCell)row.Cells["dg_image"]).Value = Properties.Resources.correct;
                    row.Cells["dg_yes"].Value = 1;
                }
                else
                {
                    ((DataGridViewImageCell)row.Cells["dg_image"]).Value = Properties.Resources.error;
                    row.Cells["dg_yes"].Value = 0;
                }
            }
        }
        private int _ifVerified(string prod, string line, string tabl, string feed, string part)
        {
            Int32 count = 0;
            try
            {
                SqlCommand cmdC = new SqlCommand("SELECT COUNT(*) FROM tbl_web_transaction WHERE productName ='"+prod+"' "+
                    "AND lineName='" + line + "' AND tableName ='" + tabl + "' AND feederName='" + feed + "' AND partsName='" + part + "'", con_timer);
                con_timer.Open();
                count = (Int32)cmdC.ExecuteScalar();
                con_timer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return count;
        }
        private void _filterValues(string txt2search)
        {
            try
            {
                timer1.Enabled = false;
                foreach (DataGridViewRow row in data.Rows)
                {
                    if (row.Cells["dg_mamama"].Value.ToString().Trim().Equals(txt2search))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        break;
                    }
                }
                timer1.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void data_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gclass._dgvRows(sender,e,this.Font);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            _loadTransByBatch();
            _verifyParts();
            r_all.Checked = true;
        }

        private void r_notChecked_CheckedChanged(object sender, EventArgs e)
        {
            if(data.Rows.Count>0)
            {
                foreach(DataGridViewRow row in data.Rows)
                {
                    if(row.Cells["dg_yes"].Value.ToString().Trim()=="0")
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void r_checked_CheckedChanged(object sender, EventArgs e)
        {
            if (data.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in data.Rows)
                {
                    if (row.Cells["dg_yes"].Value.ToString().Trim() == "0")
                    {
                        row.Visible = false;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void r_all_CheckedChanged(object sender, EventArgs e)
        {
            if (data.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in data.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void data_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(data.Rows.Count>0)
            {
                txt_status.Text = data.Rows.Count.ToString() + " row(s) found!";
            }
            else
            {
                txt_status.Text = "0 rows found!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    _verifyParts();
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void verifyParts_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con_timer.State == ConnectionState.Open)
            {
                con_timer.Close();
            }
        }
    }
}
