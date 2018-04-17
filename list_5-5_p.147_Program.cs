using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_5_5_p._147
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("科目＞");
            string subject = Console.ReadLine();
            Console.Write("点数＞");
            int score = int.Parse(Console.ReadLine());
            Console.Write("平均点＞");
            double average = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}は{1}点（平均{2}点）", subject, score, average);

            Console.Read();

        }
    }
}
