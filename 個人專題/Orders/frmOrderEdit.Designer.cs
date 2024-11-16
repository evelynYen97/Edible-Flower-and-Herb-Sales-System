namespace 個人專題.Orders
{
    partial class frmOrderEdit
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
            this.lblOID = new System.Windows.Forms.Label();
            this.groupBoxDESC = new System.Windows.Forms.GroupBox();
            this.radioCredit = new System.Windows.Forms.RadioButton();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioDelivery = new System.Windows.Forms.RadioButton();
            this.radioSelf = new System.Windows.Forms.RadioButton();
            this.radioRSelf = new System.Windows.Forms.RadioButton();
            this.radioRDelivery = new System.Windows.Forms.RadioButton();
            this.groupBoxDESC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Size = new System.Drawing.Size(166, 38);
            this.lblName.Text = "Order ID :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(512, 438);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(601, 474);
            this.btnCancel.Size = new System.Drawing.Size(10, 12);
            this.btnCancel.Visible = false;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.Location = new System.Drawing.Point(576, 12);
            // 
            // lblOID
            // 
            this.lblOID.Font = new System.Drawing.Font("Footlight MT Light", 26.25F, System.Drawing.FontStyle.Italic);
            this.lblOID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOID.Location = new System.Drawing.Point(205, 25);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(146, 38);
            this.lblOID.TabIndex = 22;
            // 
            // groupBoxDESC
            // 
            this.groupBoxDESC.Controls.Add(this.radioCredit);
            this.groupBoxDESC.Controls.Add(this.radioCash);
            this.groupBoxDESC.Location = new System.Drawing.Point(65, 273);
            this.groupBoxDESC.Name = "groupBoxDESC";
            this.groupBoxDESC.Size = new System.Drawing.Size(522, 142);
            this.groupBoxDESC.TabIndex = 23;
            this.groupBoxDESC.TabStop = false;
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.radioCredit.Location = new System.Drawing.Point(250, 49);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(172, 22);
            this.radioCredit.TabIndex = 1;
            this.radioCredit.TabStop = true;
            this.radioCredit.Text = "Credit / Debit Card";
            this.radioCredit.UseVisualStyleBackColor = true;
            this.radioCredit.CheckedChanged += new System.EventHandler(this.radioCredit_CheckedChanged);
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.radioCash.Location = new System.Drawing.Point(37, 49);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(160, 22);
            this.radioCash.TabIndex = 0;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash on Delivery";
            this.radioCash.UseVisualStyleBackColor = true;
            this.radioCash.CheckedChanged += new System.EventHandler(this.radioCash_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.label8.Location = new System.Drawing.Point(61, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Mode of payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(61, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Order description";
            // 
            // radioDelivery
            // 
            this.radioDelivery.AutoSize = true;
            this.radioDelivery.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.radioDelivery.Location = new System.Drawing.Point(93, 128);
            this.radioDelivery.Name = "radioDelivery";
            this.radioDelivery.Size = new System.Drawing.Size(143, 22);
            this.radioDelivery.TabIndex = 2;
            this.radioDelivery.TabStop = true;
            this.radioDelivery.Text = " Delivery order";
            this.radioDelivery.UseVisualStyleBackColor = true;
            this.radioDelivery.CheckedChanged += new System.EventHandler(this.radioDelivery_CheckedChanged);
            // 
            // radioSelf
            // 
            this.radioSelf.AutoSize = true;
            this.radioSelf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSelf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.radioSelf.Location = new System.Drawing.Point(93, 178);
            this.radioSelf.Name = "radioSelf";
            this.radioSelf.Size = new System.Drawing.Size(169, 22);
            this.radioSelf.TabIndex = 39;
            this.radioSelf.TabStop = true;
            this.radioSelf.Text = " Self-pickup Order";
            this.radioSelf.UseVisualStyleBackColor = true;
            this.radioSelf.CheckedChanged += new System.EventHandler(this.radioSelf_CheckedChanged);
            // 
            // radioRSelf
            // 
            this.radioRSelf.AutoSize = true;
            this.radioRSelf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRSelf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.radioRSelf.Location = new System.Drawing.Point(301, 189);
            this.radioRSelf.Name = "radioRSelf";
            this.radioRSelf.Size = new System.Drawing.Size(266, 22);
            this.radioRSelf.TabIndex = 40;
            this.radioRSelf.TabStop = true;
            this.radioRSelf.Text = "Reservation Self-pickup Order";
            this.radioRSelf.UseVisualStyleBackColor = true;
            this.radioRSelf.CheckedChanged += new System.EventHandler(this.radioRSelf_CheckedChanged);
            // 
            // radioRDelivery
            // 
            this.radioRDelivery.AutoSize = true;
            this.radioRDelivery.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(72)))));
            this.radioRDelivery.Location = new System.Drawing.Point(301, 128);
            this.radioRDelivery.Name = "radioRDelivery";
            this.radioRDelivery.Size = new System.Drawing.Size(240, 22);
            this.radioRDelivery.TabIndex = 41;
            this.radioRDelivery.TabStop = true;
            this.radioRDelivery.Text = "Reservation Delivery order";
            this.radioRDelivery.UseVisualStyleBackColor = true;
            this.radioRDelivery.CheckedChanged += new System.EventHandler(this.radioRDelivery_CheckedChanged);
            // 
            // frmOrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 498);
            this.Controls.Add(this.radioRDelivery);
            this.Controls.Add(this.radioRSelf);
            this.Controls.Add(this.radioSelf);
            this.Controls.Add(this.radioDelivery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBoxDESC);
            this.Controls.Add(this.lblOID);
            this.Name = "frmOrderEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderEdit";
            this.Load += new System.EventHandler(this.frmOrderEdit_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnCloseWindow, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblOID, 0);
            this.Controls.SetChildIndex(this.groupBoxDESC, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.radioDelivery, 0);
            this.Controls.SetChildIndex(this.radioSelf, 0);
            this.Controls.SetChildIndex(this.radioRSelf, 0);
            this.Controls.SetChildIndex(this.radioRDelivery, 0);
            this.groupBoxDESC.ResumeLayout(false);
            this.groupBoxDESC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOID;
        private System.Windows.Forms.GroupBox groupBoxDESC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioCredit;
        private System.Windows.Forms.RadioButton radioDelivery;
        private System.Windows.Forms.RadioButton radioSelf;
        private System.Windows.Forms.RadioButton radioRSelf;
        private System.Windows.Forms.RadioButton radioRDelivery;
    }
}