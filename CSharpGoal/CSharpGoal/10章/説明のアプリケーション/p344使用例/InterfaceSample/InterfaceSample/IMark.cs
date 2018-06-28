using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    // インターフェース
    interface IMark
    {
        // 宣言のみで本体を記述しない アクセス修飾子も書かない
        string Name { get; set; }   // 自動実装プロパティではない（宣言のみ）
        void Draw();
    }
}
