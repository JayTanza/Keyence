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
    public partial class transTable : Form
    {
        public transTable()
        {
            InitializeComponent();
        }
        BindingSource bind;
        private void transTable_Load(object sender, EventArgs e)
        {
            _loadBatch();
        }
        private void _loadBatch()
        {
            data_batch.SelectionChanged -= data_batch_SelectionChanged;
            splitContainer1.SplitterDistance = 232;
            try
            {
                SqlCommand cmdS = new SqlCommand("SELECT distinct rtrim(batchID) as batchID FROM tbl_web_transaction", gclass.con);
                gclass.con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmdS);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gclass.con.Close();


                data_batch.DataSource = dt;
                data_batch.Columns["batchID"].HeaderText = "Batch ID";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data_batch.SelectionChanged+=data_batch_SelectionChanged;
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 232;
        }

        private void btn_reload_batch_Click(object sender, EventArgs e)
        {
            _loadBatch();
        }

        private void data_batch_SelectionChanged(object sender, EventArgs e)
        {
            if(data_batch.Rows.Count>0)
            {
                foreach(DataGridViewRow row in data_batch.SelectedRows)
                {
                    _loadDetails(row.Cells["batchID"].Value.ToString().Trim());
                    txt_details_selectedBatch.Text = row.Cells["batchID"].Value.ToString().Trim();
                    txt_search.Text = string.Empty;
                }
            }
        }
        private void _loadDetails(string batch)
        {
            try
            {
                SqlCommand cmdS = new SqlCommand("SELECT transID, batchID, rtrim(productName) as productName, "+
                    "rtrim(lineName) as lineName, rtrim(tableName) as tableName, rtrim(feederName) as feederName, "+
                    "rtrim(partsName) as partsName, datetimeUpdated FROM tbl_web_transaction WHERE batchID='"+batch+"' "+
                    "ORDER BY productName, lineName, tableName, feederName, partsName, datetimeUpdated", gclass.con);
                gclass.con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmdS);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gclass.con.Close();

                bind = new BindingSource();
                bind.DataSource = dt;
                data_details.DataSource = dt;

                data_details.Columns["transID"].Visible = false;
                data_details.Columns["batchID"].Visible = false;
                data_details.Columns["productName"].HeaderText = "Product";
                data_details.Columns["lineName"].HeaderText = "Line";
                data_details.Columns["tableName"].HeaderText = "Table";
                data_details.Columns["feederName"].HeaderText = "Feeder";
                data_details.Columns["partsName"].HeaderText = "Parts (RINKS Code)";
                data_details.Columns["datetimeUpdated"].HeaderText = "Updated Date & Time";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: SQL (batch: "+batch+")", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void data_details_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gclass._dgvRows(sender,e,this.Font);
        }

        private void data_batch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gclass._dgvRows(sender,e,this.Font);
        }

        private void data_details_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(data_details.Rows.Count>0)
            {
                txt_status.Text = data_details.Rows.Count.ToString() + " row(s) found!";
            }
            else
            {
                txt_status.Text = "0 rows found!";
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string txt2search = txt_search.Text.Replace("'", "''").Replace("[", "");
            bind.Filter = "productName like '%"+txt2search+"%' OR "+
                "lineName like '%"+txt2search+"%' OR "+
                "tableName like '%"+txt2search+"%' OR "+
                "feederName like '%"+txt2search+"%' OR "+
                "partsName like '%"+txt2search+"%'";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            data_batch_SelectionChanged(sender,e);
            txt_search.Text = string.Empty;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (data_details.Rows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Are you sure to DELETE selected rows\nfrom batch: "+txt_details_selectedBatch.Text.Trim()+"?", "Delete Selected Rows?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in data_details.SelectedRows)
                    {
                        _deleteSelected(Convert.ToInt32( row.Cells["transID"].Value.ToString()));
                    }

                    data_batch_SelectionChanged(sender,e);
                    txt_search.Text = string.Empty;
                }
            }
        }
        private void _deleteSelected(int transID)
        {
            try
            {
                SqlCommand cmdD = new SqlCommand("DELETE FROM tbl_web_transaction WHERE transID="+transID+"", gclass.con);
                gclass.con.Open();
                cmdD.ExecuteNonQuery();
                gclass.con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
