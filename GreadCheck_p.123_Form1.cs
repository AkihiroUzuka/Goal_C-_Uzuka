using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck_p._123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }

        private void buttonJudge_Click(object sender, EventArgs e)
        {
            //出席率を浮動小数点値に変換
            double AttendanceM, AttendanceP, AttendanceE;
            textToValue(textBoxAttendanceM.Text, out AttendanceM);
            textToValue(textBoxAttendanceP.Text, out AttendanceP);
            textToValue(textBoxAttendanceE.Text, out AttendanceE);

            //点数を整数値に変換
            int scoreM, scoreP, scoreE;
            textToValue(textBoxScoreM.Text, out scoreM);
            textToValue(textBoxScoreP.Text, out scoreP);
            textToValue(textBoxScoreE.Text, out scoreE);

            //点数を判定する
            labelResultM.Text = scoreJudge(AttendanceM, scoreM);
            labelResultP.Text = scoreJudge(AttendanceP, scoreP);
            labelResultE.Text = scoreJudge(AttendanceE, scoreE);

            //平均値以上か未満化を判断する
            labelCompAvgM.Text = averageJudge(scoreM, 1);
            labelCompAvgP.Text = averageJudge(scoreP, 1);
            labelCompAvgE.Text = averageJudge(scoreE, 1);

        }

        //テキストを浮動小数点数に変換
        //（仮引数）text:変換する文字列　val:変換した浮動小数点数
        private void textToValue(string text, out double val)
        {
            if (double.TryParse(text, out val) == false)
                val = -1.0;
        }

        //テキストを整数値に変換
        //（仮引数）text:変換対象の文字列　val:反感後の整数値
        //（返却値）なし
        private void textToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }

        //成績判定
        //（仮引数）Attendance:出席率　score:得点
        //（返却値）判定結果
        private string scoreJudge(double Attendance, int score)
        {
            string result;

            if (Attendance < 0.0 || Attendance > 100.0 || score < 0 || score > 100)
                result = "エラー";
            else if (Attendance >= 80.0)
            {
                if (score >= 80)
                    result = "A判定";
                else if (score >= 70)
                    result = "B判定";
                else if (score >= 60)
                    result = "C判定";
                else
                    result = "不合格";
            }
            else
                result = "不合格";

            return result;
        }

        //平均点判定
        //（仮引数）score:得点　subject:科目（1 = 数学　2 = 物理　3= 英語）
        //（返却値）判定結果
        private string averageJudge(int score, int subject)
        {
            string result;
            int average;

            if (score < 0 || score > 100)
                return "エラー";

                    switch (subject)
            {
                case 1:
                    average = 73;
                    break;
                case 2:
                    average = 65;
                    break;
                case 3:
                    average = 77;
                    break;
                default:
                    return "エラー";
            }

            if (score >= average)
                result = "平均点以上";
            else
                result = "平均点未満";

            return result;

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxAttendanceM.Text = "0.0";
            textBoxAttendanceP.Text = "0.0";
            textBoxAttendanceE.Text = "0.0";

            textBoxScoreM.Text = "0";
            textBoxScoreP.Text = "0";
            textBoxScoreE.Text = "0";

            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";

            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }
    }
}
