namespace keyencePartsVerifier.TRANSACTION
{
    partial class actualChecking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actualChecking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.r_filter = new System.Windows.Forms.RadioButton();
            this.r_all = new System.Windows.Forms.RadioButton();
            this.gb_all = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.gb_filter = new System.Windows.Forms.GroupBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_time2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_time1 = new System.Windows.Forms.DateTimePicker();
            this.cb_parts = new System.Windows.Forms.ComboBox();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_machine = new System.Windows.Forms.ComboBox();
            this.cb_line = new System.Windows.Forms.ComboBox();
            this.cb_table = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gb_all.SuspendLayout();
            this.gb_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.r_filter);
            this.panel1.Controls.Add(this.r_all);
            this.panel1.Controls.Add(this.gb_all);
            this.panel1.Controls.Add(this.gb_filter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 86);
            this.panel1.TabIndex = 47;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(177, 44);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(244, 27);
            this.dtpTo.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(146, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "To :";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(177, 11);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(244, 27);
            this.dtpFrom.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "From :";
            // 
            // r_filter
            // 
            this.r_filter.AutoSize = true;
            this.r_filter.Location = new System.Drawing.Point(579, 1);
            this.r_filter.Name = "r_filter";
            this.r_filter.Size = new System.Drawing.Size(95, 25);
            this.r_filter.TabIndex = 42;
            this.r_filter.Text = "Filter Data";
            this.r_filter.UseVisualStyleBackColor = true;
            this.r_filter.Visible = false;
            this.r_filter.CheckedChanged += new System.EventHandler(this.r_filter_CheckedChanged);
            // 
            // r_all
            // 
            this.r_all.AutoSize = true;
            this.r_all.Checked = true;
            this.r_all.Location = new System.Drawing.Point(449, 1);
            this.r_all.Name = "r_all";
            this.r_all.Size = new System.Drawing.Size(123, 25);
            this.r_all.TabIndex = 16;
            this.r_all.TabStop = true;
            this.r_all.Text = "All Transaction";
            this.r_all.UseVisualStyleBackColor = true;
            this.r_all.Visible = false;
            this.r_all.CheckedChanged += new System.EventHandler(this.r_all_CheckedChanged);
            // 
            // gb_all
            // 
            this.gb_all.Controls.Add(this.btnExport);
            this.gb_all.Controls.Add(this.btn_filter);
            this.gb_all.Controls.Add(this.btn_refresh);
            this.gb_all.Location = new System.Drawing.Point(7, -6);
            this.gb_all.Name = "gb_all";
            this.gb_all.Size = new System.Drawing.Size(118, 87);
            this.gb_all.TabIndex = 41;
            this.gb_all.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Teal;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(10, 45);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 27);
            this.btnExport.TabIndex = 43;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.Teal;
            this.btn_filter.FlatAppearance.BorderSize = 0;
            this.btn_filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btn_filter.ForeColor = System.Drawing.Color.White;
            this.btn_filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_filter.Image")));
            this.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filter.Location = new System.Drawing.Point(10, 55);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(101, 27);
            this.btn_filter.TabIndex = 42;
            this.btn_filter.Text = "Filter Data";
            this.btn_filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Visible = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
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
            this.btn_refresh.Location = new System.Drawing.Point(10, 15);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(101, 27);
            this.btn_refresh.TabIndex = 40;
            this.btn_refresh.Text = "View list";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gb_filter
            // 
            this.gb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_filter.Controls.Add(this.dtp_date);
            this.gb_filter.Controls.Add(this.dtp_time2);
            this.gb_filter.Controls.Add(this.dtp_time1);
            this.gb_filter.Controls.Add(this.cb_parts);
            this.gb_filter.Controls.Add(this.cb_model);
            this.gb_filter.Controls.Add(this.cb_type);
            this.gb_filter.Controls.Add(this.cb_machine);
            this.gb_filter.Controls.Add(this.cb_line);
            this.gb_filter.Controls.Add(this.cb_table);
            this.gb_filter.Controls.Add(this.label2);
            this.gb_filter.Controls.Add(this.label4);
            this.gb_filter.Controls.Add(this.label6);
            this.gb_filter.Controls.Add(this.label5);
            this.gb_filter.Controls.Add(this.label1);
            this.gb_filter.Controls.Add(this.label3);
            this.gb_filter.Controls.Add(this.label7);
            this.gb_filter.Controls.Add(this.label8);
            this.gb_filter.Controls.Add(this.label9);
            this.gb_filter.Enabled = false;
            this.gb_filter.Location = new System.Drawing.Point(449, 3);
            this.gb_filter.Name = "gb_filter";
            this.gb_filter.Size = new System.Drawing.Size(258, 77);
            this.gb_filter.TabIndex = 43;
            this.gb_filter.TabStop = false;
            this.gb_filter.Visible = false;
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Location = new System.Drawing.Point(54, 14);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(244, 27);
            this.dtp_date.TabIndex = 19;
            this.dtp_date.ValueChanged += new System.EventHandler(this._filterData);
            // 
            // dtp_time2
            // 
            this.dtp_time2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_time2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time2.Location = new System.Drawing.Point(205, 42);
            this.dtp_time2.Name = "dtp_time2";
            this.dtp_time2.Size = new System.Drawing.Size(93, 27);
            this.dtp_time2.TabIndex = 16;
            this.dtp_time2.ValueChanged += new System.EventHandler(this._filterData);
            // 
            // dtp_time1
            // 
            this.dtp_time1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_time1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time1.Location = new System.Drawing.Point(54, 43);
            this.dtp_time1.Name = "dtp_time1";
            this.dtp_time1.Size = new System.Drawing.Size(92, 27);
            this.dtp_time1.TabIndex = 14;
            this.dtp_time1.ValueChanged += new System.EventHandler(this._filterData);
            // 
            // cb_parts
            // 
            this.cb_parts.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_parts.FormattingEnabled = true;
            this.cb_parts.Location = new System.Drawing.Point(763, 43);
            this.cb_parts.Name = "cb_parts";
            this.cb_parts.Size = new System.Drawing.Size(117, 28);
            this.cb_parts.TabIndex = 13;
            this.cb_parts.TextChanged += new System.EventHandler(this._filterData);
            // 
            // cb_model
            // 
            this.cb_model.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(352, 13);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(117, 28);
            this.cb_model.TabIndex = 7;
            this.cb_model.SelectedIndexChanged += new System.EventHandler(this._filterData);
            this.cb_model.TextChanged += new System.EventHandler(this._filterData);
            // 
            // cb_type
            // 
            this.cb_type.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(763, 14);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(117, 28);
            this.cb_type.TabIndex = 11;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this._filterData);
            this.cb_type.TextChanged += new System.EventHandler(this._filterData);
            // 
            // cb_machine
            // 
            this.cb_machine.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_machine.FormattingEnabled = true;
            this.cb_machine.Location = new System.Drawing.Point(548, 42);
            this.cb_machine.Name = "cb_machine";
            this.cb_machine.Size = new System.Drawing.Size(117, 28);
            this.cb_machine.TabIndex = 3;
            this.cb_machine.SelectedIndexChanged += new System.EventHandler(this._filterData);
            this.cb_machine.TextChanged += new System.EventHandler(this._filterData);
            // 
            // cb_line
            // 
            this.cb_line.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_line.FormattingEnabled = true;
            this.cb_line.Items.AddRange(new object[] {
            "-- All Lines --"});
            this.cb_line.Location = new System.Drawing.Point(352, 42);
            this.cb_line.Name = "cb_line";
            this.cb_line.Size = new System.Drawing.Size(117, 28);
            this.cb_line.TabIndex = 1;
            this.cb_line.SelectedIndexChanged += new System.EventHandler(this._filterData);
            this.cb_line.TextChanged += new System.EventHandler(this._filterData);
            // 
            // cb_table
            // 
            this.cb_table.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_table.FormattingEnabled = true;
            this.cb_table.Location = new System.Drawing.Point(548, 13);
            this.cb_table.Name = "cb_table";
            this.cb_table.Size = new System.Drawing.Size(117, 28);
            this.cb_table.TabIndex = 5;
            this.cb_table.SelectedIndexChanged += new System.EventHandler(this._filterData);
            this.cb_table.TextChanged += new System.EventHandler(this._filterData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Machine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Table:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Parts (RINKS):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(690, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Scan Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "To:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "From:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeight = 40;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Location = new System.Drawing.Point(0, 88);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data.RowTemplate.Height = 30;
            this.data.Size = new System.Drawing.Size(1040, 409);
            this.data.TabIndex = 48;
            this.data.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_CellFormatting);
            this.data.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.data_RowPostPaint);
            this.data.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.data_RowStateChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Teal;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1040, 26);
            this.statusStrip1.TabIndex = 49;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 1F);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1040, 2);
            this.textBox1.TabIndex = 52;
            this.textBox1.TabStop = false;
            // 
            // actualChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 523);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(713, 561);
            this.Name = "actualChecking";
            this.Text = "Actual Checking Progress";
            this.Load += new System.EventHandler(this.actualChecking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_all.ResumeLayout(false);
            this.gb_filter.ResumeLayout(false);
            this.gb_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_table;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_machine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_status;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.RadioButton r_filter;
        private System.Windows.Forms.RadioButton r_all;
        private System.Windows.Forms.GroupBox gb_all;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.GroupBox gb_filter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cb_parts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_time2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_time1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label11;


    }
}