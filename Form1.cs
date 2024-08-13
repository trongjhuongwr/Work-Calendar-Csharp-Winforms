using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArthurCalendarC_Winform
{
    public partial class Form1 : Form
    {
        #region Peoperties
        private string filePath = "data.xml";

        //Tạo ma trận các button
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        private PlanData job;

        //Tạo ra một List thứ để sử dụng ở hàm AddNumberIntoMatrixByDate()
        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion

        public Form1()
        {
            InitializeComponent();

            LoadMatrix();

            try
            {
                Job = DeserializeFromXML(filePath) as PlanData;
            }
            catch
            {
                SetDefaultJob();
            }
        }

        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Test",
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]
            });
        }


        // Tạo ra ma trận 6x7 (6 hàng, 7 cột) các ô vuông trên lịch
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>(); //Khởi tạo ma trận

            // Tạo ô vuông nút bấm cũ, dùng để xác định các vị trí nút bấm đã có
            Button oldButton = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(-Cons.margin, 0)
            };

            // Vòng lặp tạo ma trận
            for (int i = 0; i < Cons.DayOfRow; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    // Tạo ô vuông nút bấm trong ma trận
                    Button btn = new Button()
                    {
                        Width = Cons.dateButtonWidth,
                        Height = Cons.dateButtonHeight,
                    };
                    //Location của ô vuông mới sẽ tính toán dựa trên ô vuông cũ (tránh trùng lặp vị trí)
                    btn.Location = new Point(oldButton.Location.X + oldButton.Width + Cons.margin, oldButton.Location.Y);
                    btn.Click += btn_Click;

                    pnlMatrix.Controls.Add(btn); //Thêm ô vuông ngày vào panel Matrix
                    Matrix[i].Add(btn);

                    oldButton = btn;
                }

                // Reset button sau mỗi lần lặp
                oldButton = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(-Cons.margin, oldButton.Location.Y + Cons.dateButtonHeight + Cons.margin)
                };
            }

            SetDefaultDate();
        }

        void btn_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyPlan daily = new DailyPlan(new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            daily.ShowDialog();
        }

        //Tạo ra hàm DateOfMonth() trả ra số ngày của tháng để hỗ trợ AddNumberIntoMatrixByDate()
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }


        // Thêm số ngày theo tháng
        void AddNumberIntoMatrixByDate(DateTime date) //Ngày truyền vô ở đây để mình xác định được đó là của tháng nào, năm nào
        {
            ClearMatrix();

            //Tạo useDate bắt đầu từ ngày 1
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                /*
                 *Tạo ra column để xác định ngày tương ứng nằm trên cột thứ mấy bằng cách sử dụng IndexOf
                 *Ví dụ: Thứ 2 là cột 0 (column = 0)...
                 */
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.LightGreen;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        void SetDefaultDate()
        {
            dtpDate.Value = DateTime.Now;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }


        //Tạo sự kiện khi ấn vào các nút Hôm nay, Tháng sau, Tháng trước
        private void btToday_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }
        private void btNextMonth_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddMonths(1);
        }
        private void btPreviousMonth_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddMonths(-1);
        }


        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            sr.Serialize(fs, data);

            fs.Close();
        }

        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));

                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filePath);
        }


        //Tạo sự kiện khi ấn vào Thứ 2, 3, 4, 5, 6, 7, CN
        private void btMonday_Click(object sender, EventArgs e)
        {
            ClearMatrix();
            SetDefaultDate();
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.BackColor = Color.LightBlue;
                }
            }
        }
        private void btTuesday_Click(object sender, EventArgs e)
        {
            ClearMatrix();
            SetDefaultDate();
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 1; j < 2; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.BackColor = Color.LightBlue;
                }
            }
        }
        private void btWednesday_Click(object sender, EventArgs e)
        {
            ClearMatrix();
            SetDefaultDate();
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 2; j < 3; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.BackColor = Color.LightBlue;
                }
            }
        }
        private void btThursday_Click(object sender, EventArgs e)
        {
            ClearMatrix();
            SetDefaultDate();
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 3; j < 4; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.BackColor = Color.LightBlue;
                }
            }
        }
        private void btFriday_Click(object sender, EventArgs e)
        {
            ClearMatrix();
            SetDefaultDate();
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 4; j < 5; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.BackColor = Color.LightBlue;
                }
            }
        }
        private void btSaturday_Click(object sender, EventArgs e)
        {
            ClearMatrix();
            SetDefaultDate();
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 5; j < 6; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.BackColor = Color.LightBlue;
                }
            }
        }
        private void btSunday_Click(object sender, EventArgs e)
        {
            ClearMatrix();
            SetDefaultDate();
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 6; j < 7; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.BackColor = Color.LightBlue;
                }
            }
        }
    }
}
