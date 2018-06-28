using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck2
{
    public partial class Form1 : Form
    {
        Subject subjectM;   // 数学のインスタンス
        Subject subjectP;   // 物理のインスタンス
        Subject subjectE;	// 英語のインスタンス

        public Form1()
        {
            InitializeComponent();
        }

        // フォームロードのイベントハンドラ
        private void Form1_Load(object sender, EventArgs e)
        {
            subjectM = new Subject("数学", 73, 80, 60);
            subjectP = new Subject("物理", 65, 50, 50);
            subjectE = new Subject("英語", 77, 100, 70);

            // 各科目の総時数の表示
            labelTotalM.Text = "/ " + subjectM.TotalHours.ToString();
            labelTotalP.Text = "/ " + subjectP.TotalHours.ToString();
            labelTotalE.Text = "/ " + subjectE.TotalHours.ToString();

            // 各科目の合格点の表示
            labelPassScoreM.Text = subjectM.PassScore.ToString();
            labelPassScoreP.Text = subjectP.PassScore.ToString();
            labelPassScoreE.Text = subjectE.PassScore.ToString();

            // 各科目の平均点の表示
            labelAverageM.Text = subjectM.Average.ToString();
            labelAverageP.Text = subjectP.Average.ToString();
            labelAverageE.Text = subjectE.Average.ToString();

            labelClear();
        }

        // 結果を表示するラベルのクリア
        private void labelClear()
        {
            labelName.Text = "";
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }

        //「判定」ボタンクリックのイベントハンドラ
        private void buttonJudge_Click(object sender, EventArgs e)
        {
            // 得点を整数値に変換
            int scoreM, scoreP, scoreE;
            textToValue(textBoxScoreM.Text, out scoreM);
            textToValue(textBoxScoreP.Text, out scoreP);
            textToValue(textBoxScoreE.Text, out scoreE);

            if (scoreM < 0 || scoreM > 100 || scoreP < 0 || scoreP > 100 ||
                scoreE < 0 || scoreE > 100)
            {
                MessageBox.Show("得点の入力が正しくありません。", "確認");
                return;
            }

            // 出席時数を整数値に変換
            int attendanceM, attendanceP, attendanceE;
            textToValue(textBoxAttendanceM.Text, out attendanceM);
            textToValue(textBoxAttendanceP.Text, out attendanceP);
            textToValue(textBoxAttendanceE.Text, out attendanceE);

            if (attendanceM < 0 || attendanceM > subjectM.TotalHours ||
                attendanceP < 0 || attendanceP > subjectP.TotalHours ||
                attendanceE < 0 || attendanceE > subjectE.TotalHours)
            {
                MessageBox.Show("出席時数の入力が正しくありません。", "確認");
                return;
            }

            Student student
                = new Student(textBoxName.Text, scoreM, scoreP, scoreE,
                    attendanceM, attendanceP, attendanceE);

            // 名前の表示
            labelName.Text = student.Name + "さんの成績";

            // 合否判定
            labelResultM.Text = subjectM.OverPass(student.ScoreM, student.AttendanceM);
            labelResultP.Text = subjectP.OverPass(student.ScoreP, student.AttendanceP);
            labelResultE.Text = subjectE.OverPass(student.ScoreE, student.AttendanceE);

            // 平均値以上か未満か判定する
            labelCompAvgM.Text = subjectM.OverAverage(student.ScoreM);
            labelCompAvgP.Text = subjectP.OverAverage(student.ScoreP);
            labelCompAvgE.Text = subjectE.OverAverage(student.ScoreE);
        }

        // テキストを整数値に変換
        //（仮引数）text：変換する文字列　val：変換した整数値
        private void textToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }

        //「リセット」ボタンクリックのイベントハンドラ
        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelClear();

            textBoxName.Text = "";
            textBoxAttendanceM.Text = "0";
            textBoxAttendanceP.Text = "0";
            textBoxAttendanceE.Text = "0";
            textBoxScoreM.Text = "0";
            textBoxScoreP.Text = "0";
            textBoxScoreE.Text = "0";
        }
    }
}
