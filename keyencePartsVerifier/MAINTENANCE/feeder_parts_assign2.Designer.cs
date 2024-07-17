namespace keyencePartsVerifier.MAINTENANCE
{
    partial class feeder_parts_assign2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feeder_parts_assign2));
            this.gb_filter = new System.Windows.Forms.GroupBox();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.cb_parts = new System.Windows.Forms.ComboBox();
            this.cb_machine = new System.Windows.Forms.ComboBox();
            this.cb_line = new System.Windows.Forms.ComboBox();
            this.cb_table = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_filter
            // 
            this.gb_filter.Controls.Add(this.cb_model);
            this.gb_filter.Controls.Add(this.cb_parts);
            this.gb_filter.Controls.Add(this.cb_machine);
            this.gb_filter.Controls.Add(this.cb_line);
            this.gb_filter.Controls.Add(this.cb_table);
            this.gb_filter.Controls.Add(this.label2);
            this.gb_filter.Controls.Add(this.label1);
            this.gb_filter.Controls.Add(this.label3);
            this.gb_filter.Controls.Add(this.label4);
            this.gb_filter.Controls.Add(this.label5);
            this.gb_filter.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_filter.Location = new System.Drawing.Point(0, 2);
            this.gb_filter.Name = "gb_filter";
            this.gb_filter.Size = new System.Drawing.Size(227, 475);
            this.gb_filter.TabIndex = 44;
            this.gb_filter.TabStop = false;
            this.gb_filter.Text = "Filter Data:";
            this.gb_filter.Enter += new System.EventHandler(this.gb_filter_Enter);
            // 
            // cb_model
            // 
            this.cb_model.DropDownWidth = 200;
            this.cb_model.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(105, 29);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(117, 28);
            this.cb_model.TabIndex = 7;
            this.cb_model.TextChanged += new System.EventHandler(this._filterData);
            // 
            // cb_parts
            // 
            this.cb_parts.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.cb_parts.FormattingEnabled = true;
            this.cb_parts.Location = new System.Drawing.Point(105, 145);
            this.cb_parts.Name = "cb_parts";
            this.cb_parts.Size = new System.Drawing.Size(117, 28);
            this.cb_parts.TabIndex = 11;
            this.cb_parts.TextChanged += new System.EventHandler(this._filterData);
            // 
            // cb_machine
            // 
            this.cb_machine.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.cb_machine.FormattingEnabled = true;
            this.cb_machine.Location = new System.Drawing.Point(105, 116);
            this.cb_machine.Name = "cb_machine";
            this.cb_machine.Size = new System.Drawing.Size(117, 28);
            this.cb_machine.TabIndex = 3;
            this.cb_machine.TextChanged += new System.EventHandler(this._filterData);
            // 
            // cb_line
            // 
            this.cb_line.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.cb_line.FormattingEnabled = true;
            this.cb_line.Location = new System.Drawing.Point(105, 58);
            this.cb_line.Name = "cb_line";
            this.cb_line.Size = new System.Drawing.Size(117, 28);
            this.cb_line.TabIndex = 1;
            this.cb_line.TextChanged += new System.EventHandler(this._filterData);
            // 
            // cb_table
            // 
            this.cb_table.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.cb_table.FormattingEnabled = true;
            this.cb_table.Location = new System.Drawing.Point(105, 87);
            this.cb_table.Name = "cb_table";
            this.cb_table.Size = new System.Drawing.Size(117, 28);
            this.cb_table.TabIndex = 5;
            this.cb_table.TextChanged += new System.EventHandler(this._filterData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Machine:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Table:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parts (RINKS):";
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
            this.data.Location = new System.Drawing.Point(227, 2);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data.RowTemplate.Height = 30;
            this.data.Size = new System.Drawing.Size(609, 475);
            this.data.TabIndex = 49;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(836, 26);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 1F);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(836, 2);
            this.textBox1.TabIndex = 51;
            this.textBox1.TabStop = false;
            // 
            // feeder_parts_assign2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(836, 503);
            this.Controls.Add(this.data);
            this.Controls.Add(this.gb_filter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "feeder_parts_assign2";
            this.Text = "Feeder & Parts Assignment";
            this.Load += new System.EventHandler(this.feeder_parts_assign2_Load);
            this.gb_filter.ResumeLayout(false);
            this.gb_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_filter;
        private System.Windows.Forms.ComboBox cb_model;
        private System.Windows.Forms.ComboBox cb_parts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_machine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_line;
        private System.Windows.Forms.ComboBox cb_table;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_status;
        private System.Windows.Forms.TextBox textBox1;
    }
}