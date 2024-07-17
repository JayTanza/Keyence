using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier
{
    public class gclass
    {
        public static SqlConnection con = new SqlConnection("Data Source=KPSPRD; Initial Catalog=handHeldDB; User ID=sa; Password=saPRD2016cebu");
        public static SqlConnection con_apps = new SqlConnection("Data Source=KPSAPPS; Initial Catalog=RINKS21; User ID=sa; Password=sa02max");

        public static void _dgvRows(object sender, DataGridViewRowPostPaintEventArgs e, Font fnt)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, fnt, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        public static string SPL_LotNo { get; set; }
        public static string modelName { get; set; }
        public static string SPL_Series { get; set; }
        public static string transID { get; set; }

        public static string gs_user { get; set; }
        public static string gs_pass { get; set; }
        public static string gs_lname { get; set; }
        public static string gs_fname { get; set; }
        public static string gs_funame { get; set; }
        public static Image gim_image { get; set; }


        public static string LINE_1 = "Line 1";
        public static string LINE_2 = "Line 2";
        public static string LINE_3 = "Line 3";
        public static string LINE_4 = "Line 4";

        public static string TABLE_1 = "Table 1";
        public static string TABLE_2 = "Table 2";
        public static string TABLE_3 = "Table 3";
        public static string TABLE_4 = "Table 4";

        public static string[] tables_2 = { TABLE_1.ToUpper(), TABLE_2.ToUpper() };
        public static string[] tables_4 = { TABLE_1.ToUpper(), TABLE_2.ToUpper(), TABLE_3.ToUpper(), TABLE_4.ToUpper() };


        public static string CM602_1 = "CM602_1";
        public static string CM402_2 = "CM402_2";
        public static string DT401_3 = "DT401_3";
        public static string CM402_1 = "CM402_1";
        public static string CM201_1 = "CM201_1";
        public static string CM212_2 = "CM212_2";


        public static string[] LINE_1_MACHINE = { CM602_1, CM402_2, DT401_3 };
        public static string[] LINE_2_MACHINE = { CM402_1, CM402_2, DT401_3 };
        public static string[] LINE_3_MACHINE = { CM402_1, CM402_2, DT401_3 };
        public static string[] LINE_4_MACHINE = { CM201_1, CM212_2 };
    }
}