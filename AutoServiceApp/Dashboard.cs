using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            refresh();
        }



        public void refresh()
        {
            DateTime dateTime = DateTime.Now;
            string[] month =
            {
                "Јануари","Февруари","Март","Април","Мај","Јуни","Јули","Август","Септември","Октомври", "Ноември", "Декември"
            };
            string[] days =
            {
                "Понеделник", "Вторник","Среда","Четврток","Петок","Сабота","Недела"
            };
            lblDate.Text = string.Format("{0}, {1} {2:00}, {3}",days[(int)dateTime.DayOfWeek-1], month[dateTime.Month-1], dateTime.Day,dateTime.Year);
            lblTime.Text = string.Format("{0:00}:{1:00}:{2:00}", dateTime.Hour, dateTime.Minute,dateTime.Second);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
