﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_5_15_p._163
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 0, k = 0, no = 1;

            for(i = 1; i <= 10; i++)
            {
                for(j = 1; j <= 10; i++)
                {
                    for (k = 1; k <= 10; k++)
                    {
                        no += (i + j + k);
                        if (no >= 2000)
                            goto OUT;
                    }
                }
            }
        OUT:
            Console.WriteLine("i:{0} j:{1} k{2} no:{3}", i, j, k, no);
            Console.Read();
        }
    }
}
