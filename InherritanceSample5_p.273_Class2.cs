using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherritanceSample5_p._273
{
    class Class2 : Class1
    {
        public override void M()
        {
            Console.WriteLine("派生クラスのMメソッドが呼ばれました。");
        }
    }
}
