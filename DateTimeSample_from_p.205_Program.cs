using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //list6-10
            /*
            Console.WriteLine("今日の日付：" + DateTime.Today);
            Console.WriteLine("現在の日付と日時：" + DateTime.Now);

            //現在の日付と日時を取得する
            DateTime now = DateTime.Now;

            Console.WriteLine("年 = " + now.Year);
            Console.WriteLine("月 = " + now.Month);
            Console.WriteLine("日 = " + now.Day);
            Console.WriteLine("時 = " + now.Hour);
            Console.WriteLine("分 = " + now.Minute);
            Console.WriteLine("秒 = " + now.Second);
            Console.WriteLine("曜日 = " + now.DayOfWeek);
            */
            //list6-11
            /*
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            TimeSpan addSpan = new TimeSpan(10, 10, 10);
            DateTime answer = now.Add(addSpan);
            Console.WriteLine(answer);
            addSpan = new TimeSpan(1, 1, 1, 1);
            answer = now.Add(addSpan);
            Console.WriteLine(answer);
            */
            //list6-12
            /*
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            */
            //list6-13
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine("D = " + now.ToString("D"));
            Console.WriteLine("T = " + now.ToString("T"));
            Console.WriteLine("d = " + now.ToString("d"));
            Console.WriteLine("t = " + now.ToString("t"));
            Console.WriteLine("m = " + now.ToString("m"));

            Console.Read();

        }
    }
}
