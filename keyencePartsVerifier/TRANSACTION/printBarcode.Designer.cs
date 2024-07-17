namespace keyencePartsVerifier.TRANSACTION
{
    partial class printBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printBarcode));
            this.txt_to = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_codeFor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_single_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.bw_print = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add2list = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.dg_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dg_barcodeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remove_from_list = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_to
            // 
            this.txt_to.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_to.Location = new System.Drawing.Point(74, 99);
            this.txt_to.Name = "txt_to";
            this.txt_to.ShortcutsEnabled = false;
            this.txt_to.Size = new System.Drawing.Size(330, 29);
            this.txt_to.TabIndex = 13;
            this.txt_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_to_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "To:";
            // 
            // txt_from
            // 
            this.txt_from.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_from.Location = new System.Drawing.Point(74, 68);
            this.txt_from.Name = "txt_from";
            this.txt_from.ShortcutsEnabled = false;
            this.txt_from.Size = new System.Drawing.Size(330, 29);
            this.txt_from.TabIndex = 11;
            this.txt_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_from_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "From:";
            // 
            // cb_codeFor
            // 
            this.cb_codeFor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_codeFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_codeFor.FormattingEnabled = true;
            this.cb_codeFor.Items.AddRange(new object[] {
            "Product",
            "Line",
            "Table",
            "Feeder",
            "RINKS Code"});
            this.cb_codeFor.Location = new System.Drawing.Point(74, 36);
            this.cb_codeFor.Name = "cb_codeFor";
            this.cb_codeFor.Size = new System.Drawing.Size(330, 29);
            this.cb_codeFor.TabIndex = 9;
            this.cb_codeFor.SelectedIndexChanged += new System.EventHandler(this.cb_codeFor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Generate Barcode for:";
            // 
            // txt_single_value
            // 
            this.txt_single_value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_single_value.Location = new System.Drawing.Point(74, 145);
            this.txt_single_value.Name = "txt_single_value";
            this.txt_single_value.ReadOnly = true;
            this.txt_single_value.ShortcutsEnabled = false;
            this.txt_single_value.Size = new System.Drawing.Size(330, 29);
            this.txt_single_value.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Single \r\nValue:";
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.BackColor = System.Drawing.Color.Teal;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(12, 8);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(262, 31);
            this.btn_print.TabIndex = 16;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Teal;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Light", 1F);
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(428, 2);
            this.textBox2.TabIndex = 17;
            this.textBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_remove_from_list);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 68);
            this.panel1.TabIndex = 18;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Teal;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_status,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 42);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(428, 26);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
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
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 20);
            // 
            // bw_print
            // 
            this.bw_print.WorkerReportsProgress = true;
            this.bw_print.WorkerSupportsCancellation = true;
            this.bw_print.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_print_DoWork);
            this.bw_print.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_print_ProgressChanged);
            this.bw_print.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_print_RunWorkerCompleted);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_add2list);
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 50);
            this.panel2.TabIndex = 19;
            // 
            // btn_add2list
            // 
            this.btn_add2list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add2list.BackColor = System.Drawing.Color.Teal;
            this.btn_add2list.FlatAppearance.BorderSize = 0;
            this.btn_add2list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_add2list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add2list.ForeColor = System.Drawing.Color.White;
            this.btn_add2list.Location = new System.Drawing.Point(12, 9);
            this.btn_add2list.Name = "btn_add2list";
            this.btn_add2list.Size = new System.Drawing.Size(404, 31);
            this.btn_add2list.TabIndex = 26;
            this.btn_add2list.Text = "Add to list";
            this.btn_add2list.UseVisualStyleBackColor = false;
            this.btn_add2list.Click += new System.EventHandler(this.btn_add2list_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeRows = false;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_check,
            this.dg_barcodeValue,
            this.dg_header});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Location = new System.Drawing.Point(0, 234);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data.RowTemplate.Height = 30;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(428, 264);
            this.data.TabIndex = 31;
            this.data.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.data_RowPostPaint);
            // 
            // dg_check
            // 
            this.dg_check.FillWeight = 30.45685F;
            this.dg_check.HeaderText = "/";
            this.dg_check.Name = "dg_check";
            this.dg_check.ReadOnly = true;
            // 
            // dg_barcodeValue
            // 
            this.dg_barcodeValue.FillWeight = 134.7716F;
            this.dg_barcodeValue.HeaderText = "Barcode Value";
            this.dg_barcodeValue.Name = "dg_barcodeValue";
            this.dg_barcodeValue.ReadOnly = true;
            // 
            // dg_header
            // 
            this.dg_header.FillWeight = 134.7716F;
            this.dg_header.HeaderText = "Barcode Header";
            this.dg_header.Name = "dg_header";
            this.dg_header.ReadOnly = true;
            // 
            // btn_remove_from_list
            // 
            this.btn_remove_from_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove_from_list.BackColor = System.Drawing.Color.White;
            this.btn_remove_from_list.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_remove_from_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_remove_from_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_from_list.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_remove_from_list.Location = new System.Drawing.Point(276, 8);
            this.btn_remove_from_list.Name = "btn_remove_from_list";
            this.btn_remove_from_list.Size = new System.Drawing.Size(141, 31);
            this.btn_remove_from_list.TabIndex = 26;
            this.btn_remove_from_list.Text = "Remove from list";
            this.btn_remove_from_list.UseVisualStyleBackColor = false;
            this.btn_remove_from_list.Click += new System.EventHandler(this.btn_remove_from_list_Click);
            // 
            // printBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 569);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_single_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_codeFor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "printBarcode";
            this.Text = "Print Barcode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_codeFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_single_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txt_status;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker bw_print;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_add2list;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dg_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_barcodeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_header;
        private System.Windows.Forms.Button btn_remove_from_list;
    }
}