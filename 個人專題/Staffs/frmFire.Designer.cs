namespace 個人專題.Staffs
{
    partial class frmFire
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
            this.dateTimePickerFireDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(344, 44);
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(85, 18);
            this.lblHeader.Text = " Fire Date";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(193, 172);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 172);
            // 
            // dateTimePickerFireDate
            // 
            this.dateTimePickerFireDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerFireDate.Location = new System.Drawing.Point(63, 103);
            this.dateTimePickerFireDate.Name = "dateTimePickerFireDate";
            this.dateTimePickerFireDate.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerFireDate.TabIndex = 3;
            // 
            // frmFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 253);
            this.Controls.Add(this.dateTimePickerFireDate);
            this.Name = "frmFire";
            this.Text = "frmFire";
            this.Load += new System.EventHandler(this.frmFire_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFireDate, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFireDate;
    }
}