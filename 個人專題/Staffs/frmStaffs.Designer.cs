namespace 個人專題
{
    partial class frmStaffs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStaffs = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnDeleteData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Location = new System.Drawing.Point(38, 44);
            // 
            // cBoxSearch
            // 
            this.cBoxSearch.Location = new System.Drawing.Point(93, 12);
            this.cBoxSearch.Size = new System.Drawing.Size(159, 25);
            this.cBoxSearch.SelectedIndexChanged += new System.EventHandler(this.cBoxSearch_SelectedIndexChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(267, 5);
            // 
            // dgvStaffs
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStaffs.Location = new System.Drawing.Point(44, 104);
            this.dgvStaffs.Name = "dgvStaffs";
            this.dgvStaffs.RowTemplate.Height = 24;
            this.dgvStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStaffs.Size = new System.Drawing.Size(713, 293);
            this.dgvStaffs.TabIndex = 18;
            this.dgvStaffs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffs_CellClick);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(267, 44);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(175, 29);
            this.dateTimePickerDate.TabIndex = 19;
            this.dateTimePickerDate.Value = new System.DateTime(2024, 7, 29, 0, 0, 0, 0);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnFire.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnFire.FlatAppearance.BorderSize = 2;
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFire.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnFire.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFire.Location = new System.Drawing.Point(487, 40);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(93, 42);
            this.btnFire.TabIndex = 20;
            this.btnFire.Text = "👣 Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteData.Location = new System.Drawing.Point(641, 403);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(116, 36);
            this.btnDeleteData.TabIndex = 21;
            this.btnDeleteData.Text = "Delete data";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // frmStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.dgvStaffs);
            this.Name = "frmStaffs";
            this.Text = "frmStaffs";
            this.Load += new System.EventHandler(this.frmStaffs_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSearchProducts, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.cBoxSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.dgvStaffs, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDate, 0);
            this.Controls.SetChildIndex(this.btnFire, 0);
            this.Controls.SetChildIndex(this.btnDeleteData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffs;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnDeleteData;
    }
}