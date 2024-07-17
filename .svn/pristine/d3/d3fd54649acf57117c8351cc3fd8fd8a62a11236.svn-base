using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DataMatrix.net;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace printBarcodeOffline
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
                using (var con = new OleDbConnection(printDatamatrixFeederMarkings.conString))
                {
                    OleDbCommand cmdD = new OleDbCommand("DELETE FROM tbl_barcode", con);
                    con.Open();
                    cmdD.ExecuteNonQuery();
                    con.Close();
                }
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

        public void QRCode(string header, string barcodeValue, string imageFileName, int qrCodeScale, int order_id)
        {
            ///qrCodeScale defualt = 4
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();

            //Verify Barcode Folder
            VerifyBarcodeFolder();

            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            qrCodeEncoder.QRCodeScale = qrCodeScale;
            qrCodeEncoder.QRCodeVersion = 2;//3; //10

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
            //insert2DB(header, barcodeValue, file_path, computerName, order_id);
        }
        private void insert2DB(int order_by, string value, string filename)
        {
            try
            {
                using (var con = new OleDbConnection(printDatamatrixFeederMarkings.conString))
                {
                    OleDbCommand cmdI = new OleDbCommand("INSERT INTO tbl_barcode(order_by, barcodeValue, barcodeFilename, compName) " +
                        "VALUES(@o, @v, @f, @c)", con);
                    cmdI.Parameters.AddWithValue("@o", order_by);
                    cmdI.Parameters.AddWithValue("@v", value);
                    cmdI.Parameters.AddWithValue("@f", filename);
                    cmdI.Parameters.AddWithValue("@c", computerName);
                    cmdI.Parameters.AddWithValue("@dt", DateTime.Now.ToString());
                    con.Open();
                    cmdI.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on inserting barcode. Details: " + ex.Message, "Error on insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        qr_feederMarkings2 cryRpt;
        public void printDataMatrix()
        {
           cryRpt  = new qr_feederMarkings2();
            //provides properties for retrieving and setting table connectivity options
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo(); //for connecting to database
            Tables CrTables;//contains onjects for every table in report

            ParameterValues crParameterValues = new ParameterValues();//contains value for every paramter field in the report
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            //provides properties for retrieving and setting discrete value parameters

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            //crystalReportViewer1.ReportSource = cryRpt;
            cryRpt.PrintToPrinter(0, true, 0, 0);

            //return cryRpt;
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
        public void generateDataMatrix(int order, string barcodeValue)
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

            insert2DB(order,barcodeValue,file_path );
        }
        #endregion
    }
}
