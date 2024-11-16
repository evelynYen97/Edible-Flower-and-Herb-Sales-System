namespace 個人專題
{
    partial class frmReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btn29 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn28 = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnThisYear = new System.Windows.Forms.Button();
            this.btnNextYear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(582, 44);
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(105, 18);
            this.lblHeader.Text = "Reservation";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(431, 530);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(496, 530);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Month :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Day :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(21, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year :";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblYear.Location = new System.Drawing.Point(85, 57);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(101, 27);
            this.lblYear.TabIndex = 7;
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn29
            // 
            this.btn29.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn29.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn29.Location = new System.Drawing.Point(81, 501);
            this.btn29.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.btn29.Name = "btn29";
            this.btn29.Size = new System.Drawing.Size(55, 55);
            this.btn29.TabIndex = 29;
            this.btn29.Text = "29";
            this.btn29.UseVisualStyleBackColor = true;
            this.btn29.Visible = false;
            this.btn29.Click += new System.EventHandler(this.btn29_Click);
            // 
            // btn30
            // 
            this.btn30.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn30.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn30.Location = new System.Drawing.Point(138, 501);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(55, 55);
            this.btn30.TabIndex = 31;
            this.btn30.Text = "30";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Visible = false;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // btn31
            // 
            this.btn31.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn31.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn31.Location = new System.Drawing.Point(195, 501);
            this.btn31.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(55, 55);
            this.btn31.TabIndex = 36;
            this.btn31.Text = "31";
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Visible = false;
            this.btn31.Click += new System.EventHandler(this.btn31_Click);
            // 
            // btn28
            // 
            this.btn28.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn28.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn28.Location = new System.Drawing.Point(24, 501);
            this.btn28.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.btn28.Name = "btn28";
            this.btn28.Size = new System.Drawing.Size(55, 55);
            this.btn28.TabIndex = 37;
            this.btn28.Text = "28";
            this.btn28.UseVisualStyleBackColor = true;
            this.btn28.Visible = false;
            this.btn28.Click += new System.EventHandler(this.btn28_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonth.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMonth.Location = new System.Drawing.Point(106, 141);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(91, 24);
            this.lblMonth.TabIndex = 38;
            // 
            // lblDay
            // 
            this.lblDay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDay.Location = new System.Drawing.Point(81, 293);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(91, 24);
            this.lblDay.TabIndex = 39;
            // 
            // btnThisYear
            // 
            this.btnThisYear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnThisYear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnThisYear.Location = new System.Drawing.Point(25, 91);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Size = new System.Drawing.Size(83, 38);
            this.btnThisYear.TabIndex = 40;
            this.btnThisYear.UseVisualStyleBackColor = true;
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // btnNextYear
            // 
            this.btnNextYear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextYear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNextYear.Location = new System.Drawing.Point(118, 91);
            this.btnNextYear.Name = "btnNextYear";
            this.btnNextYear.Size = new System.Drawing.Size(83, 38);
            this.btnNextYear.TabIndex = 41;
            this.btnNextYear.UseVisualStyleBackColor = true;
            this.btnNextYear.Click += new System.EventHandler(this.btnNextYear_Click);
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(582, 611);
            this.Controls.Add(this.btnNextYear);
            this.Controls.Add(this.btnThisYear);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btn28);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn29);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReservation";
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblYear, 0);
            this.Controls.SetChildIndex(this.btn29, 0);
            this.Controls.SetChildIndex(this.btn30, 0);
            this.Controls.SetChildIndex(this.btn31, 0);
            this.Controls.SetChildIndex(this.btn28, 0);
            this.Controls.SetChildIndex(this.lblMonth, 0);
            this.Controls.SetChildIndex(this.lblDay, 0);
            this.Controls.SetChildIndex(this.btnThisYear, 0);
            this.Controls.SetChildIndex(this.btnNextYear, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn29;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn28;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        internal System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnThisYear;
        private System.Windows.Forms.Button btnNextYear;
    }
}