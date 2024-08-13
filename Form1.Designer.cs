namespace ArthurCalendarC_Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            lbMinute = new Label();
            nudNotify = new NumericUpDown();
            cbNotify = new CheckBox();
            btToday = new Button();
            dtpDate = new DateTimePicker();
            panel2 = new Panel();
            pnlMatrix = new Panel();
            panel4 = new Panel();
            btNextMonth = new Button();
            btPreviousMonth = new Button();
            btSunday = new Button();
            btSaturday = new Button();
            btFriday = new Button();
            btThursday = new Button();
            btWednesday = new Button();
            btTuesday = new Button();
            btMonday = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNotify).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1233, 573);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(btToday);
            panel3.Controls.Add(dtpDate);
            panel3.Location = new Point(5, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(1220, 44);
            panel3.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(lbMinute);
            panel6.Controls.Add(nudNotify);
            panel6.Controls.Add(cbNotify);
            panel6.Location = new Point(8, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(347, 38);
            panel6.TabIndex = 10;
            // 
            // lbMinute
            // 
            lbMinute.AutoSize = true;
            lbMinute.Location = new Point(186, 8);
            lbMinute.Name = "lbMinute";
            lbMinute.Size = new Size(38, 20);
            lbMinute.TabIndex = 2;
            lbMinute.Text = "Phút";
            // 
            // nudNotify
            // 
            nudNotify.Location = new Point(121, 6);
            nudNotify.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nudNotify.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNotify.Name = "nudNotify";
            nudNotify.Size = new Size(59, 27);
            nudNotify.TabIndex = 1;
            nudNotify.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbNotify
            // 
            cbNotify.AutoSize = true;
            cbNotify.Location = new Point(12, 7);
            cbNotify.Name = "cbNotify";
            cbNotify.Size = new Size(103, 24);
            cbNotify.TabIndex = 0;
            cbNotify.Text = "Thông báo";
            cbNotify.UseVisualStyleBackColor = true;
            // 
            // btToday
            // 
            btToday.BackColor = SystemColors.ControlLight;
            btToday.Location = new Point(763, 7);
            btToday.Name = "btToday";
            btToday.Size = new Size(94, 29);
            btToday.TabIndex = 0;
            btToday.Text = "Hôm nay";
            btToday.UseVisualStyleBackColor = false;
            btToday.Click += btToday_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(484, 9);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 0;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlMatrix);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(9, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1216, 512);
            panel2.TabIndex = 0;
            // 
            // pnlMatrix
            // 
            pnlMatrix.Location = new Point(250, 72);
            pnlMatrix.Name = "pnlMatrix";
            pnlMatrix.Size = new Size(757, 433);
            pnlMatrix.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btNextMonth);
            panel4.Controls.Add(btPreviousMonth);
            panel4.Controls.Add(btSunday);
            panel4.Controls.Add(btSaturday);
            panel4.Controls.Add(btFriday);
            panel4.Controls.Add(btThursday);
            panel4.Controls.Add(btWednesday);
            panel4.Controls.Add(btTuesday);
            panel4.Controls.Add(btMonday);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1210, 63);
            panel4.TabIndex = 1;
            // 
            // btNextMonth
            // 
            btNextMonth.BackColor = SystemColors.ControlLight;
            btNextMonth.Location = new Point(1032, 3);
            btNextMonth.Name = "btNextMonth";
            btNextMonth.Size = new Size(103, 57);
            btNextMonth.TabIndex = 9;
            btNextMonth.Text = "Tháng sau";
            btNextMonth.UseVisualStyleBackColor = false;
            btNextMonth.Click += btNextMonth_Click;
            // 
            // btPreviousMonth
            // 
            btPreviousMonth.BackColor = SystemColors.ControlLight;
            btPreviousMonth.Location = new Point(112, 3);
            btPreviousMonth.Name = "btPreviousMonth";
            btPreviousMonth.Size = new Size(103, 57);
            btPreviousMonth.TabIndex = 8;
            btPreviousMonth.Text = "Tháng trước";
            btPreviousMonth.UseVisualStyleBackColor = false;
            btPreviousMonth.Click += btPreviousMonth_Click;
            // 
            // btSunday
            // 
            btSunday.Location = new Point(901, 3);
            btSunday.Name = "btSunday";
            btSunday.Size = new Size(103, 57);
            btSunday.TabIndex = 7;
            btSunday.Text = "Chủ nhật";
            btSunday.UseVisualStyleBackColor = true;
            btSunday.Click += btSunday_Click;
            // 
            // btSaturday
            // 
            btSaturday.Location = new Point(792, 3);
            btSaturday.Name = "btSaturday";
            btSaturday.Size = new Size(103, 57);
            btSaturday.TabIndex = 6;
            btSaturday.Text = "Thứ 7";
            btSaturday.UseVisualStyleBackColor = true;
            btSaturday.Click += btSaturday_Click;
            // 
            // btFriday
            // 
            btFriday.Location = new Point(683, 3);
            btFriday.Name = "btFriday";
            btFriday.Size = new Size(103, 57);
            btFriday.TabIndex = 5;
            btFriday.Text = "Thứ 6";
            btFriday.UseVisualStyleBackColor = true;
            btFriday.Click += btFriday_Click;
            // 
            // btThursday
            // 
            btThursday.Location = new Point(574, 3);
            btThursday.Name = "btThursday";
            btThursday.Size = new Size(103, 57);
            btThursday.TabIndex = 4;
            btThursday.Text = "Thứ 5";
            btThursday.UseVisualStyleBackColor = true;
            btThursday.Click += btThursday_Click;
            // 
            // btWednesday
            // 
            btWednesday.Location = new Point(465, 3);
            btWednesday.Name = "btWednesday";
            btWednesday.Size = new Size(103, 57);
            btWednesday.TabIndex = 3;
            btWednesday.Text = "Thứ 4";
            btWednesday.UseVisualStyleBackColor = true;
            btWednesday.Click += btWednesday_Click;
            // 
            // btTuesday
            // 
            btTuesday.Location = new Point(356, 3);
            btTuesday.Name = "btTuesday";
            btTuesday.Size = new Size(103, 57);
            btTuesday.TabIndex = 2;
            btTuesday.Text = "Thứ 3";
            btTuesday.UseVisualStyleBackColor = true;
            btTuesday.Click += btTuesday_Click;
            // 
            // btMonday
            // 
            btMonday.Location = new Point(247, 3);
            btMonday.Name = "btMonday";
            btMonday.Size = new Size(103, 57);
            btMonday.TabIndex = 1;
            btMonday.Text = "Thứ 2";
            btMonday.UseVisualStyleBackColor = true;
            btMonday.Click += btMonday_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1240, 583);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch công việc";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNotify).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DateTimePicker dtpDate;
        private Panel panel2;
        private Panel pnlMatrix;
        private Panel panel4;
        private Button btToday;
        private Button btSunday;
        private Button btSaturday;
        private Button btFriday;
        private Button btThursday;
        private Button btWednesday;
        private Button btTuesday;
        private Button btMonday;
        private Button btPreviousMonth;
        private Button btNextMonth;
        private Panel panel6;
        private NumericUpDown nudNotify;
        private CheckBox cbNotify;
        private Label lbMinute;
    }
}
