using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using keyencePartsVerifier.MODELS;
using System.Data.SqlClient;
using System.Configuration;

namespace keyencePartsVerifier.TRANSACTION
{
    public partial class actualChecking_byTables2 : Form
    {
        public actualChecking_byTables2()
        {
            InitializeComponent();
        }

        string conString = ConfigurationManager.ConnectionStrings["keyencePartsVerifier.Properties.Settings.handHeldDBConnectionString"].ConnectionString;
        transDataContext context = new transDataContext();
        List<tableIncludedClass> listTables;

        void _loadModels()
        {
            //    var tbl = (from z in context.tbl_web2_maintenances
            //               select z).Select(m => new { modelName = m.modelName.Trim() }).Distinct().OrderBy(m => m.modelName).ToList();


            var tbl = context.sp_getModelName().ToList();

            //load models
            cb_model.DataSource = tbl;
            cb_model.DisplayMember = "modelName";
            cb_model.ValueMember = "modelName";
            
            //foreach (var item in tbl)
            //{
            //    if (!cb_model.Items.Contains(item.modelName.Trim()))
            //    {
            //        cb_model.Items.Add(item.modelName.Trim());
            //    }
            //}
        
        }


        void _loadIncludedTables(string model)
        {
            listTables = new List<tableIncludedClass>();
            using (var sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlCommand cmdPeriod = new SqlCommand("sp_getCurrentPeriodID2", sqlCon);
                cmdPeriod.CommandType = CommandType.StoredProcedure;
                cmdPeriod.Parameters.AddWithValue("@model", model);
                string period = "No Period"; string status = "";
                string physicalModel = "No Period"; string lot_or_Ref = ""; string physical_Type = "";
                SqlDataReader drPeriod = cmdPeriod.ExecuteReader();
                while (drPeriod.Read())
                {
                    period = drPeriod["sPeriod"].ToString().Trim();
                    status = drPeriod["status"].ToString().Trim();
                    physicalModel = drPeriod["PhysicalModel"].ToString().Trim();
                    lot_or_Ref = drPeriod["Lot_or_Ref"].ToString().Trim();
                    physical_Type = drPeriod["Physical_Type"].ToString().Trim();
                }
                drPeriod.Close();
                txt_period_per_model.Text = period;
                txt_status_display.Text = status;

                if (this.btn_stop_period.Enabled)
                {
                    //if (physical_Type == "RT1")
                    //{
                    //    this.rbtn_RT1.Checked = true;
                    //}
                    //else if (physical_Type == "Camera")
                    //{
                    //    this.rbtn_Camera.Checked = true;
                    //}
                    //else if (physical_Type == "REX")
                    //{
                    //    this.rbtn_REX.Checked = true;
                    //}
                    //else
                    //{
                    //    this.rbtn_RT1.Checked = false;
                    //    this.rbtn_Camera.Checked = false;
                    //    this.rbtn_REX.Checked = false;
                    //}
                    this.comboBox2.Text = physical_Type;

                    this.comboBox1.Text = physicalModel;
                    this.textBox4.Text = lot_or_Ref;
                }

                SqlCommand cmdS = new SqlCommand("sp_tbl_web2_maintenance_s_tablesWithStatus", sqlCon);
                cmdS.CommandType = CommandType.StoredProcedure;
                cmdS.Parameters.AddWithValue("@model", model);
                cmdS.Parameters.AddWithValue("@period", period);
                SqlDataReader dr = cmdS.ExecuteReader();
                while (dr.Read())
                {
                    tableIncludedClass newRow = new tableIncludedClass();
                    newRow.table = dr["tables"].ToString().Trim();
                    newRow.totalCount = dr["totalCount"].ToString().Trim();
                    newRow.checkedCount = dr["checkedCount"].ToString().Trim();
                    listTables.Add(newRow);
                }
                dr.Close();
            }

            Control[] linePanels = { this.pnl_line1, this.pnl_line2, this.pnl_line3, this.pnl_line4 };

            foreach (Control linePanel in linePanels)
            {
                foreach (Control gb in linePanel.Controls)
                {
                    if (gb is GroupBox)
                    {
                        foreach (Control ctrl in ((GroupBox)gb).Controls)
                        {
                            if (ctrl is Button)
                            {
                                Button btn = ctrl as Button;
                                btn.BackColor = Color.DimGray;
                                btn.Text = "Not included in model: " + txt_model_display.Text.Trim();
                                btn.Enabled = false;
                                foreach (var table in listTables)
                                {
                                    if (btn.Name.ToString().Trim() == "a" + table.table.Trim())
                                    {
                                        //MessageBox.Show(btn.Name.ToString().Trim() + "-" + table.table.Trim());
                                        //btn.Text = btn.Tag.ToString() + "\n" + table.checkedCount + " of " + table.totalCount;
                                        btn.Text = btn.Tag.ToString() + "\n(" + table.checkedCount + " of " + table.totalCount + ")";
                                        btn.BackColor = Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.Teal : Color.White;
                                        btn.ForeColor = Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.White : Color.Black;
                                        btn.Enabled = true;
                                    }

                                }
                            }
                        }
                    }
                }
            }
            #region
            //dataGridView1.DataSource = listTables;
            /*
            #region LINE-1
            foreach (Control gb in pnl_line1.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control ctrl in ((GroupBox)gb).Controls)
                    {
                        if (ctrl is Button)
                        {
                            Button btn = ctrl as Button;
                            btn.BackColor = Color.DimGray;
                            btn.Text = "Not included in model: "+txt_model_display.Text.Trim();
                            btn.Enabled = false;
                            foreach (var table in listTables)
                            {
                                if (btn.Name.ToString().Trim() == "a" + table.table.Trim())
                                {
                                    //MessageBox.Show(btn.Name.ToString().Trim() + "-" + table.table.Trim());
                                    //btn.Text = btn.Tag.ToString() + "\n" + table.checkedCount + " of " + table.totalCount;
                                    btn.Text = btn.Tag.ToString() + "\n("+table.checkedCount + " of " + table.totalCount+")";
                                    btn.BackColor = Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.Teal : Color.White;
                                    btn.ForeColor= Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.White : Color.Black;
                                    btn.Enabled = true;
                                }

                            }
                        }
                    }
                }
            }
            #endregion
            #region LINE-2
            foreach (Control gb in pnl_line2.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control ctrl in ((GroupBox)gb).Controls)
                    {
                        if (ctrl is Button)
                        {
                            Button btn = ctrl as Button;
                            btn.BackColor = Color.DimGray;
                            btn.Text = "Not included in model: " + txt_model_display.Text.Trim();
                            btn.Enabled = false;
                            foreach (var table in listTables)
                            {
                                if (btn.Name.ToString().Trim() == "a" + table.table.Trim())
                                {
                                    //MessageBox.Show(btn.Name.ToString().Trim() + "-" + table.table.Trim());
                                    btn.Text = btn.Tag.ToString() + "\n(" + table.checkedCount + " of " + table.totalCount+")";
                                    btn.BackColor = Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.Teal : Color.White;
                                    btn.ForeColor = Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.White : Color.Black;
                                    btn.Enabled = true;

                                }

                            }
                        }
                    }
                }
            }
            #endregion
            #region LINE-3
            foreach (Control gb in pnl_line3.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control ctrl in ((GroupBox)gb).Controls)
                    {
                        if (ctrl is Button)
                        {
                            Button btn = ctrl as Button;
                            btn.BackColor = Color.DimGray;
                            btn.Text = "Not included in model: " + txt_model_display.Text.Trim();
                            btn.Enabled = false;
                            foreach (var table in listTables)
                            {
                                if (btn.Name.ToString().Trim() == "a" + table.table.Trim())
                                {
                                    //MessageBox.Show(btn.Name.ToString().Trim() + "-" + table.table.Trim());
                                    btn.Text = btn.Tag.ToString() + "\n(" + table.checkedCount + " of " + table.totalCount+")";
                                    btn.BackColor = Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.Teal : Color.White;
                                    btn.ForeColor = Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.White : Color.Black;
                                    btn.Enabled = true;
                                }

                            }
                        }
                    }
                }
            }
            #endregion
            #region LINE-4
            foreach (Control gb in pnl_line4.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control ctrl in ((GroupBox)gb).Controls)
                    {
                        if (ctrl is Button)
                        {
                            Button btn = ctrl as Button;
                            btn.BackColor = Color.DimGray;
                            btn.Text = "Not included in model: " + txt_model_display.Text.Trim();
                            btn.Enabled = false;
                            foreach (var table in listTables)
                            {
                                if (btn.Name.ToString().Trim() == "a" + table.table.Trim())
                                {
                                    //MessageBox.Show(btn.Name.ToString().Trim() + "-" + table.table.Trim());
                                    btn.Text = btn.Tag.ToString() + "\n(" + table.checkedCount + " of " + table.totalCount + ")";
                                    btn.BackColor = Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.Teal : Color.White;
                                    btn.ForeColor = Convert.ToDecimal(table.checkedCount) >= Convert.ToDecimal(table.totalCount) ? Color.White : Color.Black;
                                    btn.Enabled = true;
                                }

                            }
                        }
                    }
                }
            }
            #endregion
            */
            #endregion
        }

        void _viewCheckingStatusPerTable(string model, string line, string machine, string table)
        {
            if (!string.IsNullOrEmpty(model))
            {
                timer1.Enabled = false;
                lbl_timeIndicator.Text = "Timer OFF";
                actualChecking_byTables2_status form = new actualChecking_byTables2_status(model, line, machine, table, new SqlConnection(conString), txt_period_per_model.Text.Trim());
                //form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
                timer1.Enabled = true;
                lbl_timeIndicator.Text = "Timer ON";
            }
        }

        bool _isModelFinished(string model, string period)
        {
            bool isTrue = false;
            using (var con = new SqlConnection(conString))
            {
                SqlCommand cmdS = new SqlCommand("sp_stopCurrentPeriodID", con);
                cmdS.CommandType = CommandType.StoredProcedure;
                cmdS.Parameters.AddWithValue("@model", model);
                cmdS.Parameters.AddWithValue("@period", period);
                con.Open();
                isTrue = Convert.ToBoolean((int)cmdS.ExecuteScalar());
            }

            return isTrue;
        }

        bool _isNewPeriodGenerated(string model, string physicalModel, string lot_or_Ref, string physical_Type)
        {
            bool isGenerated = false;
            try
            {
                using (var con = new SqlConnection(conString))
                {
                    SqlCommand cmdS = new SqlCommand("sp_generateNewPeriodID2", con);
                    cmdS.CommandType = CommandType.StoredProcedure;
                    cmdS.Parameters.AddWithValue("@model", model);
                    cmdS.Parameters.AddWithValue("@PhysicalModel", physicalModel);
                    cmdS.Parameters.AddWithValue("@Lot_or_Ref", lot_or_Ref);
                    cmdS.Parameters.AddWithValue("@Physical_Type", physical_Type);
                    con.Open();
                    cmdS.ExecuteNonQuery();
                    isGenerated = true;
                }
            }
            catch
            {
                isGenerated = false;
            }

            return isGenerated;
        }

        private void actualChecking_byTables2_Load(object sender, EventArgs e)
        {
            _loadModels();

            try
            {
                using (var con = new SqlConnection(Program._CONNECTIONSTRING_KPSPRD))
                {
                    #region query
                    string query = @"select DISTINCT MOD_RINSType from tbl_RINS_Model where MOD_Status = 'Active'";
                    #endregion

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    comboBox1.Text = string.Empty;
                    comboBox1.Items.Clear();

                    while (rdr.Read())
                    {
                        comboBox2.Items.Add(rdr["MOD_RINSType"].ToString());
                        // this.lblTotalNotAssignedEmployee.Text = rdr["Total"].ToString().Trim();
                    }
                    rdr.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
            }

            this.Icon = Properties.Resources.keyence;
        }

        private void cb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_model_display.Text = cb_model.Text;
            _loadIncludedTables(txt_model_display.Text);

            if (this.btn_stop_period.Enabled)
            {
                panel1.Enabled = true;
            }
            else if (!this.btn_stop_period.Enabled)
            {
                panel1.Enabled = false;
            }

            if (txt_status_display.Text.Contains("NEW"))
            {
                btn_stop_period.Enabled = true;
                btn_start_new_period.Enabled = false;
            }
            else if (txt_status_display.Text.Contains("COMPLETE"))
            {
                btn_stop_period.Enabled = false;
                btn_start_new_period.Enabled = true;
            }
            else
            {
                btn_stop_period.Enabled = false;
                btn_start_new_period.Enabled = true;
            }

            /* auto-retrieve ON */
            timer1.Enabled = false;
            lbl_timeIndicator.Text = "Timer OFF";
            timer1.Enabled = true;
            lbl_timeIndicator.Text = "Timer ON";

            if (this.txt_period_per_model.Text == "No Period")
            {
                panel1.Enabled = true;
            }
        }

        private void btn_start_new_period_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_status_display.Text.Contains("NEW"))
                {
                    MessageBox.Show("Cannot Start new!", "Unfinished checking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult d = MessageBox.Show("Are you sure to create new period for\nmodel: " + txt_model_display.Text.Trim() + "?", "Create New Period?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        //if (!this.rbtn_RT1.Checked && !this.rbtn_Camera.Checked && !this.rbtn_REX.Checked)
                        if(string.IsNullOrEmpty(this.comboBox2.Text.Trim()))
                        {
                            MessageBox.Show("Select Process!", "Unselected Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (string.IsNullOrEmpty(this.comboBox1.Text))
                        {
                            MessageBox.Show("Model is required!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (string.IsNullOrEmpty(this.textBox4.Text))
                        {
                            MessageBox.Show(textBox4.Text.Remove(6, 1) + " is required!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string physical_Type = string.Empty;
                        physical_Type = this.comboBox2.Text;
                        //if (rbtn_RT1.Checked)
                        //    physical_Type = this.rbtn_RT1.Text;
                        //else if (rbtn_Camera.Checked)
                        //    physical_Type = this.rbtn_Camera.Text;
                        //else if (rbtn_REX.Checked)
                        //    physical_Type = this.rbtn_REX.Text;

                        //MessageBox.Show("Okay to start!", "Start New", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (_isNewPeriodGenerated(txt_model_display.Text.Trim(), this.comboBox1.Text, this.textBox4.Text, physical_Type))
                        {
                            cb_model_SelectedIndexChanged(sender, e);
                            MessageBox.Show("New period created successfully!", "Started New Period", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_model_display_Enter(object sender, EventArgs e)
        {
            cb_model.Focus();
        }

        private void btn_stop_period_Click(object sender, EventArgs e)
        {
            if (_isModelFinished(txt_model_display.Text.Trim(), txt_period_per_model.Text.Trim()))
            {
                MessageBox.Show("Current period has stopped/finished!", "Finished Checking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_model_SelectedIndexChanged(sender, e);
                //this.rbtn_RT1.Checked = false;
                //this.rbtn_Camera.Checked = false;
                //label10.Visible = false;
                //label11.Visible = false;
                //comboBox1.Text = string.Empty;
                //textBox4.Text = string.Empty;


            }
            else
            {
                MessageBox.Show("Please finish checking parts before stopping period!", "Unfinished Checking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_status_display_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(conString))
            {
                _loadIncludedTables(txt_model_display.Text);


                if (txt_status_display.Text.Contains("NEW"))
                {
                    btn_stop_period.Enabled = true;
                    btn_start_new_period.Enabled = false;
                }
                else if (txt_status_display.Text.Contains("COMPLETE"))
                {
                    btn_stop_period.Enabled = false;
                    btn_start_new_period.Enabled = true;
                }
                else
                {
                    btn_stop_period.Enabled = false;
                    btn_start_new_period.Enabled = true;
                }

                this.Text = "Actual Checking - by Tables [Updated " + DateTime.Now.ToLongTimeString() + "]";
            }
        }

        private void Line_Machine_Table_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string line = btn.Parent.Parent.Controls.OfType<Label>().Select(x => x.Text).FirstOrDefault().ToString();
            string machineName = btn.Parent.Text;

            _viewCheckingStatusPerTable(cb_model.Text.Trim(), line, machineName, btn.Tag.ToString());
        }

        /*
             #region LINE-1

             #region CM602_1
             private void a1_CM602_1_1_Click(object sender, EventArgs e)
             {
                 MessageBox.Show(this.a1_CM602_1_1.Parent.Parent.Controls["lblLine1"].Text);
                 MessageBox.Show(this.a1_CM602_1_1.Parent.Text);

                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "CM602_1", gclass.TABLE_1);
             }

             private void a1_CM602_1_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "CM602_1", gclass.TABLE_2);
             }

             private void a1_CM602_1_3_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "CM602_1", gclass.TABLE_3);
             }

             private void a1_CM602_1_4_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "CM602_1", gclass.TABLE_4);
             }
             #endregion
             #region CM402_2
             private void a1_CM402_2_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "CM402_2", gclass.TABLE_1);
             }

             private void a1_CM402_2_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "CM402_2", gclass.TABLE_2);
             }

             private void a1_CM402_2_3_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "CM402_2", gclass.TABLE_3);
             }

             private void a1_CM402_2_4_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "CM402_2", gclass.TABLE_4);
             }

             #endregion 
             #region DT401_3
             private void a1_DT401_3_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "DT401_3", gclass.TABLE_1);
             }

             private void a1_DT401_3_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(cb_model.Text.Trim(), gclass.LINE_1, "DT401_3", gclass.TABLE_2);
             }
             #endregion

             #endregion
             #region LINE-2

             #region CM402_1
             private void a2_CM402_1_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "CM402_1", gclass.TABLE_1);
             }
             private void a2_CM402_1_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "CM402_1", gclass.TABLE_2);
             }
             private void a2_CM402_1_3_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "CM402_1", gclass.TABLE_3);
             }
             private void a2_CM402_1_4_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "CM402_1", gclass.TABLE_4);
             }

             #endregion
             #region CM402_2
             private void a2_CM402_2_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "CM402_2", gclass.TABLE_1);
             }
             private void a2_CM402_2_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "CM402_2", gclass.TABLE_2);
             }
             private void a2_CM402_2_3_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "CM402_2", gclass.TABLE_3);
             }
             private void a2_CM402_2_4_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "CM402_2", gclass.TABLE_4);
             }
             #endregion        
             #region DT401_3

             private void a2_DT401_3_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "DT401_3", gclass.TABLE_1);
             }

             private void a2_DT401_3_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_2, "DT401_3", gclass.TABLE_2);
             }
             #endregion

             #endregion
             #region LINE-3

             #region CM402_1
             private void a3_CM402_1_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "CM402_1", gclass.TABLE_1);
             }

             private void a3_CM402_1_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "CM402_1", gclass.TABLE_2);
             }

             private void a3_CM402_1_3_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "CM402_1", gclass.TABLE_3);
             }

             private void a3_CM402_1_4_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "CM402_1", gclass.TABLE_4);
             }
             #endregion
             #region CM402_2
             private void a3_CM402_2_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "CM402_2", gclass.TABLE_1);
             }

             private void a3_CM402_2_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "CM402_2", gclass.TABLE_2);
             }

             private void a3_CM402_2_3_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "CM402_2", gclass.TABLE_3);
             }

             private void a3_CM402_2_4_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "CM402_2", gclass.TABLE_4);
             }
             #endregion
             #region DT401_3
             private void a3_DT401_3_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "DT401_3", gclass.TABLE_1);
             }

             private void a3_DT401_3_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_3, "DT401_3", gclass.TABLE_2);
             }
             #endregion

             #endregion
             #region LINE-4

             #region CM201_1
             private void a4_CM201_1_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_4, "CM201_1", gclass.TABLE_1);
             }

             private void a4_CM201_1_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_4, "CM201_1", gclass.TABLE_2);
             }
             #endregion
             #region CM212_2
             private void a4_CM212_2_1_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_4, "CM212_2", gclass.TABLE_1);
             }

             private void a4_CM212_2_2_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_4, "CM212_2", gclass.TABLE_2);
             }

             private void a4_CM212_2_3_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_4, "CM212_2", gclass.TABLE_3);
             }

             private void a4_CM212_2_4_Click(object sender, EventArgs e)
             {
                 _viewCheckingStatusPerTable(txt_model_display.Text.Trim(), gclass.LINE_4, "CM212_2", gclass.TABLE_4);
             }
             #endregion

             #endregion
             */
        //private void rbtn_RT1_CheckedChanged(object sender, EventArgs e)
        //{
            //if (this.rbtn_RT1.Checked)
            //{
            //    comboBox1.Text = string.Empty;
            //    comboBox1.Items.Clear();
            //    comboBox1.Items.Add("EMCC4");
            //    comboBox1.Items.Add("EMCT16CN");
            //    comboBox1.Items.Add("EMCT16ES");
            //    comboBox1.Items.Add("EMCT16FN");
            //    comboBox1.Items.Add("EMCT16S");
            //    comboBox1.Items.Add("EMCT23DN");
            //    comboBox1.Items.Add("EMCT23HRR");
            //    comboBox1.Items.Add("EMCT28CRS");
            //    comboBox1.Items.Add("EMCT28F");
            //    comboBox1.Items.Add("EMCT28GS");
            //    comboBox1.Items.Add("EMCT28GS(USA)");
            //    comboBox1.Items.Add("EMCT28H");
            //    comboBox1.Items.Add("EMCT28RN");
            //    comboBox1.Items.Add("EMCT41R");
            //    comboBox1.Items.Add("EMCT41RV1");
            //    label11.Text = "Lot No.:";
            //    label11.Visible = true;
            //    textBox4.Text = string.Empty;
            //    textBox4.Visible = true;
            //}
        //}

        //private void rbtn_Camera_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (this.rbtn_Camera.Checked)
        //    {
        //        comboBox1.Text = string.Empty;
        //        comboBox1.Items.Clear();
        //        //comboBox1.Items.Add("77320");
        //        //comboBox1.Items.Add("77560");
        //        //comboBox1.Items.Add("77650");
        //        // comboBox1.Items.Add("77670");
        //        comboBox1.Items.Add("77680");
        //        comboBox1.Items.Add("77690");
        //        // comboBox1.Items.Add("77750");
        //        comboBox1.Items.Add("77760");
        //        // comboBox1.Items.Add("77763");
        //        // comboBox1.Items.Add("77770");
        //        // comboBox1.Items.Add("77820");
        //        comboBox1.Items.Add("77840");
        //        comboBox1.Items.Add("77850");
        //        comboBox1.Items.Add("77860");
        //        //comboBox1.Items.Add("77870");
        //        comboBox1.Items.Add("77970");
        //        comboBox1.Items.Add("77980");
        //        comboBox1.Items.Add("78370");
        //        comboBox1.Items.Add("78380");
        //        comboBox1.Items.Add("78400");
        //        comboBox1.Items.Add("78420");

        //        label11.Text = "Ref No.:";
        //        label11.Visible = false;
        //        textBox4.Text = DateTime.Now.ToString("MMddyyyy");
        //        textBox4.Visible = false;
        //    }
        //}

        //private void rbtn_REX_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (this.rbtn_REX.Checked)
        //    {
        //        comboBox1.Text = string.Empty;
        //        comboBox1.Items.Clear();
        //        comboBox1.Items.Add("APH-32SV");
        //        comboBox1.Items.Add("APH-31SD");
        //        comboBox1.Items.Add("APH-40N");
        //    }
        //}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (this.rbtn_RT1.Checked)
            if (this.comboBox2.Text == "Camera")
            {
                comboBox1.Text = string.Empty;
                comboBox1.Items.Clear();
                //comboBox1.Items.Add("77320");
                //comboBox1.Items.Add("77560");
                //comboBox1.Items.Add("77650");
                // comboBox1.Items.Add("77670");
                comboBox1.Items.Add("77680");
                comboBox1.Items.Add("77690");
                // comboBox1.Items.Add("77750");
                comboBox1.Items.Add("77760");
                // comboBox1.Items.Add("77763");
                // comboBox1.Items.Add("77770");
                // comboBox1.Items.Add("77820");
                comboBox1.Items.Add("77840");
                comboBox1.Items.Add("77850");
                comboBox1.Items.Add("77860");
                //comboBox1.Items.Add("77870");
                comboBox1.Items.Add("77970");
                comboBox1.Items.Add("77980");
                comboBox1.Items.Add("78370");
                comboBox1.Items.Add("78380");
                comboBox1.Items.Add("78400");
                comboBox1.Items.Add("78420");

                label11.Text = "Ref No.:";
                label11.Visible = false;
                textBox4.Text = DateTime.Now.ToString("MMddyyyy");
                textBox4.Visible = false;
            }
            else
            {
                 try
                 {
                     using (var con = new SqlConnection(Program._CONNECTIONSTRING_KPSPRD))
                     {
                         #region query
                         string query = @"select MOD_Series from tbl_RINS_Model where MOD_Status = 'Active' and MOD_RINSType = '" + this.comboBox2.Text + "'";
                         #endregion

                         con.Open();
                         SqlCommand cmd = new SqlCommand(query, con);
                         SqlDataReader rdr = cmd.ExecuteReader();
                         comboBox1.Text = string.Empty;
                         comboBox1.Items.Clear();
                         
                         while (rdr.Read())
                         {
                             comboBox1.Items.Add(rdr["MOD_Series"].ToString());
                            // this.lblTotalNotAssignedEmployee.Text = rdr["Total"].ToString().Trim();
                         }
                         rdr.Close();
                         con.Close();
                     }
                 }
                 catch (Exception ex)
                 {
                 }
            }
            //else if (this.comboBox2.Text == "RT1")
            //{
            //    comboBox1.Text = string.Empty;
            //    comboBox1.Items.Clear();

            //    try
            //    {
            //        using (var con = new SqlConnection(Program._CONNECTIONSTRING_KPSPRD))
            //        {
            //            #region query
            //            string query = @"";
            //            #endregion

            //            con.Open();
            //            SqlCommand cmd = new SqlCommand(query, con);
            //            SqlDataReader rdr = cmd.ExecuteReader();
            //            while (rdr.Read())
            //            {
            //                this.lblTotalNotAssignedEmployee.Text = rdr["Total"].ToString().Trim();
            //            }
            //            rdr.Close();
            //            con.Close();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //    comboBox1.Items.Add("EMCC4");
            //    comboBox1.Items.Add("EMCT16CN");
            //    comboBox1.Items.Add("EMCT16ES");
            //    comboBox1.Items.Add("EMCT16FN");
            //    comboBox1.Items.Add("EMCT16S");
            //    comboBox1.Items.Add("EMCT23DN");
            //    comboBox1.Items.Add("EMCT23HRR");
            //    comboBox1.Items.Add("EMCT28CRS");
            //    comboBox1.Items.Add("EMCT28F");
            //    comboBox1.Items.Add("EMCT28GS");
            //    comboBox1.Items.Add("EMCT28GS(USA)");
            //    comboBox1.Items.Add("EMCT28H");
            //    comboBox1.Items.Add("EMCT28RN");
            //    comboBox1.Items.Add("EMCT41R");
            //    comboBox1.Items.Add("EMCT41RV1");
            //    label11.Text = "Lot No.:";
            //    label11.Visible = true;
            //    textBox4.Text = string.Empty;
            //    textBox4.Visible = true;
            //}
            //else if (this.comboBox2.Text == "REX")
            //{
            //    comboBox1.Text = string.Empty;
            //    comboBox1.Items.Clear();
            //    comboBox1.Items.Add("APH-32SV");
            //    comboBox1.Items.Add("APH-31SD");
            //    comboBox1.Items.Add("APH-40N");
            //}
            //else if (this.comboBox2.Text == "Charis")
            //{
            //    comboBox1.Text = string.Empty;
            //    comboBox1.Items.Clear();
            //    //comboBox1.Items.Add("D0CN5476");
            //    //comboBox1.Items.Add("APH-31SD");
            //    //comboBox1.Items.Add("APH-40N");
            //}
            //else if (this.comboBox2.Text == "FKS")
            //{
            //    comboBox1.Text = string.Empty;
            //    comboBox1.Items.Clear();
            //    //comboBox1.Items.Add("D0CN5476");
            //    //comboBox1.Items.Add("APH-31SD");
            //    //comboBox1.Items.Add("APH-40N");
            //}
        }
    }
}