namespace 個人專題
{
    partial class frmHistoryOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewOrderDetail = new System.Windows.Forms.Button();
            this.dgvHistoryOrders = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReestablish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.Location = new System.Drawing.Point(779, 5);
            this.btnAdd.Size = new System.Drawing.Size(14, 17);
            this.btnAdd.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.Location = new System.Drawing.Point(755, 6);
            this.btnEdit.Size = new System.Drawing.Size(15, 16);
            this.btnEdit.Visible = false;
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(756, 29);
            // 
            // cBoxSearch
            // 
            this.cBoxSearch.Location = new System.Drawing.Point(109, 12);
            this.cBoxSearch.Size = new System.Drawing.Size(143, 25);
            this.cBoxSearch.SelectedIndexChanged += new System.EventHandler(this.cBoxSearch_SelectedIndexChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpToDate.Location = new System.Drawing.Point(358, 50);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(161, 29);
            this.dtpToDate.TabIndex = 18;
            this.dtpToDate.Value = new System.DateTime(2024, 7, 26, 0, 0, 0, 0);
            // 
            // btnViewOrderDetail
            // 
            this.btnViewOrderDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(137)))), ((int)(((byte)(32)))));
            this.btnViewOrderDetail.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnViewOrderDetail.ForeColor = System.Drawing.Color.Beige;
            this.btnViewOrderDetail.Location = new System.Drawing.Point(624, 34);
            this.btnViewOrderDetail.Name = "btnViewOrderDetail";
            this.btnViewOrderDetail.Size = new System.Drawing.Size(146, 45);
            this.btnViewOrderDetail.TabIndex = 19;
            this.btnViewOrderDetail.Text = "View order details";
            this.btnViewOrderDetail.UseVisualStyleBackColor = false;
            this.btnViewOrderDetail.Click += new System.EventHandler(this.btnViewOrderDetail_Click);
            // 
            // dgvHistoryOrders
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoryOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistoryOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistoryOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistoryOrders.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvHistoryOrders.Location = new System.Drawing.Point(57, 98);
            this.dgvHistoryOrders.Name = "dgvHistoryOrders";
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvHistoryOrders.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistoryOrders.RowTemplate.Height = 24;
            this.dgvHistoryOrders.Size = new System.Drawing.Size(692, 273);
            this.dgvHistoryOrders.TabIndex = 20;
            this.dgvHistoryOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistoryOrders_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(323, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "To";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpFromDate.Location = new System.Drawing.Point(358, 12);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(161, 29);
            this.dtpFromDate.TabIndex = 22;
            this.dtpFromDate.Value = new System.DateTime(2024, 7, 26, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(302, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "From";
            // 
            // btnReestablish
            // 
            this.btnReestablish.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReestablish.Location = new System.Drawing.Point(626, 389);
            this.btnReestablish.Name = "btnReestablish";
            this.btnReestablish.Size = new System.Drawing.Size(123, 36);
            this.btnReestablish.TabIndex = 24;
            this.btnReestablish.Text = "Re-establish";
            this.btnReestablish.UseVisualStyleBackColor = true;
            this.btnReestablish.Click += new System.EventHandler(this.btnReestablish_Click);
            // 
            // frmHistoryOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReestablish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHistoryOrders);
            this.Controls.Add(this.btnViewOrderDetail);
            this.Controls.Add(this.dtpToDate);
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.Name = "frmHistoryOrders";
            this.Text = "frmHistoryOrders";
            this.Load += new System.EventHandler(this.frmHistoryOrders_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSearchProducts, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.cBoxSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.dtpToDate, 0);
            this.Controls.SetChildIndex(this.btnViewOrderDetail, 0);
            this.Controls.SetChildIndex(this.dgvHistoryOrders, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtpFromDate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnReestablish, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnViewOrderDetail;
        private System.Windows.Forms.DataGridView dgvHistoryOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReestablish;
    }
}