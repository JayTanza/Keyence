using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using keyencePartsVerifier.MODELS;
using System.Linq.Expressions;



namespace keyencePartsVerifier.TRANSACTION
{
    public partial class actualChecking : Form
    {
        public actualChecking()
        {
            InitializeComponent();
        }
        private transDataContext context = new transDataContext();
        private trans2DataContext context2 = new trans2DataContext();
        bool isLoaded = false;
        object tbl;
        object tbl2;
        private void actualChecking_Load(object sender, EventArgs e)
        {
            _customTimeFormats();
            //getCurrentPeriod();
            ////_loadModel();
            ////_loadLines();
            ////_loadTable();
            ////_loadMachine();
            ////_loadType();
            ////_loadParts();

            // _loadAllData();
            //this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width-50, Screen.PrimaryScreen.WorkingArea.Height-180);
            this.Icon = Properties.Resources.keyence;
        }

        private void _loadTransaction()
        {
            tbl = (from z in context.tbl_web2_transactions select z).OrderBy(m => m.transID);
            data.DataSource = tbl;
        }
        /*
        private void _loadModel()
        {
            tbl = (from z in context.tbl_web2_transactions select z.modelName.Trim()).Distinct().ToList();
            cb_model.DataSource = tbl;
        }
        private void _loadLines()
        {
            tbl = (from z in context.tbl_web2_transactions select z.lineName.Trim()).Distinct().ToList();
            cb_line.DataSource = tbl;
        }
        private void _loadTable()
        {
            tbl = (from z in context.tbl_web2_transactions select z.tableName.Trim()).Distinct().ToList();
            cb_table.DataSource = tbl;
        }
        private void _loadMachine()
        {
            tbl = (from z in context.tbl_web2_transactions select z.machineName.Trim()).Distinct().ToList();
            cb_machine.DataSource = tbl;
        }
        private void _loadType()
        {
            tbl = (from z in context.tbl_web2_transactions select z.type.Trim()).Distinct().ToList();
            
            cb_type.DataSource = tbl;
        }
        private void _loadParts()
        {
            tbl = (from z in context.tbl_web2_transactions select z.partsName.Trim()).Distinct().ToList();

            cb_parts.DataSource = tbl;
            isLoaded = true;
        }
          
        */
        private void _filterData(object sender1, EventArgs e1)
        {
            if (isLoaded)
            {
                tbl = (from z in context.tbl_web2_transactions
                       join x in context.tbl_web2_employees on z.inspector equals x.emp_id
                       where z.lineName.Contains(cb_line.Text) & z.machineName.Contains(cb_machine.Text.Trim()) & z.tableName.Contains(cb_table.Text.Trim()) & z.modelName.Contains(cb_model.Text.Trim()) &
                       z.type.Contains(cb_type.Text.Trim()) & z.partsName.Contains(cb_parts.Text.Trim()) & z.dt_trans <= Convert.ToDateTime(dtp_date.Value.ToShortDateString() + " " + dtp_time2.Value.ToShortTimeString()) &
                       z.dt_trans >= Convert.ToDateTime(dtp_date.Value.ToShortDateString() + " " + dtp_time1.Value.ToShortTimeString())
                       select new
                       {
                           z.transID,
                           z.lineName,
                           z.machineName,
                           z.tableName,
                           z.modelName,
                           z.feederLocation,
                           z.partsName,
                           z.inspector,
                           x.emp_name,
                           z.type,
                           z.remarks,
                           z.dt_trans,
                           SPL_lotNo = z.lotNo,//added by Jay Tanza 06/06/2024
                           z.lotNo,
                           z.period,
                           z.makerCode,
                           z.vendorCode,
                           z.vendorName,
                           z.datePrinted,
                           z.invoiceNo,
                           z.invoiceQty
                       }
                ).OrderBy(m => m.feederLocation).ThenByDescending(m => m.remarks);
                data.DataSource = tbl;

                _columnHeader();
            }
        }

        private void _loadAllData()
        {           
            //Old Version Code Structure
            //tbl = (from z in context.tbl_web2_transactions
            //       join x in context.tbl_web2_employees on z.inspector equals x.emp_id
            //       select new
            //       {
            //           z.transID,
            //           z.lineName,
            //           z.machineName,
            //           z.tableName,
            //           z.modelName,
            //           z.feederLocation,
            //           z.partsName,
            //           z.inspector,
            //           x.emp_name,
            //           z.type,
            //           z.remarks,
            //           z.dt_trans,
            //           SPL_lotNo = z.lotNo,//added by Jay Tanza 06/06/2024
            //           z.lotNo,
            //           z.period,
            //           z.makerCode,
            //           z.vendorCode,
            //           z.vendorName,
            //           z.datePrinted,
            //           z.invoiceNo,
            //           z.invoiceQty
            //       }
            //).OrderBy(m => m.dt_trans); // Add ToList() to materialize the query by Jay Tanza 11/06/2024
            //data.DataSource = tbl;
            //_columnHeader();

            //added and modify code structure by Jay Tanza 08/07/2024
            var tbl = (from z in context.tbl_web2_transactions
                       join x in context.tbl_web2_employees on z.inspector equals x.emp_id
                       where z.dt_trans.Value.Date >= this.dtpFrom.Value.Date && z.dt_trans.Value.Date <= this.dtpTo.Value.Date
                       select new
                       {
                           z.transID,
                           z.lineName,
                           z.machineName,
                           z.tableName,
                           modelName = z.modelName.Trim(),
                           z.feederLocation,
                           partsName = z.partsName.Trim(),
                           z.inspector,
                           x.emp_name,
                           z.type,
                           z.dt_trans,
                           z.lotNo,
                           z.period,
                           z.makerCode,
                           z.vendorCode,
                           z.vendorName,
                           z.datePrinted,
                           z.invoiceNo,
                           z.invoiceQty,
                           z.remarks
                       }).OrderBy(m => m.dt_trans).ToList();

            //added and modify code by Jay Tanza 08/07/2024
            var tbl2 = (from y in context.view_get_prodLotNo5s
                        select new
                        {
                            y.SPL_LotNo,
                            y.SPL_ModelNo,
                            y.SPL_Series,
                            SPL_Status = y.SPL_Status.Trim(),
                            CGITCH = y.CGITCH.Trim()
                        }).ToList();

            //Merge the results from tbl and tbl2 modify code by Jay Tanza 08/07/2024
            var mergedData = (from t in tbl
                              join u in tbl2 on t.partsName equals u.CGITCH
                              where u.SPL_Status == "Active"
                              select new
                              {
                                  t.transID,
                                  t.lineName,
                                  t.machineName,
                                  t.tableName,
                                  t.modelName,
                                  t.feederLocation,
                                  t.partsName,
                                  t.inspector,
                                  t.emp_name,
                                  t.type,
                                  t.dt_trans,
                                  SPL_ModelNo = u.SPL_ModelNo,
                                  SPL_Series = u.SPL_Series,
                                  SPL_LotNo = u.SPL_LotNo,
                                  SPL_Status = u.SPL_Status,
                                  //CGITCH = u.CGITCH, 
                                  t.lotNo,
                                  t.period,
                                  t.makerCode,
                                  t.vendorCode,
                                  t.vendorName,
                                  t.datePrinted,
                                  t.invoiceNo,
                                  t.invoiceQty,
                                  t.remarks
                              }).ToList();
            data.DataSource = mergedData;
            _columnHeader();
        }

        private void _columnHeader()        
        {
            if (data.DataSource != null)
            {
                if (r_all.Checked)
                {
                    data.Columns["transID"].Visible = false;
                    data.Columns["lineName"].HeaderText = "Line Name";
                    data.Columns["tableName"].HeaderText = "Table";
                    data.Columns["machineName"].HeaderText = "Machine";
                    data.Columns["modelName"].HeaderText = "Model";
                    data.Columns["inspector"].Visible = false;
                    data.Columns["emp_name"].HeaderText = "Inspector";
                    data.Columns["feederLocation"].HeaderText = "Feeder Location";
                    data.Columns["partsName"].HeaderText = "Parts (RINKS)";
                    data.Columns["dt_trans"].HeaderText = "Date & Time";
                    data.Columns["type"].HeaderText = "Scan Type";
                    data.Columns["SPL_ModelNo"].HeaderText = "Model No."; //added by Jay Tanza 09/07/2024
                    data.Columns["SPL_Series"].HeaderText = "Model Name"; //added by Jay Tanza 09/07/2024

                    data.Columns["SPL_LotNo"].HeaderText = "ProdLot No."; //added by Jay Tanza 06/06/2024/
                    data.Columns["SPL_Status"].HeaderText = "Status"; //added by Jay Tanza 09/07/2024//

                    data.Columns["SPL_LotNo"].HeaderText = "ProdLot No."; //added by Jay Tanza 06/06/2024

                    data.Columns["SPL_Status"].HeaderText = "Status"; //added by Jay Tanza 09/07/2024/

                    data.Columns["SPL_Status"].HeaderText = "Status"; //added by Jay Tanza 09/07/2024/

                    //data.Columns["CGITCH"].HeaderText = "Parts Names"; 
                    data.Columns["lotNo"].HeaderText = "Lot No.";
                    data.Columns["period"].HeaderText = "Period";
                    data.Columns["makerCode"].HeaderText = "Maker Code";
                    data.Columns["vendorCode"].HeaderText = "Vendor Code";
                    data.Columns["vendorName"].HeaderText = "Vendor Name";
                    data.Columns["datePrinted"].HeaderText = "Date Printed";
                    data.Columns["invoiceNo"].HeaderText = "Invoive Number";
                    data.Columns["invoiceQty"].HeaderText = "Invoive QTY";
                    data.Columns["type"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    data.Columns["dt_trans"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    data.Columns["remarks"].HeaderText = "Remarks";
                }
                if (r_filter.Checked)
                {
                    data.Columns["transID"].Visible = true;
                    data.Columns["lineName"].HeaderText = "Line Name";
                    data.Columns["tableName"].HeaderText = "Table";
                    data.Columns["machineName"].HeaderText = "Machine";
                    data.Columns["modelName"].HeaderText = "Model";
                    data.Columns["inspector"].Visible = false;
                    data.Columns["type"].HeaderText = "Scan Type";
                    data.Columns["feederLocation"].HeaderText = "Feeder Location";
                    data.Columns["partsName"].HeaderText = "Parts (RINKS)";
                    data.Columns["emp_name"].HeaderText = "Inspector";
                    data.Columns["dt_trans"].HeaderText = "Date & Time";
                    data.Columns["SPL_ModelNo"].HeaderText = "Model No."; //added by Jay Tanza 09/07/2024
                    data.Columns["SPL_Series"].HeaderText = "Model Name"; //added by Jay Tanza 09/07/2024
                    data.Columns["SPL_LotNo"].HeaderText = "ProdLot No."; //added by Jay Tanza 06/06/2024
                    data.Columns["SPL_Status"].HeaderText = "Status"; //added by Jay Tanza 08/07/2024
                    //data.Columns["CGITCH"].HeaderText = "Parts Names"; 
                    data.Columns["lotNo"].HeaderText = "Lot No.";
                    data.Columns["period"].HeaderText = "Period";
                    data.Columns["makerCode"].HeaderText = "Maker Code";
                    data.Columns["vendorCode"].HeaderText = "Vendor Code";
                    data.Columns["vendorName"].HeaderText = "Vendor Name";
                    data.Columns["datePrinted"].HeaderText = "Date Printed";
                    data.Columns["invoiceNo"].HeaderText = "Invoive Number";
                    data.Columns["invoiceQty"].HeaderText = "Invoive QTY";
                    data.Columns["type"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    data.Columns["dt_trans"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    data.Columns["remarks"].HeaderText = "Remarks";
                }
            }
        }
        //private void getCurrentPeriod()
        //{
        //    string period = (from z in context.tbl_sys_configs
        //               where z.ID == 1
        //               select z).Take(1).Single().sPeriod;
        //    this.Text = "Actual Checking Progress [Period: "+period.Trim()+"]";
        //}
        private void data_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            txt_status.Text = data.Rows.Count.ToString() + " row(s) found!";
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            r_filter.Checked = true;
        }

        private void r_filter_CheckedChanged(object sender, EventArgs e)
        {
            gb_filter.Enabled = r_filter.Checked == true ? true : false;
            if (r_filter.Checked)
            {
                cb_line.ResetText();
                cb_machine.ResetText();
                cb_model.ResetText();
                cb_table.ResetText();
                cb_type.ResetText();
                cb_parts.ResetText();
                _loadAllData();
            }
        }

        private void r_all_CheckedChanged(object sender, EventArgs e)
        {
            gb_all.Enabled = r_all.Checked == true ? true : false;
            if (r_all.Checked)
            {
                //  _loadAllData();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //added and modify code by Jay Tanza 08/07/2024
            var tbl = (from z in context.tbl_web2_transactions
                       join x in context.tbl_web2_employees on z.inspector equals x.emp_id
                       where z.dt_trans.Value.Date >= this.dtpFrom.Value.Date && z.dt_trans.Value.Date <= this.dtpTo.Value.Date
                       select new
                       {
                           z.transID,
                           z.lineName,
                           z.machineName,
                           z.tableName,
                           modelName = z.modelName.Trim(),
                           z.feederLocation,
                           partsName = z.partsName.Trim(),
                           z.inspector,
                           x.emp_name,
                           z.type,
                           z.dt_trans,
                           z.lotNo,
                           z.period,
                           z.makerCode,
                           z.vendorCode,
                           z.vendorName,
                           z.datePrinted,
                           z.invoiceNo,
                           z.invoiceQty,
                           z.remarks
                       }).OrderBy(m => m.dt_trans).ToList();

            //added and modify code by Jay Tanza 08/07/2024
            var tbl2 = (from y in context.view_get_prodLotNo5s
                        select new
                        {
                            y.SPL_LotNo,
                            y.SPL_ModelNo,
                            y.SPL_Series,
                            SPL_Status = y.SPL_Status.Trim(),
                            CGITCH = y.CGITCH.Trim()
                        }).ToList();

            //Merge the results from tbl and tbl2 modify code by Jay Tanza 08/07/2024
             var mergedData = (from t in tbl
                               join u in tbl2 on t.partsName equals u.CGITCH 
                               where u.SPL_Status == "Active"
                              select new
                              {
                                  t.transID,
                                  t.lineName,
                                  t.machineName,
                                  t.tableName,
                                  t.modelName,
                                  t.feederLocation,
                                  t.partsName,
                                  t.inspector,
                                  t.emp_name,
                                  t.type,
                                  t.dt_trans,
                                  SPL_ModelNo = u.SPL_ModelNo,
                                  SPL_Series = u.SPL_Series,
                                  SPL_LotNo = u.SPL_LotNo,
                                  SPL_Status = u.SPL_Status,
                                  //CGITCH = u.CGITCH, 
                                  t.lotNo,
                                  t.period,
                                  t.makerCode,
                                  t.vendorCode,
                                  t.vendorName,
                                  t.datePrinted,
                                  t.invoiceNo,
                                  t.invoiceQty,
                                  t.remarks
                              }).ToList();
            data.DataSource = mergedData;
            _columnHeader();
        }

        private void _customTimeFormats()
        {
            this.dtp_time1.CustomFormat = "hh:mm tt";
            this.dtp_time1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time1.ShowUpDown = true;
            this.dtp_time2.CustomFormat = "hh:mm tt";
            this.dtp_time2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time2.ShowUpDown = true;
            dtp_time1.Value = Convert.ToDateTime("12:00 AM");
        }
        private void data_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gclass._dgvRows(sender, e, this.Font);
        }

        private void data_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.ToString().Contains("ERROR"))
            {
                data.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.data.RowCount > 0)
                {
                    PBarcoma.ApplicationHelper.CrossPlatForm.ExportToExcel(this.data, "Parts Verifier");
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
