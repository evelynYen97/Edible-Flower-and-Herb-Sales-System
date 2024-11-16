namespace 個人專題.Products
{
    partial class frmProductsChangeChoose
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
            this.btnChooseCategory = new System.Windows.Forms.Button();
            this.btnChooseProduct = new System.Windows.Forms.Button();
            this.btnChooseSpecifications = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(75)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btnCloseWindow);
            this.panel1.Size = new System.Drawing.Size(578, 44);
            this.panel1.Controls.SetChildIndex(this.picHeader, 0);
            this.panel1.Controls.SetChildIndex(this.lblHeader, 0);
            this.panel1.Controls.SetChildIndex(this.btnCloseWindow, 0);
            // 
            // picHeader
            // 
            this.picHeader.Location = new System.Drawing.Point(80, 24);
            this.picHeader.Size = new System.Drawing.Size(13, 13);
            this.picHeader.UseWaitCursor = true;
            this.picHeader.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Size = new System.Drawing.Size(50, 37);
            this.lblHeader.Text = "✒️";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(509, 295);
            this.btnOK.Size = new System.Drawing.Size(18, 19);
            this.btnOK.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 295);
            this.btnCancel.Size = new System.Drawing.Size(18, 19);
            this.btnCancel.Visible = false;
            // 
            // btnChooseCategory
            // 
            this.btnChooseCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(173)))));
            this.btnChooseCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChooseCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChooseCategory.Location = new System.Drawing.Point(32, 146);
            this.btnChooseCategory.Name = "btnChooseCategory";
            this.btnChooseCategory.Size = new System.Drawing.Size(155, 71);
            this.btnChooseCategory.TabIndex = 3;
            this.btnChooseCategory.Text = "All Categories";
            this.btnChooseCategory.UseVisualStyleBackColor = false;
            this.btnChooseCategory.Click += new System.EventHandler(this.btnChooseCategory_Click);
            // 
            // btnChooseProduct
            // 
            this.btnChooseProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(182)))), ((int)(((byte)(162)))));
            this.btnChooseProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChooseProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChooseProduct.Location = new System.Drawing.Point(212, 146);
            this.btnChooseProduct.Name = "btnChooseProduct";
            this.btnChooseProduct.Size = new System.Drawing.Size(155, 71);
            this.btnChooseProduct.TabIndex = 4;
            this.btnChooseProduct.Text = "Product";
            this.btnChooseProduct.UseVisualStyleBackColor = false;
            this.btnChooseProduct.Click += new System.EventHandler(this.btnChooseProduct_Click);
            // 
            // btnChooseSpecifications
            // 
            this.btnChooseSpecifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(144)))), ((int)(((byte)(123)))));
            this.btnChooseSpecifications.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChooseSpecifications.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChooseSpecifications.Location = new System.Drawing.Point(386, 146);
            this.btnChooseSpecifications.Name = "btnChooseSpecifications";
            this.btnChooseSpecifications.Size = new System.Drawing.Size(155, 74);
            this.btnChooseSpecifications.TabIndex = 5;
            this.btnChooseSpecifications.Text = "Specifications";
            this.btnChooseSpecifications.UseVisualStyleBackColor = false;
            this.btnChooseSpecifications.Click += new System.EventHandler(this.btnChooseSpecifications_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCloseWindow.ForeColor = System.Drawing.Color.MintCream;
            this.btnCloseWindow.Location = new System.Drawing.Point(531, 6);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(35, 35);
            this.btnCloseWindow.TabIndex = 15;
            this.btnCloseWindow.Text = "❌";
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // frmProductsChangeChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(578, 338);
            this.Controls.Add(this.btnChooseSpecifications);
            this.Controls.Add(this.btnChooseProduct);
            this.Controls.Add(this.btnChooseCategory);
            this.Name = "frmProductsChangeChoose";
            this.Text = "frmProductsChangeChoose";
            this.Load += new System.EventHandler(this.frmProductsChangeChoose_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnChooseCategory, 0);
            this.Controls.SetChildIndex(this.btnChooseProduct, 0);
            this.Controls.SetChildIndex(this.btnChooseSpecifications, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseCategory;
        private System.Windows.Forms.Button btnChooseProduct;
        private System.Windows.Forms.Button btnChooseSpecifications;
        internal System.Windows.Forms.Button btnCloseWindow;
    }
}