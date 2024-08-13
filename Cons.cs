using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthurCalendarC_Winform
{
    // Đây là các hằng số (viết vào class khác sẽ dễ sửa, tiện lợi hơn khi sử dụng)
    internal class Cons
    {
        public static int DayOfWeek = 7; //Số ngày trong tuần
        public static int DayOfRow = 6; //Số hàng ngang


        //Quy định kích thước của ô vuông nút bấm (kích thước bằng với các nút Thứ)
        public static int dateButtonWidth = 103;
        public static int dateButtonHeight = 57;


        //Khoảng cách giữa các ô vuông nút bấm
        public static int margin = 6;
    }
}
