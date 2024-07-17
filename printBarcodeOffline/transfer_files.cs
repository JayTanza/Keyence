using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Diagnostics;

namespace printBarcodeOffline
{
    public partial class transfer_files : Form
    {
        public transfer_files()
        {
            InitializeComponent();
        }

        private void transfer_files_Load(object sender, EventArgs e)
        {
            //_transfer();
            //CreateShortcut();
            backgroundWorker1.RunWorkerAsync(500);
        }

        private void CreateShortcut()
        {
          object shDesktop = (object)"Desktop";
          WshShell shell = new WshShell();
          string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Chipmounter Feeder Markings.lnk";
          IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
          shortcut.Description = "Developer: Rene Boy Constantino";
          shortcut.TargetPath = @"C:\keyenceOfflineDB\Print Feeder Markings.exe";
          shortcut.Save();
        }
        private void _transfer()
        {
            string sysFileName = "C:\\keyenceOfflineDB\\Print Feeder Markings.exe";
            string sourceDIR = Application.StartupPath.ToString() + "\\";
            string destinDIR = "C:\\keyenceOfflineDB\\";
            if (!System.IO.Directory.Exists(destinDIR))
            {
                System.IO.Directory.CreateDirectory(destinDIR);
                string[] files = System.IO.Directory.GetFiles(sourceDIR);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    string fileName = System.IO.Path.GetFileName(s);
                    string destFile = System.IO.Path.Combine(destinDIR, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }

                //Process.Start(sysFileName);
                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string sysFileName = "C:\\keyenceOfflineDB\\Print Feeder Markings.exe";
            string sourceDIR = Application.StartupPath.ToString() + "\\";
            string destinDIR = "C:\\keyenceOfflineDB\\";
            if (!System.IO.Directory.Exists(destinDIR))
            {
                System.IO.Directory.CreateDirectory(destinDIR);
                string[] files = System.IO.Directory.GetFiles(sourceDIR);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    string fileName = System.IO.Path.GetFileName(s);
                    string destFile = System.IO.Path.Combine(destinDIR, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }

                //Process.Start(sysFileName);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CreateShortcut();

            Application.Exit();
        }
    }
}
