namespace 個人專題.Orders
{
    partial class frmViewOrderDetail
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
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.lblOID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Size = new System.Drawing.Size(157, 38);
            this.lblName.Text = "Order ID:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(516, 498);
            this.btnOK.Size = new System.Drawing.Size(11, 19);
            this.btnOK.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(605, 498);
            this.btnCancel.Size = new System.Drawing.Size(11, 19);
            this.btnCancel.Visible = false;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.Location = new System.Drawing.Point(581, 12);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(45, 104);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(536, 366);
            this.dgvOrderDetail.TabIndex = 20;
            // 
            // lblOID
            // 
            this.lblOID.Font = new System.Drawing.Font("Footlight MT Light", 26.25F, System.Drawing.FontStyle.Italic);
            this.lblOID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOID.Location = new System.Drawing.Point(196, 25);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(146, 38);
            this.lblOID.TabIndex = 21;
            // 
            // frmViewOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 529);
            this.Controls.Add(this.lblOID);
            this.Controls.Add(this.dgvOrderDetail);
            this.Name = "frmViewOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewOrderDetail";
            this.Load += new System.EventHandler(this.frmViewOrderDetail_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnCloseWindow, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.dgvOrderDetail, 0);
            this.Controls.SetChildIndex(this.lblOID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label lblOID;
    }
}