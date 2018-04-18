using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_5_7_p._150
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 30; i >= 1; i -= 3)
                if (i % 2 == 0)
                    Console.Write(i + " ");
            Console.Read();
        }

    }
}
