namespace keyencePartsVerifier.TRANSACTION
{
    partial class transTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.data_batch = new System.Windows.Forms.DataGridView();
            this.toolstrip_batch = new System.Windows.Forms.ToolStrip();
            this.btn_reload_batch = new System.Windows.Forms.ToolStripButton();
            this.data_details = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_details_selectedBatch = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_delete = new System.Windows.Forms.ToolStripButton();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_batch)).BeginInit();
            this.toolstrip_batch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_details)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Keyence Transaction Table";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Teal;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Light", 1F);
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(835, 2);
            this.textBox2.TabIndex = 38;
            this.textBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.data_batch);
            this.splitContainer1.Panel1.Controls.Add(this.toolstrip_batch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.data_details);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(835, 515);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // data_batch
            // 
            this.data_batch.AllowUserToAddRows = false;
            this.data_batch.AllowUserToDeleteRows = false;
            this.data_batch.AllowUserToResizeRows = false;
            this.data_batch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_batch.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.data_batch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_batch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_batch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_batch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data_batch.ColumnHeadersHeight = 30;
            this.data_batch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_batch.DefaultCellStyle = dataGridViewCellStyle6;
            this.data_batch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_batch.EnableHeadersVisualStyles = false;
            this.data_batch.Location = new System.Drawing.Point(0, 31);
            this.data_batch.MultiSelect = false;
            this.data_batch.Name = "data_batch";
            this.data_batch.ReadOnly = true;
            this.data_batch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_batch.RowTemplate.Height = 30;
            this.data_batch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_batch.Size = new System.Drawing.Size(242, 484);
            this.data_batch.TabIndex = 75;
            this.data_batch.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.data_batch_RowPostPaint);
            this.data_batch.SelectionChanged += new System.EventHandler(this.data_batch_SelectionChanged);
            // 
            // toolstrip_batch
            // 
            this.toolstrip_batch.BackColor = System.Drawing.Color.Teal;
            this.toolstrip_batch.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.toolstrip_batch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstrip_batch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reload_batch});
            this.toolstrip_batch.Location = new System.Drawing.Point(0, 0);
            this.toolstrip_batch.Margin = new System.Windows.Forms.Padding(1);
            this.toolstrip_batch.Name = "toolstrip_batch";
            this.toolstrip_batch.Size = new System.Drawing.Size(242, 31);
            this.toolstrip_batch.TabIndex = 74;
            this.toolstrip_batch.Text = "toolStrip2";
            // 
            // btn_reload_batch
            // 
            this.btn_reload_batch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_reload_batch.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btn_reload_batch.Image = ((System.Drawing.Image)(resources.GetObject("btn_reload_batch.Image")));
            this.btn_reload_batch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reload_batch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.btn_reload_batch.Name = "btn_reload_batch";
            this.btn_reload_batch.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.btn_reload_batch.Size = new System.Drawing.Size(108, 24);
            this.btn_reload_batch.Text = "Reload Batch";
            this.btn_reload_batch.Click += new System.EventHandler(this.btn_reload_batch_Click);
            // 
            // data_details
            // 
            this.data_details.AllowUserToAddRows = false;
            this.data_details.AllowUserToDeleteRows = false;
            this.data_details.AllowUserToResizeRows = false;
            this.data_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_details.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.data_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_details.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.data_details.ColumnHeadersHeight = 30;
            this.data_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_details.DefaultCellStyle = dataGridViewCellStyle8;
            this.data_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_details.EnableHeadersVisualStyles = false;
            this.data_details.Location = new System.Drawing.Point(0, 31);
            this.data_details.Name = "data_details";
            this.data_details.ReadOnly = true;
            this.data_details.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_details.RowTemplate.Height = 30;
            this.data_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_details.Size = new System.Drawing.Size(592, 458);
            this.data_details.TabIndex = 76;
            this.data_details.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.data_details_RowPostPaint);
            this.data_details.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.data_details_RowStateChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Teal;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt_details_selectedBatch,
            this.toolStripStatusLabel4,
            this.txt_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(592, 26);
            this.statusStrip1.TabIndex = 42;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 21);
            this.toolStripStatusLabel1.Text = "Batch: ";
            // 
            // txt_details_selectedBatch
            // 
            this.txt_details_selectedBatch.ForeColor = System.Drawing.Color.White;
            this.txt_details_selectedBatch.Name = "txt_details_selectedBatch";
            this.txt_details_selectedBatch.Size = new System.Drawing.Size(105, 21);
            this.txt_details_selectedBatch.Text = "None selected";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(22, 21);
            this.toolStripStatusLabel4.Text = " | ";
            // 
            // txt_status
            // 
            this.txt_status.ForeColor = System.Drawing.Color.White;
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(102, 21);
            this.txt_status.Text = "0 rows found!";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Teal;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_refresh,
            this.btn_delete,
            this.txt_search,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(592, 31);
            this.toolStrip1.TabIndex = 73;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.btn_refresh.Size = new System.Drawing.Size(96, 24);
            this.btn_refresh.Text = "Refresh List";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_delete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.btn_delete.Size = new System.Drawing.Size(119, 24);
            this.btn_delete.Text = "Delete selected";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_search
            // 
            this.txt_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_search.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(200, 30);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 28);
            this.toolStripLabel1.Text = "Search:";
            // 
            // transTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(781, 562);
            this.Name = "transTable";
            this.Text = "Keyence Transaction Table";
            this.Load += new System.EventHandler(this.transTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_batch)).EndInit();
            this.toolstrip_batch.ResumeLayout(false);
            this.toolstrip_batch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_details)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolstrip_batch;
        private System.Windows.Forms.ToolStripButton btn_reload_batch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.ToolStripButton btn_delete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_status;
        private System.Windows.Forms.ToolStripTextBox txt_search;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView data_batch;
        private System.Windows.Forms.DataGridView data_details;
        private System.Windows.Forms.ToolStripStatusLabel txt_details_selectedBatch;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}