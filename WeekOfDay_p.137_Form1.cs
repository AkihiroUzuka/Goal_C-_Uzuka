using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay_p._137
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelResult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year, month, day, result;
            bool check;


            if ((int.TryParse(textBox.Text, out year) == false) || (year < 0))
                labelResult.Text = "西暦年エラー";

            month = int.Parse(numericUpDownMonth.Text);
            day = int.Parse(numericUpDownDay.Text);

            check = CheckDate(year, month, day);
            if (check == false)
            {
                labelResult.Text = "あり得ない日付";
            }
            else
            {
                result = DayJudge(year, month, day);
                switch (result)
                {
                    case 0:
                        labelResult.Text = "日曜日です";
                        break;
                    case 1:
                        labelResult.Text = "月曜日です";
                        break;
                    case 2:
                        labelResult.Text = "火曜日です";
                        break;
                    case 3:
                        labelResult.Text = "水曜日です";
                        break;
                    case 4:
                        labelResult.Text = "木曜日です";
                        break;
                    case 5:
                        labelResult.Text = "金曜日です";
                        break;
                    case 6:
                        labelResult.Text = "土曜日です";
                        break;
                }
            }

           


        }

        //Whether うるう年 true false
        private bool uruuCheck(int year)
        {
            bool result;
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                result = true;
            }
            else
                result = false;
            return result;
        }
            
        //年月日の妥当性チェック true false
        private bool CheckDate(int year, int month, int day)
        {
            bool result;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day <= 31)
                    result = true;
                else
                    result = false;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day <= 30)
                    result = true;
                else
                    result = false;
            }
            else
            {
                if (uruuCheck(year) == true)
                {
                    if (day <= 29)
                        result = true;
                    else result = false;
                }
                else
                {
                    if (day <= 28)
                        result = true;
                    else result = false;
                }
            }

            return result;
        }

        //曜日判定 0~6
        private int DayJudge(int y, int m, int d)
        {
            int result;
            if (m == 1)
                m = 13;
            else if (m == 2)
                m = 14;

            result = (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;
            return result;
        }
    }
}
