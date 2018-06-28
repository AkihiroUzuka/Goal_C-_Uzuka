using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCheck2
{
    // 学生クラス
    class Student
    {
        // フィールド
        private int scoreM;         // 数学の得点
        private int scoreP;         // 物理の得点
        private int scoreE;         // 英語の得点
        private int attendanceM;    // 数学の出席時数
        private int attendanceP;    // 物理の出席時数
        private int attendanceE;    // 英語の出席時数

        // コンストラクター
        public Student(string name, int scoreM, int scoreP, int scoreE,
            int attendanceM, int attendanceP, int attendanceE)
        {
            Name = name;
            ScoreM = scoreM;
            ScoreP = scoreP;
            ScoreE = scoreE;
            AttendanceM = attendanceM;
            AttendanceP = attendanceP;
            AttendanceE = attendanceE;
        }

        // プロパティ
        public string Name { get; set; }    // 学生名
        public int ScoreM                   // 数学の得点
        {
            get { return scoreM; }
            set { scoreM = scoreCheck(value); }
        }
        public int ScoreP                   // 物理の得点
        {
            get { return scoreP; }
            set { scoreP = scoreCheck(value); }
        }
        public int ScoreE                   // 英語の得点
        {
            get { return scoreE; }
            set { scoreE = scoreCheck(value); }
        }
        public int AttendanceM              // 数学の出席時数
        {
            get { return attendanceM; }
            set { attendanceM = attendanceCheck(value); }
        }
        public int AttendanceP              // 物理の出席時数
        {
            get { return attendanceP; }
            set { attendanceP = attendanceCheck(value); }
        }
        public int AttendanceE              // 英語の出席時数
        {
            get { return attendanceE; }
            set { attendanceE = attendanceCheck(value); }
        }

        // 得点の値が正しいかチェック
        //（仮引数）val：得点
        //（返却値）正しいときは得点　正しくないときには0
        private int scoreCheck(int val)
        {
            if (val >= 0 && val <= 100)
                return val;
            else
            {
                System.Windows.Forms.MessageBox.Show
                    ("得点の入力が正しくありません。", "確認");
                return 0;
            }
        }

        // 出席時数の値が正しいかチェック
        //（仮引数）val：出席時数
        //（返却値）正しいときは出席時数　正しくないときには0
        private int attendanceCheck(int val)
        {
            if (val >= 0)
                return val;
            else
            {
                System.Windows.Forms.MessageBox.Show
                    ("出席時数の入力が正しくありません。", "確認");
                return 0;
            }
        }
    }
}
