namespace keyencePartsVerifier.TRANSACTION
{
    partial class errorLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(errorLogs));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_time1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_time2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.textBox1.Size = new System.Drawing.Size(648, 2);
            this.textBox1.TabIndex = 52;
            this.textBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_retrieve);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_time2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_time1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 84);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Errors";
            // 
            // dtp_time1
            // 
            this.dtp_time1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.dtp_time1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time1.Location = new System.Drawing.Point(102, 50);
            this.dtp_time1.Name = "dtp_time1";
            this.dtp_time1.Size = new System.Drawing.Size(125, 27);
            this.dtp_time1.TabIndex = 0;
            this.dtp_time1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // dtp_time2
            // 
            this.dtp_time2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.dtp_time2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time2.Location = new System.Drawing.Point(282, 50);
            this.dtp_time2.Name = "dtp_time2";
            this.dtp_time2.Size = new System.Drawing.Size(125, 27);
            this.dtp_time2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date:";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.dtp_date.Location = new System.Drawing.Point(102, 19);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(305, 27);
            this.dtp_date.TabIndex = 5;
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.BackColor = System.Drawing.Color.Teal;
            this.btn_retrieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_retrieve.FlatAppearance.BorderSize = 0;
            this.btn_retrieve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_retrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retrieve.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.btn_retrieve.ForeColor = System.Drawing.Color.White;
            this.btn_retrieve.Location = new System.Drawing.Point(413, 19);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(118, 57);
            this.btn_retrieve.TabIndex = 6;
            this.btn_retrieve.Text = "Retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = false;
            // 
            // errorLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(648, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "errorLogs";
            this.Text = "Error Logs";
            this.Load += new System.EventHandler(this.errorLogs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_time1;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_time2;
        private System.Windows.Forms.Button btn_retrieve;
    }
}