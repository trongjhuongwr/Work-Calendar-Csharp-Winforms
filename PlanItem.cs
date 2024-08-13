using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthurCalendarC_Winform
{
    public class PlanItem
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }

        private string job;
        public string Job { get => job; set => job = value; }

        private Point fromTime;
        public Point FromTime { get => fromTime; set => fromTime = value; }

        private Point toTime;
        public Point ToTime { get => toTime; set => toTime = value; }

        private string status;
        public string Status { get => status; set => status = value; }
        
        public static List<string> ListStatus = new List<string>() { "DONE", "DOING", "COMING", "MISSED" };
    }
    public enum EPlanItem
    {
        DONE,
        DOING,
        COMING,
        MISSED
    }
}
