namespace keyencePartsVerifier.MAINTENANCE
{
    partial class uploadExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uploadExcel));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_seeExcelFormat = new System.Windows.Forms.ToolStripButton();
            this.btn_browse = new System.Windows.Forms.ToolStripButton();
            this.btn_upload = new System.Windows.Forms.ToolStripButton();
            this.btn_seeErrors = new System.Windows.Forms.ToolStripButton();
            this.btn_transfer = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataExtracted = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataExtracted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Teal;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt_status,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 26);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 21);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // txt_status
            // 
            this.txt_status.ForeColor = System.Drawing.Color.White;
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(56, 21);
            this.txt_status.Text = "Ready!";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 20);
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_seeExcelFormat,
            this.btn_browse,
            this.btn_upload,
            this.btn_seeErrors,
            this.btn_transfer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(803, 31);
            this.toolStrip1.TabIndex = 73;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_seeExcelFormat
            // 
            this.btn_seeExcelFormat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_seeExcelFormat.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btn_seeExcelFormat.Image = ((System.Drawing.Image)(resources.GetObject("btn_seeExcelFormat.Image")));
            this.btn_seeExcelFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_seeExcelFormat.Margin = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.btn_seeExcelFormat.Name = "btn_seeExcelFormat";
            this.btn_seeExcelFormat.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.btn_seeExcelFormat.Size = new System.Drawing.Size(175, 24);
            this.btn_seeExcelFormat.Text = "See Excel Format/ Guide";
            this.btn_seeExcelFormat.Click += new System.EventHandler(this.btn_seeExcelFormat_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_browse.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btn_browse.Image = ((System.Drawing.Image)(resources.GetObject("btn_browse.Image")));
            this.btn_browse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_browse.Margin = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.btn_browse.Size = new System.Drawing.Size(106, 24);
            this.btn_browse.Text = "Browse Excel";
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_upload.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btn_upload.Image = ((System.Drawing.Image)(resources.GetObject("btn_upload.Image")));
            this.btn_upload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_upload.Margin = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.btn_upload.Size = new System.Drawing.Size(178, 24);
            this.btn_upload.Text = "Upload Parts Assignment";
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_seeErrors
            // 
            this.btn_seeErrors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_seeErrors.Enabled = false;
            this.btn_seeErrors.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btn_seeErrors.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_seeErrors.Image = ((System.Drawing.Image)(resources.GetObject("btn_seeErrors.Image")));
            this.btn_seeErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_seeErrors.Margin = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.btn_seeErrors.Name = "btn_seeErrors";
            this.btn_seeErrors.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.btn_seeErrors.Size = new System.Drawing.Size(91, 24);
            this.btn_seeErrors.Text = "See Errors";
            this.btn_seeErrors.Click += new System.EventHandler(this.btn_seeErrors_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_transfer.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btn_transfer.Image = ((System.Drawing.Image)(resources.GetObject("btn_transfer.Image")));
            this.btn_transfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_transfer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.btn_transfer.Size = new System.Drawing.Size(95, 24);
            this.btn_transfer.Text = "For History";
            this.btn_transfer.Visible = false;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dataExtracted
            // 
            this.dataExtracted.AllowUserToAddRows = false;
            this.dataExtracted.AllowUserToDeleteRows = false;
            this.dataExtracted.AllowUserToResizeColumns = false;
            this.dataExtracted.AllowUserToResizeRows = false;
            this.dataExtracted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataExtracted.BackgroundColor = System.Drawing.Color.White;
            this.dataExtracted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataExtracted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExtracted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataExtracted.Location = new System.Drawing.Point(0, 31);
            this.dataExtracted.Margin = new System.Windows.Forms.Padding(5);
            this.dataExtracted.Name = "dataExtracted";
            this.dataExtracted.ReadOnly = true;
            this.dataExtracted.Size = new System.Drawing.Size(803, 544);
            this.dataExtracted.TabIndex = 74;
            this.dataExtracted.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataExtracted_RowPostPaint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(803, 601);
            this.dataGridView1.TabIndex = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Location";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "L/R";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "PL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Parts Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Machine Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Table No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Line";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Model";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // uploadExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(803, 601);
            this.Controls.Add(this.dataExtracted);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uploadExcel";
            this.Text = "Upload Parts Assignment - Excel FIle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.uploadExcel_FormClosed);
            this.Load += new System.EventHandler(this.uploadExcel_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataExtracted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_status;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_seeExcelFormat;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripButton btn_browse;
        private System.Windows.Forms.ToolStripButton btn_upload;
        private System.Windows.Forms.ToolStripButton btn_seeErrors;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton btn_transfer;
        private System.Windows.Forms.DataGridView dataExtracted;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}