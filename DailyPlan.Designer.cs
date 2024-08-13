namespace ArthurCalendarC_Winform
{
    partial class DailyPlan
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
            panel1 = new Panel();
            panel3 = new Panel();
            btnPreviousDay = new Button();
            btnNextDay = new Button();
            dtpDate = new DateTimePicker();
            pnlJob = new Panel();
            mnsMain = new MenuStrip();
            mnsiAddJob = new ToolStripMenuItem();
            mnsiToday = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            mnsMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnlJob);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 729);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPreviousDay);
            panel3.Controls.Add(btnNextDay);
            panel3.Controls.Add(dtpDate);
            panel3.Location = new Point(6, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1036, 49);
            panel3.TabIndex = 2;
            // 
            // btnPreviousDay
            // 
            btnPreviousDay.Location = new Point(6, 8);
            btnPreviousDay.Name = "btnPreviousDay";
            btnPreviousDay.Size = new Size(94, 29);
            btnPreviousDay.TabIndex = 2;
            btnPreviousDay.Text = "Hôm qua";
            btnPreviousDay.UseVisualStyleBackColor = true;
            btnPreviousDay.Click += btnPreviousDay_Click;
            // 
            // btnNextDay
            // 
            btnNextDay.Location = new Point(933, 8);
            btnNextDay.Name = "btnNextDay";
            btnNextDay.Size = new Size(94, 29);
            btnNextDay.TabIndex = 0;
            btnNextDay.Text = "Ngày mai";
            btnNextDay.UseVisualStyleBackColor = true;
            btnNextDay.Click += btnNextDay_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(401, 10);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 1;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // pnlJob
            // 
            pnlJob.Location = new Point(6, 58);
            pnlJob.Name = "pnlJob";
            pnlJob.Size = new Size(1036, 659);
            pnlJob.TabIndex = 0;
            // 
            // mnsMain
            // 
            mnsMain.ImageScalingSize = new Size(20, 20);
            mnsMain.Items.AddRange(new ToolStripItem[] { mnsiAddJob, mnsiToday });
            mnsMain.Location = new Point(0, 0);
            mnsMain.Name = "mnsMain";
            mnsMain.Size = new Size(1045, 28);
            mnsMain.TabIndex = 1;
            mnsMain.Text = "menuStrip1";
            // 
            // mnsiAddJob
            // 
            mnsiAddJob.Name = "mnsiAddJob";
            mnsiAddJob.Size = new Size(90, 24);
            mnsiAddJob.Text = "Thêm việc";
            mnsiAddJob.Click += mnsiAddJob_Click;
            // 
            // mnsiToday
            // 
            mnsiToday.Name = "mnsiToday";
            mnsiToday.Size = new Size(83, 24);
            mnsiToday.Text = "Hôm nay";
            mnsiToday.Click += mnsiToday_Click;
            // 
            // DailyPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 761);
            Controls.Add(panel1);
            Controls.Add(mnsMain);
            MainMenuStrip = mnsMain;
            Name = "DailyPlan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kế hoạch";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            mnsMain.ResumeLayout(false);
            mnsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel pnlJob;
        private DateTimePicker dtpDate;
        private MenuStrip mnsMain;
        private ToolStripMenuItem mnsiAddJob;
        private ToolStripMenuItem mnsiToday;
        private Button btnPreviousDay;
        private Button btnNextDay;
    }
}