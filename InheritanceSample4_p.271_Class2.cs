using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngeritanceSample4
{
    class Class2 : Class1
    {
        public new int x = 20;

        public new void M()
        {
            Console.WriteLine("派生クラスのメソッドが呼ばれました。");
        }

    }
}
