using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("合格点は{0}点です。", Class1.PassScore);

            Class1 c1 = new Class1("青森一郎", 60);
            Class1 c2 = new Class1("岩手二郎", 70);
            Class1 c3 = new Class1("秋田三郎", 80);

            Console.WriteLine("合格点は{0}点です。", Class1.PassScore);
            Console.WriteLine("{0} は {1}点です。", c1.Name, c1.Score);
            Console.WriteLine("{0} は {1}点です。", c2.Name, c2.Score);
            Console.WriteLine("{0} は {1}点です。", c3.Name, c3.Score);

            Class1.PassScore += 10;

            Console.WriteLine("合格点は{0}点に上がりました。", Class1.PassScore);

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
