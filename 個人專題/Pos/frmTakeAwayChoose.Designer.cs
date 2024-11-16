namespace 個人專題
{
    partial class frmTakeAwayChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeAwayChoose));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnUrgent = new System.Windows.Forms.RadioButton();
            this.rbtn1630 = new System.Windows.Forms.RadioButton();
            this.rbtn1530 = new System.Windows.Forms.RadioButton();
            this.rbtn1500 = new System.Windows.Forms.RadioButton();
            this.rbtn1600 = new System.Windows.Forms.RadioButton();
            this.rbtn1430 = new System.Windows.Forms.RadioButton();
            this.rbtn1400 = new System.Windows.Forms.RadioButton();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(502, 44);
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(97, 18);
            this.lblHeader.Text = "Self-Pickup";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(351, 286);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(416, 286);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnUrgent);
            this.groupBox1.Controls.Add(this.rbtn1630);
            this.groupBox1.Controls.Add(this.rbtn1530);
            this.groupBox1.Controls.Add(this.rbtn1500);
            this.groupBox1.Controls.Add(this.rbtn1600);
            this.groupBox1.Controls.Add(this.rbtn1430);
            this.groupBox1.Controls.Add(this.rbtn1400);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(131, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 216);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2 Time";
            // 
            // rbtnUrgent
            // 
            this.rbtnUrgent.AutoEllipsis = true;
            this.rbtnUrgent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtnUrgent.Location = new System.Drawing.Point(170, 87);
            this.rbtnUrgent.Name = "rbtnUrgent";
            this.rbtnUrgent.Size = new System.Drawing.Size(174, 96);
            this.rbtnUrgent.TabIndex = 10;
            this.rbtnUrgent.TabStop = true;
            this.rbtnUrgent.Text = "Urgent need: Please get in touch with our staff.";
            this.rbtnUrgent.UseVisualStyleBackColor = true;
            this.rbtnUrgent.CheckedChanged += new System.EventHandler(this.rbtnUrgent_CheckedChanged);
            // 
            // rbtn1630
            // 
            this.rbtn1630.AutoSize = true;
            this.rbtn1630.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtn1630.Location = new System.Drawing.Point(170, 56);
            this.rbtn1630.Name = "rbtn1630";
            this.rbtn1630.Size = new System.Drawing.Size(124, 25);
            this.rbtn1630.TabIndex = 9;
            this.rbtn1630.TabStop = true;
            this.rbtn1630.Text = "About 16:30";
            this.rbtn1630.UseVisualStyleBackColor = true;
            this.rbtn1630.CheckedChanged += new System.EventHandler(this.rbtn1630_CheckedChanged);
            // 
            // rbtn1530
            // 
            this.rbtn1530.AutoSize = true;
            this.rbtn1530.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtn1530.Location = new System.Drawing.Point(6, 134);
            this.rbtn1530.Name = "rbtn1530";
            this.rbtn1530.Size = new System.Drawing.Size(124, 25);
            this.rbtn1530.TabIndex = 7;
            this.rbtn1530.TabStop = true;
            this.rbtn1530.Text = "About 15:30";
            this.rbtn1530.UseVisualStyleBackColor = true;
            this.rbtn1530.CheckedChanged += new System.EventHandler(this.rbtn1530_CheckedChanged);
            // 
            // rbtn1500
            // 
            this.rbtn1500.AutoSize = true;
            this.rbtn1500.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtn1500.Location = new System.Drawing.Point(6, 92);
            this.rbtn1500.Name = "rbtn1500";
            this.rbtn1500.Size = new System.Drawing.Size(124, 25);
            this.rbtn1500.TabIndex = 6;
            this.rbtn1500.TabStop = true;
            this.rbtn1500.Text = "About 15:00";
            this.rbtn1500.UseVisualStyleBackColor = true;
            this.rbtn1500.CheckedChanged += new System.EventHandler(this.rbtn1500_CheckedChanged);
            // 
            // rbtn1600
            // 
            this.rbtn1600.AutoSize = true;
            this.rbtn1600.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtn1600.Location = new System.Drawing.Point(170, 21);
            this.rbtn1600.Name = "rbtn1600";
            this.rbtn1600.Size = new System.Drawing.Size(124, 25);
            this.rbtn1600.TabIndex = 8;
            this.rbtn1600.TabStop = true;
            this.rbtn1600.Text = "About 16:00";
            this.rbtn1600.UseVisualStyleBackColor = true;
            this.rbtn1600.CheckedChanged += new System.EventHandler(this.rbtn1600_CheckedChanged);
            // 
            // rbtn1430
            // 
            this.rbtn1430.AutoSize = true;
            this.rbtn1430.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtn1430.Location = new System.Drawing.Point(6, 56);
            this.rbtn1430.Name = "rbtn1430";
            this.rbtn1430.Size = new System.Drawing.Size(124, 25);
            this.rbtn1430.TabIndex = 5;
            this.rbtn1430.TabStop = true;
            this.rbtn1430.Text = "About 14:30";
            this.rbtn1430.UseVisualStyleBackColor = true;
            this.rbtn1430.CheckedChanged += new System.EventHandler(this.rbtn1430_CheckedChanged);
            // 
            // rbtn1400
            // 
            this.rbtn1400.AutoSize = true;
            this.rbtn1400.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtn1400.Location = new System.Drawing.Point(6, 21);
            this.rbtn1400.Name = "rbtn1400";
            this.rbtn1400.Size = new System.Drawing.Size(124, 25);
            this.rbtn1400.TabIndex = 4;
            this.rbtn1400.TabStop = true;
            this.rbtn1400.Text = "About 14:00";
            this.rbtn1400.UseVisualStyleBackColor = true;
            this.rbtn1400.CheckedChanged += new System.EventHandler(this.rbtn1400_CheckedChanged);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnToday.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToday.Location = new System.Drawing.Point(15, 95);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(110, 69);
            this.btnToday.TabIndex = 4;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.BackColor = System.Drawing.Color.White;
            this.btnTomorrow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTomorrow.Location = new System.Drawing.Point(15, 170);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(110, 72);
            this.btnTomorrow.TabIndex = 5;
            this.btnTomorrow.Text = "Tomorrow";
            this.btnTomorrow.UseVisualStyleBackColor = false;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "1";
            // 
            // frmTakeAwayChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTomorrow);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTakeAwayChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTakeAwayChoose";
            this.Load += new System.EventHandler(this.frmTakeAwayChoose_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnToday, 0);
            this.Controls.SetChildIndex(this.btnTomorrow, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn1430;
        private System.Windows.Forms.RadioButton rbtn1400;
        private System.Windows.Forms.RadioButton rbtn1630;
        private System.Windows.Forms.RadioButton rbtn1530;
        private System.Windows.Forms.RadioButton rbtn1500;
        private System.Windows.Forms.RadioButton rbtn1600;
        private System.Windows.Forms.RadioButton rbtnUrgent;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.Label label1;
    }
}