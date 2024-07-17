using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keyencePartsVerifier
{
    public partial class logon : Form
    {
        public logon()
        {
            InitializeComponent();
        }

        private bool isClose = false;

        private void btn_close_Click(object sender, EventArgs e)
        {
           DialogResult d = MessageBox.Show("Are you sure to exit Chipmounter Parts Verifier System?", "Quit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (d == DialogResult.Yes)
           {
               isClose = true;
               Application.Exit();
           }
        }

        private void btn_login_Click(object sender, EventArgs e) // Event handler for the login button click
        {
            if (_verifyUser(txt_username.Text.Trim(), txt_password.Text.Trim())) // Check if the user credentials are valid
            {
                _loadUser(txt_username.Text.Trim(), txt_password.Text.Trim()); // Load the user data if credentials are valid
            }
            else // If the credentials are not valid
            {
                MessageBox.Show("Wrong username or password! \nPlease try again!", "User not found!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                txt_password.ResetText(); // Clear the password field
                txt_password.Focus(); // Set focus to the password field
            }
        }

        private bool _verifyUser(string user, string pass)
        {
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, "pri.local"))
            {
                // validate the credentials
                bool isValid = pc.ValidateCredentials(user, pass);

                if (isValid == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        private void _loadUser(string uname, string pass) // Method to load user data
        {
            //just a rather code of noobs
            //try
            //{
            //    SqlCommand cmd2 = new SqlCommand(@"Select * from view_get_prodLotNo2", gclass.con);
            //    gclass.con.Open();
            //    SqlDataReader dr2 = cmd2.ExecuteReader();

            //    while (dr2.Read()) {
            //        gclass.SPL_LotNo = dr2["SPL_LotNo"].ToString().Trim();
            //        gclass.modelName = dr2["modelName"].ToString().Trim();
            //        gclass.SPL_Series = dr2["SPL_Series"].ToString().Trim();
            //        gclass.transID = dr2["transID"].ToString().Trim();
            //    }
            //    dr2.Close();
            //    gclass.con.Close();

            //}
            //catch
            //{

            //}
            //finally { 
                
            //}

           
            try // Try block to handle exceptions
            {
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM tbl_users_rights WHERE username=@username", gclass.con); // Create SQL command to select user rights
                cmd.Parameters.AddWithValue("@username", uname); // Add username parameter to the command
                gclass.con.Open(); // Open the database connection
                SqlDataReader dr = cmd.ExecuteReader(); // Execute the command and get the data reader

                while (dr.Read()) // Loop through the data reader
                {
                    gclass.gs_lname = dr["lastname"].ToString().Trim(); // Set last name from the data reader
                    gclass.gs_fname = dr["firstname"].ToString().Trim(); // Set first name from the data reader
                    gclass.gs_funame = dr["firstname"].ToString().Trim() + " " + dr["lastname"].ToString().Trim(); // Set full name from the data reader
                    gclass.gs_user = dr["username"].ToString().Trim(); // Set username from the data reader
                    gclass.gs_pass = dr["password"].ToString().Trim(); // Set password from the data reader
                }

                dr.Close(); // Close the data reader
                gclass.con.Close(); // Close the database connection

                if (txt_username.Text.Trim() == gclass.gs_user) // Check if the entered username matches the loaded username
                {
                    txt_username.ReadOnly = true; // Set the username field to read-only
                    txt_password.ReadOnly = true; // Set the password field to read-only
                    this.UseWaitCursor = true; // Change cursor to waiting cursor
                    if (!bw_logon.IsBusy) // Check if the background worker is not busy
                    {
                        bw_logon.RunWorkerAsync(500); // Run the background worker asynchronously with a 500ms delay
                    }
                }
                else // If the entered username does not match the loaded username
                {
                    MessageBox.Show("Sorry " + txt_username.Text.Trim() + ", you are not registered to use\t Parts Parts Verifier System.\n\nPlease contact the administrator!", "Unregistered User!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                    txt_username.ResetText(); // Clear the username field
                    txt_password.ResetText(); // Clear the password field
                    txt_username.Focus(); // Set focus to the username field
                }
            }
            catch (SqlException ex) // Catch block to handle SQL exceptions
            {
                MessageBox.Show(ex.Message, "Error on loading user details!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message with exception details
                return; // Exit the method
            }
            finally // Finally block to execute cleanup code
            {
                if (gclass.con.State == ConnectionState.Open) // Check if the database connection is still open
                {
                    gclass.con.Close(); // Close the database connection
                }
                GC.Collect(); // Force garbage collection
            }
        }

        private void logon_Load(object sender, EventArgs e)
        {
            txt_username.Text = System.Environment.UserName.Trim();
            txt_password.Focus();
            if (this.txt_username.Text == "g192123")
            {
                txt_username.Text = "g192123";
                txt_password.Text = "Gracebooc23!";
            }
        }
        private void bw_logon_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for(int i=0;i<=100;i++)
            {
                worker.ReportProgress(i);
                System.Threading.Thread.Sleep(10);
            }
        }

        private void bw_logon_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            metroProgressBar1.Minimum = 0;
            metroProgressBar1.Maximum = 100;
            metroProgressBar1.Value = e.ProgressPercentage;
        }

        private void bw_logon_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isClose = true;
            this.Close();
        }

        private void logon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isClose)
            {
                e.Cancel = true;
            }
        }
    }
}
