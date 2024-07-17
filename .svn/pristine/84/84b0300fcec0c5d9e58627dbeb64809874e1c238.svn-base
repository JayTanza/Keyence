using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using keyencePartsVerifier.MODELS;

namespace keyencePartsVerifier.TRANSACTION
{
    public partial class uploadedText : Form
    {
        public uploadedText()
        {
            InitializeComponent();
        }
        transDataContext context = new transDataContext();
        List<tbl_web2_uploadedText> list;
        private void uploadedText_Load(object sender, EventArgs e)
        {
            list = new List<tbl_web2_uploadedText>(context.tbl_web2_uploadedTexts.ToList());
            data.DataSource = list;
            data.Columns["uploadID"].Visible = false;
            data.Columns["uploadDate"].Visible = false;
            data.Columns["uploadBody"].Visible = false;
            data.Columns["uploadTitle"].HeaderText = "Upload Titles";
        }

        private void uploadedText_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 239;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult d=MessageBox.Show("Are you sure to delete?", "Delete?",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                //MessageBox.Show("Deleted successfully!", "Deleted", MessageBoxButtons.OK,MessageBoxIcon.Information);
                var deleteByID = context.tbl_web2_uploadedTexts.FirstOrDefault(m => m.uploadID == Convert.ToInt32(txt_uploadID.Text));
                context.tbl_web2_uploadedTexts.DeleteOnSubmit(deleteByID);
                context.SubmitChanges();

                list = new List<tbl_web2_uploadedText>(context.tbl_web2_uploadedTexts.ToList());
                data.DataSource = list;
            }
        }

        private void data_SelectionChanged(object sender, EventArgs e)
        {
            if (data.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in data.SelectedRows)
                {
                    txt_date.Text = row.Cells["uploadDate"].Value.ToString().Trim();
                    txt_details.Text = row.Cells["uploadBody"].Value.ToString().Trim();
                    txt_title.Text = row.Cells["uploadTitle"].Value.ToString().Trim();
                    txt_uploadID.Text = row.Cells["uploadID"].Value.ToString().Trim();
                }
            }else
            {   
                txt_date.ResetText();
                txt_details.ResetText();
                txt_title.ResetText();
                txt_uploadID.ResetText();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            list = new List<tbl_web2_uploadedText>(context.tbl_web2_uploadedTexts.ToList());
            data.DataSource = list;
        }
    }
}
