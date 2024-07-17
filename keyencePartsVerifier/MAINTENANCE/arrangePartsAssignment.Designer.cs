namespace keyencePartsVerifier.MAINTENANCE
{
    partial class arrangePartsAssignment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arrangePartsAssignment));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.gb_filter = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.cb_machine = new System.Windows.Forms.ComboBox();
            this.cb_line = new System.Windows.Forms.ComboBox();
            this.cb_table = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.btn_move_up = new System.Windows.Forms.Button();
            this.btn_move_down = new System.Windows.Forms.Button();
            this.dg_mnt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_modelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_lineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_machineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_feederLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_partsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.gb_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 1F);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(753, 2);
            this.textBox1.TabIndex = 53;
            this.textBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Teal;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(753, 26);
            this.statusStrip1.TabIndex = 54;
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
            // gb_filter
            // 
            this.gb_filter.Controls.Add(this.btn_save);
            this.gb_filter.Controls.Add(this.btn_move_down);
            this.gb_filter.Controls.Add(this.btn_move_up);
            this.gb_filter.Controls.Add(this.btn_refresh);
            this.gb_filter.Controls.Add(this.cb_model);
            this.gb_filter.Controls.Add(this.cb_machine);
            this.gb_filter.Controls.Add(this.cb_line);
            this.gb_filter.Controls.Add(this.cb_table);
            this.gb_filter.Controls.Add(this.label2);
            this.gb_filter.Controls.Add(this.label4);
            this.gb_filter.Controls.Add(this.label1);
            this.gb_filter.Controls.Add(this.label3);
            this.gb_filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_filter.Location = new System.Drawing.Point(0, 2);
            this.gb_filter.Name = "gb_filter";
            this.gb_filter.Size = new System.Drawing.Size(753, 76);
            this.gb_filter.TabIndex = 55;
            this.gb_filter.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Teal;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(376, 15);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(101, 55);
            this.btn_refresh.TabIndex = 41;
            this.btn_refresh.Text = "View Data";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cb_model
            // 
            this.cb_model.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(57, 14);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(117, 28);
            this.cb_model.TabIndex = 7;
            // 
            // cb_machine
            // 
            this.cb_machine.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_machine.FormattingEnabled = true;
            this.cb_machine.Location = new System.Drawing.Point(253, 43);
            this.cb_machine.Name = "cb_machine";
            this.cb_machine.Size = new System.Drawing.Size(117, 28);
            this.cb_machine.TabIndex = 3;
            // 
            // cb_line
            // 
            this.cb_line.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_line.FormattingEnabled = true;
            this.cb_line.Items.AddRange(new object[] {
            "-- All Lines --"});
            this.cb_line.Location = new System.Drawing.Point(57, 43);
            this.cb_line.Name = "cb_line";
            this.cb_line.Size = new System.Drawing.Size(117, 28);
            this.cb_line.TabIndex = 1;
            // 
            // cb_table
            // 
            this.cb_table.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_table.FormattingEnabled = true;
            this.cb_table.Location = new System.Drawing.Point(253, 14);
            this.cb_table.Name = "cb_table";
            this.cb_table.Size = new System.Drawing.Size(117, 28);
            this.cb_table.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Machine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Table:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model:";
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data.ColumnHeadersHeight = 40;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_mnt_id,
            this.dg_order_id,
            this.dg_modelName,
            this.dg_lineName,
            this.dg_machineName,
            this.dg_tableName,
            this.dg_feederLocation,
            this.dg_partsName});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle4;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Location = new System.Drawing.Point(0, 78);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data.RowTemplate.Height = 30;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(753, 360);
            this.data.TabIndex = 56;
            this.data.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.data_RowPostPaint);
            // 
            // btn_move_up
            // 
            this.btn_move_up.BackColor = System.Drawing.Color.Teal;
            this.btn_move_up.FlatAppearance.BorderSize = 0;
            this.btn_move_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_move_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_up.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btn_move_up.ForeColor = System.Drawing.Color.White;
            this.btn_move_up.Image = ((System.Drawing.Image)(resources.GetObject("btn_move_up.Image")));
            this.btn_move_up.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_move_up.Location = new System.Drawing.Point(478, 15);
            this.btn_move_up.Name = "btn_move_up";
            this.btn_move_up.Size = new System.Drawing.Size(136, 27);
            this.btn_move_up.TabIndex = 42;
            this.btn_move_up.Text = "Move Up";
            this.btn_move_up.UseVisualStyleBackColor = false;
            this.btn_move_up.Click += new System.EventHandler(this.btn_move_up_Click);
            // 
            // btn_move_down
            // 
            this.btn_move_down.BackColor = System.Drawing.Color.Teal;
            this.btn_move_down.FlatAppearance.BorderSize = 0;
            this.btn_move_down.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_move_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_down.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btn_move_down.ForeColor = System.Drawing.Color.White;
            this.btn_move_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_move_down.Image")));
            this.btn_move_down.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_move_down.Location = new System.Drawing.Point(478, 43);
            this.btn_move_down.Name = "btn_move_down";
            this.btn_move_down.Size = new System.Drawing.Size(136, 27);
            this.btn_move_down.TabIndex = 43;
            this.btn_move_down.Text = "Move Down";
            this.btn_move_down.UseVisualStyleBackColor = false;
            this.btn_move_down.Click += new System.EventHandler(this.btn_move_down_Click);
            // 
            // dg_mnt_id
            // 
            this.dg_mnt_id.HeaderText = "Mnt ID";
            this.dg_mnt_id.Name = "dg_mnt_id";
            this.dg_mnt_id.ReadOnly = true;
            this.dg_mnt_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_order_id
            // 
            this.dg_order_id.HeaderText = "Order ID";
            this.dg_order_id.Name = "dg_order_id";
            this.dg_order_id.ReadOnly = true;
            // 
            // dg_modelName
            // 
            this.dg_modelName.HeaderText = "Model";
            this.dg_modelName.Name = "dg_modelName";
            this.dg_modelName.ReadOnly = true;
            this.dg_modelName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_lineName
            // 
            this.dg_lineName.HeaderText = "Line";
            this.dg_lineName.Name = "dg_lineName";
            this.dg_lineName.ReadOnly = true;
            this.dg_lineName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_machineName
            // 
            this.dg_machineName.HeaderText = "Machine";
            this.dg_machineName.Name = "dg_machineName";
            this.dg_machineName.ReadOnly = true;
            this.dg_machineName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_tableName
            // 
            this.dg_tableName.HeaderText = "Table";
            this.dg_tableName.Name = "dg_tableName";
            this.dg_tableName.ReadOnly = true;
            this.dg_tableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_feederLocation
            // 
            this.dg_feederLocation.HeaderText = "Feeder Location";
            this.dg_feederLocation.Name = "dg_feederLocation";
            this.dg_feederLocation.ReadOnly = true;
            this.dg_feederLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_partsName
            // 
            this.dg_partsName.HeaderText = "Parts";
            this.dg_partsName.Name = "dg_partsName";
            this.dg_partsName.ReadOnly = true;
            this.dg_partsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(615, 15);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 55);
            this.btn_save.TabIndex = 44;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // arrangePartsAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(753, 464);
            this.Controls.Add(this.data);
            this.Controls.Add(this.gb_filter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "arrangePartsAssignment";
            this.Text = "Feeder & Parts Arrangement";
            this.Load += new System.EventHandler(this.arrangePartsAssignment_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gb_filter.ResumeLayout(false);
            this.gb_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_status;
        private System.Windows.Forms.GroupBox gb_filter;
        private System.Windows.Forms.ComboBox cb_model;
        private System.Windows.Forms.ComboBox cb_machine;
        private System.Windows.Forms.ComboBox cb_line;
        private System.Windows.Forms.ComboBox cb_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_move_down;
        private System.Windows.Forms.Button btn_move_up;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_mnt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_modelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_lineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_machineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_tableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_feederLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_partsName;
        private System.Windows.Forms.Button btn_save;
    }
}