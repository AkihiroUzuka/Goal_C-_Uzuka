using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_5_9_p._153
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)  // i は使えない
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Read();

        }
    }
}

           
       