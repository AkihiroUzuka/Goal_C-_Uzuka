using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_p._281
{
    class Helicopter : Transportation
    {
        //コンストラクター
        public Helicopter(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture, int maxHigh, int minHigh):base(positionX, positionY, speed, distanceX, picture)
        {
            MaxHigh = maxHigh;
            MinHigh = minHigh;
        }

        //プロパティ
        public int MaxHigh { get; private set; } // 最高速度
        public int MinHigh { get; private set; } // 最低高度

        //飛ぶ
        //（仮引数）X：更新座標X　　Y：更新座標Y
        //（戻り値））true：全身可能　false：到着
        public new bool Run(out int x, out int y)
        {
            bool rc = true;

            //現在位置をスピード分進める
            PositionX += Speed;

            //目的地についたら
            if (PositionX >= DistanceX)
            {
                PositionX = DistanceX;
                PositionY += Speed / 2;
                if (PositionY >= MinHigh)
                {
                    PositionY = MinHigh;
                    rc = false;
                }
            }
            //目的地についていない
            else
            {
                PositionY -= Speed / 2;
                if (PositionY <= MaxHigh)
                    PositionY = MaxHigh;
            }
            x = PositionX;
            y = PositionY;

            return rc;
        }

        //嵐が来た
        public void Storm()
        {
            //目的地を現在地にして途中で飛行を中止する
            DistanceX = PositionX;
        }

    }
}
