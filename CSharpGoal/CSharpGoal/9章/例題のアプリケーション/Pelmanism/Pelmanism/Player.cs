using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelmanism
{
    // プレイヤークラス
    class Player
    {
        private int nowOpenCardIndex1;  // 1枚目のカードの添え字
        private int nowOpenCardIndex2;	// 2枚目のカードの添え字

        // コンストラクター
        public Player()
        {
            NowOpenCardIndex1 = NowOpenCardIndex2 = -1;
            BeforeOpenCardIndex1 = BeforeOpenCardIndex2 = -1;
            OpenCounter = 0;
        }

        // 1枚目のカードの添字
        public int NowOpenCardIndex1
        {
            get { return nowOpenCardIndex1; }
            set
            {
                nowOpenCardIndex1 = value;
                OpenCounter++;
            }
        }
        // 2枚目のカードの添字
        public int NowOpenCardIndex2
        {
            get { return nowOpenCardIndex2; }
            set
            {
                nowOpenCardIndex2 = value;
                OpenCounter++;
            }
        }
        // 前回の1枚目のカードの添字
        public int BeforeOpenCardIndex1 { get; set; }
        // 前回の2枚目のカードの添字
        public int BeforeOpenCardIndex2 { get; set; }
        // めくった枚数
        public int OpenCounter { get; set; }

        // カードの情報をリセットする
        public void Reset()
        {
            BeforeOpenCardIndex1 = NowOpenCardIndex1;
            BeforeOpenCardIndex2 = NowOpenCardIndex2;
            NowOpenCardIndex1 = -1;
            NowOpenCardIndex2 = -1;
            OpenCounter = 0;
        }
    }
}
