namespace 個人專題.Pos
{
    partial class frmProductsDetialChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductsDetialChoose));
            this.lblProductChoose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btn減 = new System.Windows.Forms.Button();
            this.btn加 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(793, 44);
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(241, 18);
            this.lblHeader.Text = "Select product specifications";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(642, 476);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(707, 476);
            // 
            // lblProductChoose
            // 
            this.lblProductChoose.AutoSize = true;
            this.lblProductChoose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductChoose.Location = new System.Drawing.Point(199, 77);
            this.lblProductChoose.Name = "lblProductChoose";
            this.lblProductChoose.Size = new System.Drawing.Size(120, 21);
            this.lblProductChoose.TabIndex = 12;
            this.lblProductChoose.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Name：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(215, 313);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(151, 33);
            this.txtAmount.TabIndex = 14;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // btn減
            // 
            this.btn減.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn減.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn減.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn減.Location = new System.Drawing.Point(131, 297);
            this.btn減.Name = "btn減";
            this.btn減.Size = new System.Drawing.Size(65, 65);
            this.btn減.TabIndex = 25;
            this.btn減.Text = "-";
            this.btn減.UseVisualStyleBackColor = false;
            this.btn減.Click += new System.EventHandler(this.btn減_Click);
            // 
            // btn加
            // 
            this.btn加.BackColor = System.Drawing.Color.RosyBrown;
            this.btn加.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn加.Location = new System.Drawing.Point(381, 297);
            this.btn加.Name = "btn加";
            this.btn加.Size = new System.Drawing.Size(65, 65);
            this.btn加.TabIndex = 24;
            this.btn加.Text = "+";
            this.btn加.UseVisualStyleBackColor = false;
            this.btn加.Click += new System.EventHandler(this.btn加_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(463, 297);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 65);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmProductsDetialChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(793, 557);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn減);
            this.Controls.Add(this.btn加);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductChoose);
            this.Controls.Add(this.label2);
            this.Name = "frmProductsDetialChoose";
            this.Text = "frmProductsDetialChoose";
            this.Load += new System.EventHandler(this.frmProductsDetialChoose_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblProductChoose, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtAmount, 0);
            this.Controls.SetChildIndex(this.btn加, 0);
            this.Controls.SetChildIndex(this.btn減, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btn減;
        private System.Windows.Forms.Button btn加;
        private System.Windows.Forms.Button btnReset;
    }
}