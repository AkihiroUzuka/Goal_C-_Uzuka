using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSample
{
    // 派生クラス3（紙面スペースの関係で割愛）
    class Star : Mark
    {
        public Star() : base("星") { }

        public override void Draw()     // 仮想メソッドのオーバーライド
        {
            Console.WriteLine("☆");
        }
    }
}
