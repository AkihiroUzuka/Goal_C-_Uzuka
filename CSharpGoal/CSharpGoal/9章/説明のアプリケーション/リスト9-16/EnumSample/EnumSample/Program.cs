using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    class Program
    {
        // 値を指定しないと0から割り当てられる
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        // 値を指定すると以降順番に1ずつ増加した値が割り当てられる
        enum DaysJpn { 日 = 1, 月, 火, 水, 木, 金, 土 };

        static void Main(string[] args)
        {
            int wed = (int)Days.Wed;            // キャストして数値を得る
            Console.WriteLine("{0}は{1}",
                Days.Wed, wed);                 // 出力：Wedは3
            Console.WriteLine("{0}曜日は{1}",
                DaysJpn.月, (int)DaysJpn.月);   // 出力：月曜日は2

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
