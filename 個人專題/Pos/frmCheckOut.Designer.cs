namespace 個人專題
{
    partial class frmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckOut));
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblShippingPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblShippingDisCount = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioCredit = new System.Windows.Forms.RadioButton();
            this.lblClient = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lBoxOrderDetails = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(691, 44);
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(92, 18);
            this.lblHeader.Text = "Check Out";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Location = new System.Drawing.Point(514, 444);
            this.btnOK.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnOK.Size = new System.Drawing.Size(155, 72);
            this.btnOK.Text = "Place Order";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnCancel.Location = new System.Drawing.Point(378, 458);
            this.btnCancel.Size = new System.Drawing.Size(127, 58);
            this.btnCancel.Text = " Return to shopping";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "🛒 ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubtotal.Location = new System.Drawing.Point(87, 496);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(229, 26);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "Subtotal (0 item) : $ 0";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(349, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order Summary";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemPrice.Location = new System.Drawing.Point(442, 95);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(229, 26);
            this.lblItemPrice.TabIndex = 10;
            this.lblItemPrice.Text = " 0";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(350, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Shipping and Handling :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShippingPrice
            // 
            this.lblShippingPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShippingPrice.Location = new System.Drawing.Point(575, 145);
            this.lblShippingPrice.Name = "lblShippingPrice";
            this.lblShippingPrice.Size = new System.Drawing.Size(96, 26);
            this.lblShippingPrice.TabIndex = 12;
            this.lblShippingPrice.Text = "0";
            this.lblShippingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(345, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(346, 26);
            this.label10.TabIndex = 13;
            this.label10.Text = "————————————————————————";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(350, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Item : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(350, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 26);
            this.label11.TabIndex = 14;
            this.label11.Text = "Order Total : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(575, 203);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(96, 26);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = " $ 0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(349, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 22);
            this.label13.TabIndex = 16;
            this.label13.Text = "Shipping";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(350, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 26);
            this.label14.TabIndex = 17;
            this.label14.Text = "Discount Subtotal :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiscount.Location = new System.Drawing.Point(575, 119);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(96, 26);
            this.lblDiscount.TabIndex = 18;
            this.lblDiscount.Text = "0";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(350, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(257, 26);
            this.label16.TabIndex = 19;
            this.label16.Text = "Shipping Discount Subtotal :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShippingDisCount
            // 
            this.lblShippingDisCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingDisCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShippingDisCount.Location = new System.Drawing.Point(611, 171);
            this.lblShippingDisCount.Name = "lblShippingDisCount";
            this.lblShippingDisCount.Size = new System.Drawing.Size(60, 26);
            this.lblShippingDisCount.TabIndex = 20;
            this.lblShippingDisCount.Text = "0";
            this.lblShippingDisCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShipping
            // 
            this.lblShipping.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShipping.Location = new System.Drawing.Point(350, 284);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(304, 71);
            this.lblShipping.TabIndex = 21;
            this.lblShipping.Text = "Shipping";
            this.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(349, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Payment";
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioCash.Location = new System.Drawing.Point(364, 400);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(129, 21);
            this.radioCash.TabIndex = 23;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash on Delivery";
            this.radioCash.UseVisualStyleBackColor = true;
            this.radioCash.CheckedChanged += new System.EventHandler(this.radioCash_CheckedChanged);
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioCredit.Location = new System.Drawing.Point(514, 400);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(142, 21);
            this.radioCredit.TabIndex = 24;
            this.radioCredit.TabStop = true;
            this.radioCredit.Text = "Credit / Debit Card";
            this.radioCredit.UseVisualStyleBackColor = true;
            this.radioCredit.CheckedChanged += new System.EventHandler(this.radioCredit_CheckedChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClient.Location = new System.Drawing.Point(127, 59);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(104, 21);
            this.lblClient.TabIndex = 26;
            this.lblClient.Text = "Client Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(27, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 24);
            this.label18.TabIndex = 25;
            this.label18.Text = "👤Client：";
            // 
            // lBoxOrderDetails
            // 
            this.lBoxOrderDetails.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBoxOrderDetails.FormattingEnabled = true;
            this.lBoxOrderDetails.ItemHeight = 24;
            this.lBoxOrderDetails.Location = new System.Drawing.Point(39, 120);
            this.lBoxOrderDetails.Name = "lBoxOrderDetails";
            this.lBoxOrderDetails.Size = new System.Drawing.Size(277, 364);
            this.lBoxOrderDetails.TabIndex = 42;
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 540);
            this.Controls.Add(this.lBoxOrderDetails);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.radioCredit);
            this.Controls.Add(this.radioCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblShippingDisCount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblShippingPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label3);
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblSubtotal, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblItemPrice, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblShippingPrice, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.lblTotalPrice, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.lblDiscount, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.lblShippingDisCount, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblShipping, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.radioCash, 0);
            this.Controls.SetChildIndex(this.radioCredit, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.lBoxOrderDetails, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblShippingPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblShippingDisCount;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioCredit;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lBoxOrderDetails;
    }
}