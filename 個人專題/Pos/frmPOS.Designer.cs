namespace 個人專題
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReservationCancel = new System.Windows.Forms.Button();
            this.lblReservation = new System.Windows.Forms.Label();
            this.cBoxClientsName = new System.Windows.Forms.ComboBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.pBoxClosePos = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.btnAllCategories = new System.Windows.Forms.Button();
            this.imageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.lBoxOrderDetails = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClosePos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 668);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.btnReservationCancel);
            this.panel3.Controls.Add(this.lblReservation);
            this.panel3.Controls.Add(this.cBoxClientsName);
            this.panel3.Controls.Add(this.lblOrder);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnReservation);
            this.panel3.Controls.Add(this.btnTakeAway);
            this.panel3.Controls.Add(this.btnDelivery);
            this.panel3.Controls.Add(this.pBoxClosePos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 100);
            this.panel3.TabIndex = 1;
            // 
            // btnReservationCancel
            // 
            this.btnReservationCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReservationCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnReservationCancel.Location = new System.Drawing.Point(633, 12);
            this.btnReservationCancel.Name = "btnReservationCancel";
            this.btnReservationCancel.Size = new System.Drawing.Size(115, 45);
            this.btnReservationCancel.TabIndex = 41;
            this.btnReservationCancel.Text = "Reservation Cancel";
            this.btnReservationCancel.UseVisualStyleBackColor = false;
            this.btnReservationCancel.Click += new System.EventHandler(this.btnReservationCancel_Click);
            // 
            // lblReservation
            // 
            this.lblReservation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReservation.Location = new System.Drawing.Point(495, 19);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(125, 30);
            this.lblReservation.TabIndex = 40;
            // 
            // cBoxClientsName
            // 
            this.cBoxClientsName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxClientsName.FormattingEnabled = true;
            this.cBoxClientsName.Location = new System.Drawing.Point(54, 59);
            this.cBoxClientsName.Name = "cBoxClientsName";
            this.cBoxClientsName.Size = new System.Drawing.Size(211, 28);
            this.cBoxClientsName.TabIndex = 39;
            // 
            // lblOrder
            // 
            this.lblOrder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrder.Location = new System.Drawing.Point(495, 59);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(191, 30);
            this.lblOrder.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = " 👤 Client Name:";
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReservation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.Location = new System.Drawing.Point(760, 12);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnReservation.Size = new System.Drawing.Size(95, 75);
            this.btnReservation.TabIndex = 30;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            this.btnReservation.MouseLeave += new System.EventHandler(this.btnReservation_MouseLeave);
            this.btnReservation.MouseHover += new System.EventHandler(this.btnReservation_MouseHover);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTakeAway.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeAway.Image")));
            this.btnTakeAway.Location = new System.Drawing.Point(394, 10);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnTakeAway.Size = new System.Drawing.Size(95, 75);
            this.btnTakeAway.TabIndex = 27;
            this.btnTakeAway.Text = "Self-Pickup";
            this.btnTakeAway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            this.btnTakeAway.MouseLeave += new System.EventHandler(this.btnTakeAway_MouseLeave);
            this.btnTakeAway.MouseHover += new System.EventHandler(this.btnTakeAway_MouseHover);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDelivery.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.Image = ((System.Drawing.Image)(resources.GetObject("btnDelivery.Image")));
            this.btnDelivery.Location = new System.Drawing.Point(293, 10);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDelivery.Size = new System.Drawing.Size(95, 75);
            this.btnDelivery.TabIndex = 26;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            this.btnDelivery.MouseLeave += new System.EventHandler(this.btnDelivery_MouseLeave);
            this.btnDelivery.MouseHover += new System.EventHandler(this.btnDelivery_MouseHover);
            // 
            // pBoxClosePos
            // 
            this.pBoxClosePos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.pBoxClosePos.Image = ((System.Drawing.Image)(resources.GetObject("pBoxClosePos.Image")));
            this.pBoxClosePos.Location = new System.Drawing.Point(899, 27);
            this.pBoxClosePos.Name = "pBoxClosePos";
            this.pBoxClosePos.Size = new System.Drawing.Size(40, 40);
            this.pBoxClosePos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxClosePos.TabIndex = 25;
            this.pBoxClosePos.TabStop = false;
            this.pBoxClosePos.Click += new System.EventHandler(this.pBoxClosePos_Click);
            this.pBoxClosePos.MouseLeave += new System.EventHandler(this.pBoxClosePos_MouseLeave);
            this.pBoxClosePos.MouseHover += new System.EventHandler(this.pBoxClosePos_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Categories";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnDeleteAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteAll.FlatAppearance.BorderSize = 3;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.Location = new System.Drawing.Point(669, 583);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnDeleteAll.Size = new System.Drawing.Size(124, 57);
            this.btnDeleteAll.TabIndex = 35;
            this.btnDeleteAll.Text = "   Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCheckOut.FlatAppearance.BorderSize = 3;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(814, 583);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnCheckOut.Size = new System.Drawing.Size(135, 57);
            this.btnCheckOut.TabIndex = 36;
            this.btnCheckOut.Text = "   Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Subtotal: $";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(744, 534);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 22);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = " 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listViewProducts
            // 
            this.listViewProducts.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewProducts.BackColor = System.Drawing.SystemColors.Control;
            this.listViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(204, 154);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(405, 498);
            this.listViewProducts.TabIndex = 39;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.ItemActivate += new System.EventHandler(this.listViewProducts_ItemActivate);
            // 
            // btnAllCategories
            // 
            this.btnAllCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnAllCategories.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCategories.ForeColor = System.Drawing.Color.White;
            this.btnAllCategories.Location = new System.Drawing.Point(22, 168);
            this.btnAllCategories.Name = "btnAllCategories";
            this.btnAllCategories.Size = new System.Drawing.Size(176, 60);
            this.btnAllCategories.TabIndex = 40;
            this.btnAllCategories.Text = "All Categories";
            this.btnAllCategories.UseVisualStyleBackColor = false;
            this.btnAllCategories.Click += new System.EventHandler(this.btnAllCategories_Click);
            // 
            // imageList商品圖檔
            // 
            this.imageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList商品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lBoxOrderDetails
            // 
            this.lBoxOrderDetails.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBoxOrderDetails.FormattingEnabled = true;
            this.lBoxOrderDetails.ItemHeight = 24;
            this.lBoxOrderDetails.Location = new System.Drawing.Point(625, 180);
            this.lBoxOrderDetails.Name = "lBoxOrderDetails";
            this.lBoxOrderDetails.Size = new System.Drawing.Size(314, 340);
            this.lBoxOrderDetails.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Order details";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(884, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10);
            this.btnDelete.Size = new System.Drawing.Size(55, 55);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "       ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 768);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lBoxOrderDetails);
            this.Controls.Add(this.btnAllCategories);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Activated += new System.EventHandler(this.frmPOS_Activated);
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClosePos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pBoxClosePos;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ComboBox cBoxClientsName;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Button btnAllCategories;
        private System.Windows.Forms.ImageList imageList商品圖檔;
        private System.Windows.Forms.ListBox lBoxOrderDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Button btnReservationCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}