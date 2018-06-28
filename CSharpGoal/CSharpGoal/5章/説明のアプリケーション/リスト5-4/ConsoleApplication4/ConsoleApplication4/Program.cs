using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:C}", 1000);           // 通貨表示
            Console.WriteLine("{0:X}", 250);            // 16進表示
            Console.WriteLine("{0:N}", 2500000);        // 数値表示
            Console.WriteLine("{0:F3}", 123.45678);     // 小数点以下の桁数指定
            Console.WriteLine("{0:P}", 2.0 / 3.0);      // %表示

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
