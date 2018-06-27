using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3_p._269
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 c2 = new Class2("旧姓");
            Console.WriteLine(c2.Name);

            //c2.name = "新しい性";
            c2.NameChange("結婚後の姓");
            Console.WriteLine(c2.Name);
            Console.ReadLine();
        }
    }
}
