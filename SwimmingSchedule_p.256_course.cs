using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule_p._256
{
    class course
    {
        //フィールド＿曜日
        public int day_0 = 1;  //ベビー
        public int day_1 = 2;  //幼児
        public int day_2 = 3;  //小学生
        public int day_3 = 4;  //中学生
        public int day_4 = 5;  //レディース
        public int day_5 = 6;  //一般
        public int day_6 = 0;  //家族

        //フィールド＿開始時間
        public int time_0 = 14;  //ベビー
        public int time_1 = 10;  //幼児
        public int time_2 = 17;  //小学生
        public int time_3 = 19;  //中学生
        public int time_4 = 20;  //レディース
        public int time_5 = 20;  //一般
        public int time_6 = 10;  //家族

        //一回分の授業料
        public int fee_0 = 1000;  //ベビー
        public int fee_1 = 1000;  //幼児
        public int fee_2 = 800;  //小学生
        public int fee_3 = 800;  //中学生
        public int fee_4 = 1000;  //レディース
        public int fee_5 = 1200;  //一般
        public int fee_6 = 1500;  //家族

    }
}
