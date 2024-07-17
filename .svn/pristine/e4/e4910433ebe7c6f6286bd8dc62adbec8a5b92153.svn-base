using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace printBarcodeOffline
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (appTools.AlreadyRunning())
            {
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new printDatamatrixFeederMarkings());
        }
    }
}
