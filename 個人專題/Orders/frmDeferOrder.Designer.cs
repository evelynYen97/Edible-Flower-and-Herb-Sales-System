namespace 個人專題.Orders
{
    partial class frmDeferOrder
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
            this.dateTimePickerDefer = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDateNow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(396, 44);
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(103, 18);
            this.lblHeader.Text = "Defer Order";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(245, 218);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 218);
            // 
            // dateTimePickerDefer
            // 
            this.dateTimePickerDefer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerDefer.Location = new System.Drawing.Point(104, 161);
            this.dateTimePickerDefer.Name = "dateTimePickerDefer";
            this.dateTimePickerDefer.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerDefer.TabIndex = 3;
            // 
            // lblDeliveryDateNow
            // 
            this.lblDeliveryDateNow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeliveryDateNow.Location = new System.Drawing.Point(104, 95);
            this.lblDeliveryDateNow.Name = "lblDeliveryDateNow";
            this.lblDeliveryDateNow.Size = new System.Drawing.Size(200, 23);
            this.lblDeliveryDateNow.TabIndex = 4;
            this.lblDeliveryDateNow.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date of delivery now :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Defer to :";
            // 
            // frmDeferOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDeliveryDateNow);
            this.Controls.Add(this.dateTimePickerDefer);
            this.Name = "frmDeferOrder";
            this.Text = "frmDeferOrder";
            this.Load += new System.EventHandler(this.frmDeferOrder_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDefer, 0);
            this.Controls.SetChildIndex(this.lblDeliveryDateNow, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDefer;
        private System.Windows.Forms.Label lblDeliveryDateNow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}