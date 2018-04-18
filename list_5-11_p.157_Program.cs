using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_5_11_p._157
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            do
            {
                Console.Write("整数値＞");
                n = int.Parse(Console.ReadLine());
                sum += n;
            } while (n > 0);

            Console.WriteLine("合計値は{0}です。", sum);
            Console.Read();
        }
    }
}
