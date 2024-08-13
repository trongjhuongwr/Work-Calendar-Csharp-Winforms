using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArthurCalendarC_Winform
{
    public partial class AJob : UserControl
    {
        private PlanItem job;
        public PlanItem Job { get => job; set => job = value; }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        public AJob(PlanItem job)
        {
            InitializeComponent();

            cbxStatus.DataSource = PlanItem.ListStatus;

            this.Job = job;

            ShowInfor();
        }

        void ShowInfor()
        {
            tbxJob.Text = Job.Job;

            nmrudFromHours.Value = Job.FromTime.X;
            nmrudFromMinutes.Value = Job.FromTime.Y;
            nmrudToHours.Value = Job.ToTime.X;
            nmrudToMinutes.Value = Job.ToTime.Y;

            cbxStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            cbxDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Job.Job = tbxJob.Text;

            Job.FromTime = new Point((int)nmrudFromHours.Value, (int)nmrudFromMinutes.Value);
            Job.ToTime = new Point((int)nmrudToHours.Value, (int)nmrudToMinutes.Value);
            Job.Status = PlanItem.ListStatus[cbxStatus.SelectedIndex];

            if (edited != null)
                edited(this, new EventArgs());
        }

        private void cbxDone_CheckedChanged(object sender, EventArgs e)
        {
            cbxStatus.SelectedIndex = cbxDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }
    }
}
