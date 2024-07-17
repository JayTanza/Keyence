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
    public partial class uploadExcelErrors : Form
    {
        public uploadExcelErrors()
        {
            InitializeComponent();
        }
        public uploadExcelErrors(DataTable _dt)
        {
            InitializeComponent();
            data.DataSource = _dt;
            this.Text = "Errors Found ("+_dt.Rows.Count.ToString()+")";
        }
        private void uploadExcelErrors_Load(object sender, EventArgs e)
        {

        }
    }
}
