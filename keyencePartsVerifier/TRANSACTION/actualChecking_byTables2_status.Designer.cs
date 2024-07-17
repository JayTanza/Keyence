namespace keyencePartsVerifier.TRANSACTION
{
    partial class actualChecking_byTables2_status
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actualChecking_byTables2_status));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_rows_status = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.dg_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_feederLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_partsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_status_image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_order_id,
            this.dg_tableName,
            this.dg_feederLocation,
            this.dg_partsName,
            this.dg_status,
            this.dg_status_image});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(627, 487);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 51);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 2F);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(627, 4);
            this.textBox1.TabIndex = 54;
            this.textBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_title.ForeColor = System.Drawing.Color.Teal;
            this.lbl_title.Location = new System.Drawing.Point(7, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(95, 28);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title here!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_rows_status);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 40);
            this.panel2.TabIndex = 2;
            // 
            // lbl_rows_status
            // 
            this.lbl_rows_status.AutoSize = true;
            this.lbl_rows_status.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbl_rows_status.ForeColor = System.Drawing.Color.Teal;
            this.lbl_rows_status.Location = new System.Drawing.Point(7, 8);
            this.lbl_rows_status.Name = "lbl_rows_status";
            this.lbl_rows_status.Size = new System.Drawing.Size(129, 21);
            this.lbl_rows_status.TabIndex = 55;
            this.lbl_rows_status.Text = "Checked 0 of 100.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Teal;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Light", 2F);
            this.textBox2.Location = new System.Drawing.Point(0, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(627, 4);
            this.textBox2.TabIndex = 54;
            this.textBox2.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btn_close.Location = new System.Drawing.Point(542, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 29);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // dg_order_id
            // 
            this.dg_order_id.HeaderText = "Order ID";
            this.dg_order_id.Name = "dg_order_id";
            this.dg_order_id.ReadOnly = true;
            this.dg_order_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dg_order_id.Visible = false;
            // 
            // dg_tableName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_tableName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_tableName.FillWeight = 86.94875F;
            this.dg_tableName.HeaderText = "Table";
            this.dg_tableName.Name = "dg_tableName";
            this.dg_tableName.ReadOnly = true;
            this.dg_tableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_feederLocation
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_feederLocation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_feederLocation.FillWeight = 86.94875F;
            this.dg_feederLocation.HeaderText = "Feeder Location";
            this.dg_feederLocation.Name = "dg_feederLocation";
            this.dg_feederLocation.ReadOnly = true;
            this.dg_feederLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_partsName
            // 
            this.dg_partsName.FillWeight = 86.94875F;
            this.dg_partsName.HeaderText = "Parts (RINKS)";
            this.dg_partsName.Name = "dg_partsName";
            this.dg_partsName.ReadOnly = true;
            this.dg_partsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_status
            // 
            this.dg_status.HeaderText = "Status";
            this.dg_status.Name = "dg_status";
            this.dg_status.ReadOnly = true;
            this.dg_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dg_status.Visible = false;
            // 
            // dg_status_image
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.dg_status_image.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_status_image.FillWeight = 29.47415F;
            this.dg_status_image.HeaderText = "Status";
            this.dg_status_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dg_status_image.Name = "dg_status_image";
            this.dg_status_image.ReadOnly = true;
            this.dg_status_image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // actualChecking_byTables2_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(627, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "actualChecking_byTables2_status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line - Machine - Table";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.actualChecking_byTables2_status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_rows_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_tableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_feederLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_partsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_status;
        private System.Windows.Forms.DataGridViewImageColumn dg_status_image;
    }
}