using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchedule_p._256
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime now = DateTime.Now;
        course course = new course();
        int year;
        int month;
        int youbi_of_course;
        int time_of_course;
        int fee_of_course;

        int number_of_course = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownYear.Value = now.Year;
            numericUpDownMonth.Value = now.Month;
            labelDate.Text = " ";
            labelTime.Text = " ";
            labelFee.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number_of_course = 0;
            labelDate.Text = "";

            year = (int)numericUpDownYear.Value;
            month = (int)numericUpDownMonth.Value;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            daysInMonth -= 3;
            int index = listBoxCourse.SelectedIndex;

            switch (index)
            {
                case 0:
                    youbi_of_course = course.day_0;
                    time_of_course = course.time_0;
                    fee_of_course = course.fee_0;
                    break;
                case 1:
                    youbi_of_course = course.day_1;
                    time_of_course = course.time_1;
                    fee_of_course = course.fee_1;
                    break;
                case 2:
                    youbi_of_course = course.day_2;
                    time_of_course = course.time_2;
                    fee_of_course = course.fee_2;
                    break;
                case 3:
                    youbi_of_course = course.day_3;
                    time_of_course = course.time_3;
                    fee_of_course = course.fee_3;
                    break;
                case 4:
                    youbi_of_course = course.day_4;
                    time_of_course = course.time_4;
                    fee_of_course = course.fee_4;
                    break;
                case 5:
                    youbi_of_course = course.day_5;
                    time_of_course = course.time_5;
                    fee_of_course = course.fee_5;
                    break;
                case 6:
                    youbi_of_course = course.day_6;
                    time_of_course = course.time_6;
                    fee_of_course = course.fee_6;
                    break;
            }

            for ( int day = 1; day <= daysInMonth; day++)
            {
                DateTime dt = new DateTime(year, month, day);
                int w = (int)dt.DayOfWeek;
                if (w == youbi_of_course)
                {
                    number_of_course++;
                    labelDate.Text += (day + "日　");
                }
            }

            labelTime.Text = time_of_course.ToString() + "時";
            labelFee.Text = (fee_of_course * number_of_course).ToString();


        }


    }
}
