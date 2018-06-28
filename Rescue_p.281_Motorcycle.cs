using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_p._281
{
    class Motorcycle : Transportation
    {
        //コンストラクター
        public Motorcycle(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture):base(positionX, positionY, speed, distanceX, picture) { }
    }
}
