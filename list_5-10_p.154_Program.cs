﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_5_10_p._154
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            Console.Write("整数値＞");
            n = int.Parse(Console.ReadLine());
            while (n >0)
            {
                sum += n;
                Console.Write("整数値＞");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("合計値は{0}です。", sum);
            Console.Read();
        }
    }
}
