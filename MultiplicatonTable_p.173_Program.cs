using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;

            Console.WriteLine("  * * * 九九の表 * * * ");
            Console.WriteLine("   |  1  2  3  4  5  6  7  8  9 ");
            Console.WriteLine("--------------------------------");
            for(int i = 1; i <= 9; i++)
            {
                Console.Write("{0}  |", i);
                for(int j =1; j <= 9; j++)
                {
                    p = i * j;
                    if (p <= 9)
                        Console.Write(" ");
                    Console.Write(" {0}", p);
                    if (j == 9)
                        Console.Write("\n");
                }
            }
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
