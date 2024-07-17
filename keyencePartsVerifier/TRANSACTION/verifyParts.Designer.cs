namespace keyencePartsVerifier.TRANSACTION
{
    partial class verifyParts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verifyParts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.r_notChecked = new MetroFramework.Controls.MetroRadioButton();
            this.r_checked = new MetroFramework.Controls.MetroRadioButton();
            this.r_all = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_setup_batch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dg_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.dg_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_lineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_feederName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_partsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_yes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Teal;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Light", 1F);
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(972, 2);
            this.textBox2.TabIndex = 37;
            this.textBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Teal;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(972, 26);
            this.statusStrip1.TabIndex = 41;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Verify Parts";
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeight = 40;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_image,
            this.dg_productName,
            this.dg_lineName,
            this.dg_tableName,
            this.dg_feederName,
            this.dg_partsName,
            this.dg_yes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle3;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Location = new System.Drawing.Point(8, 107);
            this.data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data.Name = "data";
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data.RowTemplate.Height = 40;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(958, 487);
            this.data.TabIndex = 43;
            this.data.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.data_RowPostPaint);
            this.data.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.data_RowStateChanged);
            // 
            // r_notChecked
            // 
            this.r_notChecked.AutoSize = true;
            this.r_notChecked.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.r_notChecked.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.r_notChecked.Location = new System.Drawing.Point(97, 35);
            this.r_notChecked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r_notChecked.Name = "r_notChecked";
            this.r_notChecked.Size = new System.Drawing.Size(101, 19);
            this.r_notChecked.Style = MetroFramework.MetroColorStyle.Teal;
            this.r_notChecked.TabIndex = 44;
            this.r_notChecked.Text = "Not Checked";
            this.r_notChecked.UseSelectable = true;
            this.r_notChecked.CheckedChanged += new System.EventHandler(this.r_notChecked_CheckedChanged);
            // 
            // r_checked
            // 
            this.r_checked.AutoSize = true;
            this.r_checked.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.r_checked.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.r_checked.Location = new System.Drawing.Point(14, 35);
            this.r_checked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r_checked.Name = "r_checked";
            this.r_checked.Size = new System.Drawing.Size(75, 19);
            this.r_checked.Style = MetroFramework.MetroColorStyle.Teal;
            this.r_checked.TabIndex = 45;
            this.r_checked.Text = "Checked";
            this.r_checked.UseSelectable = true;
            this.r_checked.CheckedChanged += new System.EventHandler(this.r_checked_CheckedChanged);
            // 
            // r_all
            // 
            this.r_all.AutoSize = true;
            this.r_all.Checked = true;
            this.r_all.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.r_all.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.r_all.Location = new System.Drawing.Point(206, 35);
            this.r_all.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r_all.Name = "r_all";
            this.r_all.Size = new System.Drawing.Size(40, 19);
            this.r_all.Style = MetroFramework.MetroColorStyle.Teal;
            this.r_all.TabIndex = 46;
            this.r_all.TabStop = true;
            this.r_all.Text = "All";
            this.r_all.UseSelectable = true;
            this.r_all.CheckedChanged += new System.EventHandler(this.r_all_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_checked);
            this.groupBox1.Controls.Add(this.r_all);
            this.groupBox1.Controls.Add(this.r_notChecked);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.groupBox1.Location = new System.Drawing.Point(228, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(260, 73);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "Status";
            this.dataGridViewImageColumn1.Image = global::keyencePartsVerifier.Properties.Resources.noimage;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 35;
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
            this.btn_refresh.Location = new System.Drawing.Point(5, 27);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(99, 35);
            this.btn_refresh.TabIndex = 48;
            this.btn_refresh.Text = "Refresh list";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.groupBox2.Location = new System.Drawing.Point(490, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(291, 73);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Legend";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Not Checked";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(144, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checked";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_setup_batch);
            this.groupBox3.Controls.Add(this.btn_refresh);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.groupBox3.Location = new System.Drawing.Point(8, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(218, 73);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            // 
            // btn_setup_batch
            // 
            this.btn_setup_batch.BackColor = System.Drawing.Color.Teal;
            this.btn_setup_batch.FlatAppearance.BorderSize = 0;
            this.btn_setup_batch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_setup_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setup_batch.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btn_setup_batch.ForeColor = System.Drawing.Color.White;
            this.btn_setup_batch.Image = ((System.Drawing.Image)(resources.GetObject("btn_setup_batch.Image")));
            this.btn_setup_batch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setup_batch.Location = new System.Drawing.Point(107, 27);
            this.btn_setup_batch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_setup_batch.Name = "btn_setup_batch";
            this.btn_setup_batch.Size = new System.Drawing.Size(104, 35);
            this.btn_setup_batch.TabIndex = 49;
            this.btn_setup_batch.Text = "Setup Batch";
            this.btn_setup_batch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setup_batch.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dg_image
            // 
            this.dg_image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dg_image.Frozen = true;
            this.dg_image.HeaderText = "/";
            this.dg_image.Image = global::keyencePartsVerifier.Properties.Resources.noimage;
            this.dg_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dg_image.Name = "dg_image";
            this.dg_image.ReadOnly = true;
            this.dg_image.Width = 40;
            // 
            // dg_productName
            // 
            this.dg_productName.HeaderText = "Product Name";
            this.dg_productName.Name = "dg_productName";
            this.dg_productName.ReadOnly = true;
            this.dg_productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dg_productName.Width = 138;
            // 
            // dg_lineName
            // 
            this.dg_lineName.HeaderText = "Line Name";
            this.dg_lineName.Name = "dg_lineName";
            this.dg_lineName.ReadOnly = true;
            this.dg_lineName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dg_lineName.Width = 106;
            // 
            // dg_tableName
            // 
            this.dg_tableName.HeaderText = "Table";
            this.dg_tableName.Name = "dg_tableName";
            this.dg_tableName.ReadOnly = true;
            this.dg_tableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dg_tableName.Width = 62;
            // 
            // dg_feederName
            // 
            this.dg_feederName.HeaderText = "Feeder";
            this.dg_feederName.Name = "dg_feederName";
            this.dg_feederName.ReadOnly = true;
            this.dg_feederName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dg_feederName.Width = 74;
            // 
            // dg_partsName
            // 
            this.dg_partsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dg_partsName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_partsName.HeaderText = "Parts (RINKS Code)";
            this.dg_partsName.Name = "dg_partsName";
            this.dg_partsName.ReadOnly = true;
            this.dg_partsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dg_yes
            // 
            this.dg_yes.HeaderText = "yes";
            this.dg_yes.Name = "dg_yes";
            this.dg_yes.ReadOnly = true;
            this.dg_yes.Visible = false;
            this.dg_yes.Width = 63;
            // 
            // verifyParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimumSize = new System.Drawing.Size(988, 671);
            this.Name = "verifyParts";
            this.Text = "Verify Parts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.verifyParts_FormClosed);
            this.Load += new System.EventHandler(this.verifyParts_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private MetroFramework.Controls.MetroRadioButton r_notChecked;
        private MetroFramework.Controls.MetroRadioButton r_checked;
        private MetroFramework.Controls.MetroRadioButton r_all;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_setup_batch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewImageColumn dg_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_lineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_tableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_feederName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_partsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_yes;
        //private System.Windows.Forms.DataGridViewTextBoxColumn _viewLotNo;
        //private System.Windows.Forms.DataGridViewTextBoxColumn _viewmodelName;
    }
}