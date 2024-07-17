using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier.TEST
{
    public partial class testImportExcelAndExtract : Form
    {
        public testImportExcelAndExtract()
        {
            InitializeComponent();
        }

        private void btn_importExcel_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Excel File (*.xls)|*.xlsx|CSV File (*.csv)|*.csv";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    string exFilenm = openFileDialog.FileName;
                    String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                "" + exFilenm + "" +
                                ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
                    OleDbConnection con = new OleDbConnection(constr);
                    con.Open();//-----OPen Connnection
                    DataTable Sheets = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    DataTable dt = new DataTable();
                    foreach (DataRow dr in Sheets.Rows)
                    {
                        string sht = dr[2].ToString();
                        OleDbCommand OleCmd = new OleDbCommand("SELECT * FROM [" + sht + "] ", con);
                        OleDbDataAdapter sda = new OleDbDataAdapter(OleCmd);

                        sda.Fill(dt);

                    }
                    con.Close();
                    data.DataSource = dt;


                    btn_extract_Click(sender,e);
                    //MessageBox.Show("Excel File imported! Please upload the data!", "Data Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Maybe excel file document is open or used by another application!\nOr\nExcel file is invalid, see excel format guide.\nAnd please try again!", "Error occured while importing data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btn_extract_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in data.Rows)
            {
                if (row.Cells[0].Value!=null)
                {
                    if (row.Cells[0].Value.ToString().Trim().Equals("*"))
                    {
                        string sLocation = row.Cells[1].Value.ToString().Trim();
                        string sLR = row.Cells[2].Value.ToString().Trim();
                        string sPL = row.Cells[3].Value.ToString().Trim();
                        string sPartsName = row.Cells[4].Value.ToString().Trim();
                        string sMachineName = row.Cells[5].Value.ToString().Trim();
                        string sTableName = row.Cells[6].Value.ToString().Trim();
                        string sLineName = row.Cells[7].Value.ToString().Trim();
                        if (!string.IsNullOrEmpty(sLocation) && !string.IsNullOrEmpty(sLR) &&
                            !string.IsNullOrEmpty(sPartsName) && !string.IsNullOrEmpty(sMachineName) &&
                            !string.IsNullOrEmpty(sTableName) && !string.IsNullOrEmpty(sLineName))
                        {
                            dataExtracted.Rows.Add(sLocation,
                                                sLR,
                                                sPL,
                                                sPartsName,
                                                sMachineName,
                                                sTableName,
                                                sLineName);

                        }
                    }
                }
            }

            tabControl1.SelectTab(tabPage2);

            if (dataExtracted.Rows.Count == 0)
            {
                MessageBox.Show("Cannnot extract parts assignment from the excel!\nPlease call APC for assistance!", "Cannot extract data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void testImportExcelAndExtract_Load(object sender, EventArgs e)
        {

        }
    }
}
