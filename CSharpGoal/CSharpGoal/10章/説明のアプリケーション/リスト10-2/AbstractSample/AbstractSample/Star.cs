using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    // 派生クラス3（紙面スペースの関係で割愛）
    class Star : Mark
    {
        public Star() : base("星") { }

        // 抽象メソッドの実装
        public override void Draw()
        {
            Console.WriteLine("☆");
        }
    }
}
