using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();

            // 0 以上で100より小さい乱数を10個
            for (int i = 0; i < 10; i++)
                Console.Write(rnd1.Next(100) + " ");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                Console.Write(rnd2.Next(100) + " ");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                Console.Write(rnd3.Next(100) + " ");
            Console.WriteLine();

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
