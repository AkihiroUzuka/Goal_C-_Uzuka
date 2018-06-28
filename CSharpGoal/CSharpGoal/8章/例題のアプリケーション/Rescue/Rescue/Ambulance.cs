using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue
{
    // 救急車クラス
    class Ambulance : Transportation
    {
        // コンストラクタ
        public Ambulance(int positionX, int positionY, int speed,
            int distanceX, System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, distanceX, picture)
        {

        }

        // 渋滞
        //（戻り値）現在のスピード
        public int TrafficJam()
        {
            // スピードを半分にする。ただし、5以下にはしない。
            Speed /= 2;
            if (Speed < 5)
                Speed = 5;

            return Speed;
        }
    }
}
