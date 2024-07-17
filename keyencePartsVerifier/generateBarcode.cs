using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DataMatrix.net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace keyencePartsVerifier
{
    class generateBarcode
    {
        string computerName = System.Environment.MachineName.ToString().Trim();
        string gsApplicationPath = Application.StartupPath;
        PictureBox pictureBoxBarcode = new PictureBox();
        //TextBox txtEncoded = new TextBox();
        Image image = null;
        Color BarcodeForeColor = System.Drawing.Color.Black;
        Color BarcodeBackColor = System.Drawing.Color.White;

        public void VerifyBarcodeFolder()
        {
            if (!Directory.Exists(gsApplicationPath + "\\Barcode"))
                Directory.CreateDirectory(gsApplicationPath + "\\Barcode");
        }
        public void Reset()
        {
            try
            {
                SqlCommand cmdD = new SqlCommand("DELETE FROM tbl_web_barcode_table WHERE compName=@c", gclass.con);
                gclass.con.Open();
                cmdD.Parameters.AddWithValue("@c", computerName);
                cmdD.ExecuteNonQuery();
                gclass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on deleting barcode table! Details: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.IO.DirectoryInfo di = new DirectoryInfo(gsApplicationPath + "\\Barcode");

            if (Directory.Exists(gsApplicationPath + "\\Barcode"))
            {
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }
        }
        #region Preview Barcode

        //public void QRCodePreview(string barcodeValue, PictureBox pictureBoxPreview, int qrCodeScale)
        //{
        //    ///qrCodeScale defualt = 4
        //    QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();

        //    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
        //    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
        //    qrCodeEncoder.QRCodeScale = qrCodeScale;
        //    qrCodeEncoder.QRCodeVersion = 7;

        //    image = qrCodeEncoder.Encode(barcodeValue);
        //    pictureBoxPreview.Image = image;
        //    pictureBoxPreview.Width = pictureBoxPreview.Image.Width;
        //    pictureBoxPreview.Height = pictureBoxPreview.Image.Height;
        //}

        //public void Code128Preview(string barcodeValue, PictureBox pictureBoxPreview, int barcodeWidth, int barcodeHeight, bool bolIncludeLabelText)
        //{
        //    try
        //    {
        //        BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
        //        BarcodeLib.AlignmentPositions AlignmentPosition = BarcodeLib.AlignmentPositions.CENTER;
        //        BarcodeLib.TYPE BarcodeType = BarcodeLib.TYPE.CODE128;

        //        barcode.IncludeLabel = bolIncludeLabelText;// true or false
        //        barcode.Alignment = AlignmentPosition;
        //        barcode.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), "RotateNoneFlipNone", true);
        //        barcode.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;
        //        //Encoding barcode
        //        pictureBoxPreview.Image = barcode.Encode(BarcodeType, barcodeValue, BarcodeForeColor, BarcodeBackColor, barcodeWidth, barcodeHeight);
        //        pictureBoxPreview.Width = pictureBoxPreview.Image.Width;
        //        pictureBoxPreview.Height = pictureBoxPreview.Image.Height;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error Occured",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //        return;
        //    }
        //}

        #endregion

        public void QRCode(string header, string barcodeValue, string imageFileName, int qrCodeScale, int order_id)
        {
            ///qrCodeScale defualt = 4
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();

            //Verify Barcode Folder
            VerifyBarcodeFolder();

            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            qrCodeEncoder.QRCodeScale = qrCodeScale;
            //qrCodeEncoder.QRCodeVersion = 2;//3; //10
            qrCodeEncoder.QRCodeVersion = 3; //10;

            image = qrCodeEncoder.Encode(barcodeValue);
            pictureBoxBarcode.Image = image;
            pictureBoxBarcode.Width = pictureBoxBarcode.Image.Width;
            pictureBoxBarcode.Height = pictureBoxBarcode.Image.Height;

            string file_path = gsApplicationPath + @"\Barcode\" + imageFileName + ".jpg";
            try
            {

                pictureBoxBarcode.Image.Save(file_path, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error Occured",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            insert2DB(header, barcodeValue, file_path, computerName, order_id);
        }
        private void insert2DB(string header, string value, string filename, string compname, int order_id)
        {
            try
            {
                SqlCommand cmdI = new SqlCommand("INSERT INTO tbl_web_barcode_table(barcodeHeader, barcodeValue, barcodeFilename, compName, datetimeInsert, order_id) " +
                    "VALUES(@h, @v, @f, @c, @dt, @order)", gclass.con);
                cmdI.Parameters.AddWithValue("@h", header);
                cmdI.Parameters.AddWithValue("@v", value);
                cmdI.Parameters.AddWithValue("@f", filename);
                cmdI.Parameters.AddWithValue("@c", compname);
                cmdI.Parameters.AddWithValue("@dt", DateTime.Now.ToString());
                cmdI.Parameters.AddWithValue("@order", order_id);
                gclass.con.Open();
                cmdI.ExecuteNonQuery();
                gclass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on inserting barcode. Details: " + ex.Message, "Error on insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void printBarcode(int noCopies)
        {
            //REPORT.qr_mini cryRpt = new REPORT.qr_mini();
            REPORT.qr cryRpt = new REPORT.qr();
            //provides properties for retrieving and setting table connectivity options
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo(); //for connecting to database
            Tables CrTables;//contains onjects for every table in report

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition; //parameter field in the report
            ParameterValues crParameterValues = new ParameterValues();//contains value for every paramter field in the report
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            //provides properties for retrieving and setting discrete value parameters

            //Parameter 1   
            crParameterDiscreteValue.Value = computerName;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["@compName"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);//applies the current value to specified field of report

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            try
            {
                //Database connection
                crConnectionInfo.DatabaseName = "handHeldDB";
                crConnectionInfo.ServerName = "KPSPRD";
                crConnectionInfo.UserID = "sa";
                crConnectionInfo.Password = "saPRD2016cebu";
            }
            catch
            {
                MessageBox.Show("Unable to connect to the database !", "Error on " + MethodBase.GetCurrentMethod().Name + "()",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            //crystalReportViewer1.ReportSource = cryRpt;
            cryRpt.PrintToPrinter(noCopies, true, 0, 0);
        }
        public void printBarcode_model(int noCopies)
        {
            REPORT.qr_model2 cryRpt = new REPORT.qr_model2();
            //provides properties for retrieving and setting table connectivity options
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo(); //for connecting to database
            Tables CrTables;//contains onjects for every table in report

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition; //parameter field in the report
            ParameterValues crParameterValues = new ParameterValues();//contains value for every paramter field in the report
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            //provides properties for retrieving and setting discrete value parameters

            //Parameter 1   
            crParameterDiscreteValue.Value = computerName;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["@compName"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);//applies the current value to specified field of report

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            try
            {
                //Database connection
                crConnectionInfo.DatabaseName = "handHeldDB";
                crConnectionInfo.ServerName = "KPSPRD";
                crConnectionInfo.UserID = "sa";
                crConnectionInfo.Password = "saPRD2016cebu";
            }
            catch
            {
                MessageBox.Show("Unable to connect to the database !", "Error on " + MethodBase.GetCurrentMethod().Name + "()",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            //crystalReportViewer1.ReportSource = cryRpt;
            cryRpt.PrintToPrinter(noCopies, true, 0, 0);
        }
        public void printBarcode_lineMachineTable(int noCopies)
        {
            REPORT.qr_lineMachineTable cryRpt = new REPORT.qr_lineMachineTable();
            //provides properties for retrieving and setting table connectivity options
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo(); //for connecting to database
            Tables CrTables;//contains onjects for every table in report

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition; //parameter field in the report
            ParameterValues crParameterValues = new ParameterValues();//contains value for every paramter field in the report
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            //provides properties for retrieving and setting discrete value parameters

            //Parameter 1   
            crParameterDiscreteValue.Value = computerName;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["@compName"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);//applies the current value to specified field of report

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            try
            {
                //Database connection
                crConnectionInfo.DatabaseName = "handHeldDB";
                crConnectionInfo.ServerName = "KPSPRD";
                crConnectionInfo.UserID = "sa";
                crConnectionInfo.Password = "saPRD2016cebu";
            }
            catch
            {
                MessageBox.Show("Unable to connect to the database !", "Error on " + MethodBase.GetCurrentMethod().Name + "()",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            //crystalReportViewer1.ReportSource = cryRpt;
            cryRpt.PrintToPrinter(noCopies, true, 0, 0);
        }
        public void printBarcode_feederLocation(int noCopies)
        {
            REPORT.qr_feederLocation cryRpt = new REPORT.qr_feederLocation();
            //provides properties for retrieving and setting table connectivity options
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo(); //for connecting to database
            Tables CrTables;//contains onjects for every table in report

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition; //parameter field in the report
            ParameterValues crParameterValues = new ParameterValues();//contains value for every paramter field in the report
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            //provides properties for retrieving and setting discrete value parameters

            //Parameter 1   
            crParameterDiscreteValue.Value = computerName;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["@compName"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);//applies the current value to specified field of report

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            try
            {
                //Database connection
                crConnectionInfo.DatabaseName = "handHeldDB";
                crConnectionInfo.ServerName = "KPSPRD";
                crConnectionInfo.UserID = "sa";
                crConnectionInfo.Password = "saPRD2016cebu";
            }
            catch
            {
                MessageBox.Show("Unable to connect to the database !", "Error on " + MethodBase.GetCurrentMethod().Name + "()",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            //crystalReportViewer1.ReportSource = cryRpt;
            cryRpt.PrintToPrinter(noCopies, true, 0, 0);
        }
        public void printBarcode_all(int noCopies)
        {
            //REPORT.qr_all cryRpt = new REPORT.qr_all();
            ////provides properties for retrieving and setting table connectivity options
            //TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            //TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            //ConnectionInfo crConnectionInfo = new ConnectionInfo(); //for connecting to database
            //Tables CrTables;//contains onjects for every table in report

            //ParameterFieldDefinitions crParameterFieldDefinitions;
            //ParameterFieldDefinition crParameterFieldDefinition; //parameter field in the report
            //ParameterValues crParameterValues = new ParameterValues();//contains value for every paramter field in the report
            //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            ////provides properties for retrieving and setting discrete value parameters

            ////Parameter 1   
            //crParameterDiscreteValue.Value = computerName;
            //crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["@compName"];
            //crParameterValues = crParameterFieldDefinition.CurrentValues;

            //crParameterValues.Clear();
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);//applies the current value to specified field of report

            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            //try
            //{
            //    //Database connection
            //    crConnectionInfo.DatabaseName = "handHeldDB";
            //    crConnectionInfo.ServerName = "KPSPRD";
            //    crConnectionInfo.UserID = "sa";
            //    crConnectionInfo.Password = "saPRD2016cebu";
            //}
            //catch
            //{
            //    MessageBox.Show("Unable to connect to the database !", "Error on " + MethodBase.GetCurrentMethod().Name + "()",
            //           MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //    return;
            //}

            //CrTables = cryRpt.Database.Tables;
            //foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            //{
            //    crtableLogoninfo = CrTable.LogOnInfo;
            //    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
            //    CrTable.ApplyLogOnInfo(crtableLogoninfo);
            //}

            ////crystalReportViewer1.ReportSource = cryRpt;
            //cryRpt.PrintToPrinter(noCopies, true, 0, 0);
        }
        public static bool SetDefaultPrinter(string defaultPrinter)
        {
            bool status = false;
            using (ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer"))
            {
                using (ManagementObjectCollection objectCollection = objectSearcher.Get())
                {
                    foreach (ManagementObject mo in objectCollection)
                    {
                        if (string.Compare(mo["Name"].ToString(), defaultPrinter, true) == 0)
                        {
                            mo.InvokeMethod("SetDefaultPrinter", null, null);
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }
            }
            return status;
        }
        #region code128 & ean13
        //public void Code128(string barcodeValue, string imageFileName, int barcodeWidth, int barcodeHeight, bool bolIncludeLabelText)
        //{
        //    string FilePath = null;

        //    //Verify Barcode Folder
        //    VerifyBarcodeFolder();

        //    try
        //    {
        //        BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
        //        BarcodeLib.AlignmentPositions AlignmentPosition = BarcodeLib.AlignmentPositions.CENTER;
        //        BarcodeLib.TYPE BarcodeType = BarcodeLib.TYPE.CODE128;

        //        barcode.IncludeLabel = bolIncludeLabelText;// true or false
        //        barcode.Alignment = AlignmentPosition;
        //        barcode.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), "RotateNoneFlipNone", true);
        //        barcode.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;

        //        //Encoding barcode
        //        pictureBoxBarcode.Image = barcode.Encode(BarcodeType, barcodeValue, BarcodeForeColor, BarcodeBackColor, barcodeWidth, barcodeHeight);
        //        //MessageBox.Show(barcodeWidth.ToString() + " " + barcodeHeight.ToString(), "Dimension");
        //        pictureBoxBarcode.Width = pictureBoxBarcode.Image.Width;
        //        pictureBoxBarcode.Height = pictureBoxBarcode.Image.Height;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error Occured Code-128",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //        return;
        //    }

        //    try
        //    {
        //        //FilePath = gsApplicationPath + @"\Barcode\" + imageFileName + ".jpg";
        //        //pictureBoxBarcode.Image.Save(FilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        FilePath = gsApplicationPath + @"\Barcode\" + imageFileName + ".bmp";
        //        pictureBoxBarcode.Image.Save(FilePath, System.Drawing.Imaging.ImageFormat.Bmp);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error Occured Code-128",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //        return;
        //    }
        //}

        //public void EAN13(string barcodeValue, string imageFileName, int barcodeWidth, int barcodeHeight, bool bolIncludeLabelText)
        //{
        //    string FilePath = null;

        //    //Verify Barcode Folder
        //    VerifyBarcodeFolder();

        //    try
        //    {
        //        BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
        //        BarcodeLib.AlignmentPositions AlignmentPosition = BarcodeLib.AlignmentPositions.CENTER;
        //        BarcodeLib.TYPE BarcodeType = BarcodeLib.TYPE.EAN13;

        //        barcode.IncludeLabel = bolIncludeLabelText;// true or false
        //        barcode.Alignment = AlignmentPosition;
        //        barcode.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), "RotateNoneFlipNone", true);
        //        barcode.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;

        //        //Encoding barcode
        //        pictureBoxBarcode.Image = barcode.Encode(BarcodeType, barcodeValue, BarcodeForeColor, BarcodeBackColor, barcodeWidth, barcodeHeight);
        //        //MessageBox.Show(barcodeValue, "Barcode Value");
        //        pictureBoxBarcode.Width = pictureBoxBarcode.Image.Width;
        //        pictureBoxBarcode.Height = pictureBoxBarcode.Image.Height;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error Occured EAN-13",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //        return;
        //    }

        //    try
        //    {
        //        //FilePath = gsApplicationPath + @"\Barcode\" + imageFileName + ".jpg";
        //        //pictureBoxBarcode.Image.Save(FilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        FilePath = gsApplicationPath + @"\Barcode\" + imageFileName + ".bmp";
        //        pictureBoxBarcode.Image.Save(FilePath, System.Drawing.Imaging.ImageFormat.Bmp);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error Occured EAN-13",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //        return;
        //    }
        //}

        #endregion


        #region dataMatrix
        public void generateDataMatrix(string barcodeValue)
        {
            string imageFile = barcodeValue;
            string file_path = gsApplicationPath + @"\Barcode\" + imageFile + ".jpg";
            //string gs1Code = txthistorym100.Text;
            DmtxImageEncoder encoder = new DmtxImageEncoder();
            DmtxImageEncoderOptions options = new DmtxImageEncoderOptions();
            options.ModuleSize = 10;
            options.MarginSize = 10;
            options.BackColor = Color.White;
            options.ForeColor = Color.Black;
            options.Scheme = DmtxScheme.DmtxSchemeAsciiGS1;
            Bitmap encodedBitmap = encoder.EncodeImage(barcodeValue, options);
            encodedBitmap.Save(file_path, System.Drawing.Imaging.ImageFormat.Png);
        }
        #endregion
    }
}
