using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier.INQUIRY
{
    public partial class scanner : Form
    {
        public scanner()
        {
            InitializeComponent();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            metroProgressBar1.Visible = true;
            p_loading.Visible = true;
            txt_status.Text = "Navigating "+webBrowser1.Url.ToString()+". . .";
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            metroProgressBar1.Visible = false;
            p_loading.Visible = false;
            txt_status.Text = "URL: " + webBrowser1.Url.ToString() ;
        }

        private void scanner_Load(object sender, EventArgs e)
        {

        }
    }
}
