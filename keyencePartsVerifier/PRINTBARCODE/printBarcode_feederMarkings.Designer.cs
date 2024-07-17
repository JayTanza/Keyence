namespace keyencePartsVerifier.PRINTBARCODE
{
    partial class printBarcode_feederMarkings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printBarcode_feederMarkings));
            this.lbl_status2 = new System.Windows.Forms.Label();
            this.btn_printfeeder2 = new System.Windows.Forms.Button();
            this.nud_to = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_from = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_from)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_status2
            // 
            this.lbl_status2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_status2.AutoSize = true;
            this.lbl_status2.Location = new System.Drawing.Point(11, 144);
            this.lbl_status2.Name = "lbl_status2";
            this.lbl_status2.Size = new System.Drawing.Size(100, 21);
            this.lbl_status2.TabIndex = 21;
            this.lbl_status2.Text = "Status: Ready";
            // 
            // btn_printfeeder2
            // 
            this.btn_printfeeder2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_printfeeder2.BackColor = System.Drawing.Color.Teal;
            this.btn_printfeeder2.FlatAppearance.BorderSize = 0;
            this.btn_printfeeder2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_printfeeder2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printfeeder2.ForeColor = System.Drawing.Color.White;
            this.btn_printfeeder2.Location = new System.Drawing.Point(11, 101);
            this.btn_printfeeder2.Name = "btn_printfeeder2";
            this.btn_printfeeder2.Size = new System.Drawing.Size(277, 31);
            this.btn_printfeeder2.TabIndex = 20;
            this.btn_printfeeder2.Text = "Print  Feeder Markings";
            this.btn_printfeeder2.UseVisualStyleBackColor = false;
            this.btn_printfeeder2.Click += new System.EventHandler(this.btn_printfeeder2_Click);
            // 
            // nud_to
            // 
            this.nud_to.Location = new System.Drawing.Point(71, 45);
            this.nud_to.Name = "nud_to";
            this.nud_to.Size = new System.Drawing.Size(174, 29);
            this.nud_to.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "To:";
            // 
            // nud_from
            // 
            this.nud_from.Location = new System.Drawing.Point(71, 14);
            this.nud_from.Name = "nud_from";
            this.nud_from.Size = new System.Drawing.Size(174, 29);
            this.nud_from.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "From:";
            // 
            // printBarcode_feederMarkings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(299, 179);
            this.Controls.Add(this.lbl_status2);
            this.Controls.Add(this.btn_printfeeder2);
            this.Controls.Add(this.nud_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_from);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "printBarcode_feederMarkings";
            this.Text = "Print Feeder Markings";
            ((System.ComponentModel.ISupportInitialize)(this.nud_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_from)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_status2;
        private System.Windows.Forms.Button btn_printfeeder2;
        private System.Windows.Forms.NumericUpDown nud_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_from;
        private System.Windows.Forms.Label label1;

    }
}