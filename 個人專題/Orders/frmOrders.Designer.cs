namespace 個人專題
{
    partial class frmOrders
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
            this.dgvAllOrders = new System.Windows.Forms.DataGridView();
            this.btnViewODetails = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDefer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.Location = new System.Drawing.Point(630, 399);
            this.btnAdd.Size = new System.Drawing.Size(123, 42);
            this.btnAdd.Text = "√ Completed";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.Location = new System.Drawing.Point(664, 40);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Enabled = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Size = new System.Drawing.Size(756, 29);
            // 
            // cBoxSearch
            // 
            this.cBoxSearch.Location = new System.Drawing.Point(107, 12);
            this.cBoxSearch.Size = new System.Drawing.Size(145, 25);
            this.cBoxSearch.SelectedIndexChanged += new System.EventHandler(this.cBoxSearch_SelectedIndexChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // dgvAllOrders
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllOrders.Location = new System.Drawing.Point(60, 117);
            this.dgvAllOrders.Name = "dgvAllOrders";
            this.dgvAllOrders.RowTemplate.Height = 24;
            this.dgvAllOrders.Size = new System.Drawing.Size(693, 256);
            this.dgvAllOrders.TabIndex = 18;
            this.dgvAllOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllOrders_CellClick);
            // 
            // btnViewODetails
            // 
            this.btnViewODetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.btnViewODetails.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnViewODetails.FlatAppearance.BorderSize = 2;
            this.btnViewODetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewODetails.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnViewODetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewODetails.Location = new System.Drawing.Point(486, 40);
            this.btnViewODetails.Name = "btnViewODetails";
            this.btnViewODetails.Size = new System.Drawing.Size(163, 42);
            this.btnViewODetails.TabIndex = 19;
            this.btnViewODetails.Text = "🗃️ View order details";
            this.btnViewODetails.UseVisualStyleBackColor = false;
            this.btnViewODetails.Click += new System.EventHandler(this.btnViewODetails_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Location = new System.Drawing.Point(501, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 42);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "x Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDefer
            // 
            this.btnDefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.btnDefer.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnDefer.FlatAppearance.BorderSize = 2;
            this.btnDefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnDefer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDefer.Location = new System.Drawing.Point(372, 399);
            this.btnDefer.Name = "btnDefer";
            this.btnDefer.Size = new System.Drawing.Size(123, 42);
            this.btnDefer.TabIndex = 21;
            this.btnDefer.Text = "🤚 Defer";
            this.btnDefer.UseVisualStyleBackColor = false;
            this.btnDefer.Click += new System.EventHandler(this.btnDefer_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnDefer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnViewODetails);
            this.Controls.Add(this.dgvAllOrders);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.Activated += new System.EventHandler(this.frmOrders_Activated);
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSearchProducts, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.cBoxSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.dgvAllOrders, 0);
            this.Controls.SetChildIndex(this.btnViewODetails, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnDefer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllOrders;
        private System.Windows.Forms.Button btnViewODetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDefer;
    }
}