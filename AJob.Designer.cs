namespace ArthurCalendarC_Winform
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            cbxStatus = new ComboBox();
            nmrudToMinutes = new NumericUpDown();
            nmrudToHours = new NumericUpDown();
            lbTo = new Label();
            nmrudFromMinutes = new NumericUpDown();
            nmrudFromHours = new NumericUpDown();
            tbxJob = new TextBox();
            cbxDone = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrudToMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrudToHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrudFromMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrudFromHours).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tbxJob);
            panel1.Controls.Add(cbxDone);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 38);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(cbxStatus);
            panel2.Controls.Add(nmrudToMinutes);
            panel2.Controls.Add(nmrudToHours);
            panel2.Controls.Add(lbTo);
            panel2.Controls.Add(nmrudFromMinutes);
            panel2.Controls.Add(nmrudFromHours);
            panel2.Location = new Point(459, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(533, 32);
            panel2.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(471, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(59, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(410, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(59, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(256, 2);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(151, 28);
            cbxStatus.TabIndex = 7;
            // 
            // nmrudToMinutes
            // 
            nmrudToMinutes.Location = new Point(205, 3);
            nmrudToMinutes.Name = "nmrudToMinutes";
            nmrudToMinutes.Size = new Size(45, 27);
            nmrudToMinutes.TabIndex = 6;
            // 
            // nmrudToHours
            // 
            nmrudToHours.Location = new Point(150, 3);
            nmrudToHours.Name = "nmrudToHours";
            nmrudToHours.Size = new Size(45, 27);
            nmrudToHours.TabIndex = 5;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new Point(109, 5);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(36, 20);
            lbTo.TabIndex = 4;
            lbTo.Text = "Đến";
            // 
            // nmrudFromMinutes
            // 
            nmrudFromMinutes.Location = new Point(58, 3);
            nmrudFromMinutes.Name = "nmrudFromMinutes";
            nmrudFromMinutes.Size = new Size(45, 27);
            nmrudFromMinutes.TabIndex = 3;
            // 
            // nmrudFromHours
            // 
            nmrudFromHours.Location = new Point(3, 3);
            nmrudFromHours.Name = "nmrudFromHours";
            nmrudFromHours.Size = new Size(45, 27);
            nmrudFromHours.TabIndex = 2;
            // 
            // tbxJob
            // 
            tbxJob.Location = new Point(36, 5);
            tbxJob.Name = "tbxJob";
            tbxJob.Size = new Size(417, 27);
            tbxJob.TabIndex = 1;
            // 
            // cbxDone
            // 
            cbxDone.AutoSize = true;
            cbxDone.Location = new Point(8, 11);
            cbxDone.Name = "cbxDone";
            cbxDone.Size = new Size(18, 17);
            cbxDone.TabIndex = 0;
            cbxDone.UseVisualStyleBackColor = true;
            cbxDone.CheckedChanged += cbxDone_CheckedChanged;
            // 
            // AJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AJob";
            Size = new Size(998, 46);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrudToMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrudToHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrudFromMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrudFromHours).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox cbxDone;
        private TextBox tbxJob;
        private Panel panel2;
        private NumericUpDown nmrudFromMinutes;
        private NumericUpDown nmrudFromHours;
        private NumericUpDown nmrudToMinutes;
        private NumericUpDown nmrudToHours;
        private Label lbTo;
        private Button btnEdit;
        private ComboBox cbxStatus;
        private Button btnDelete;
    }
}
