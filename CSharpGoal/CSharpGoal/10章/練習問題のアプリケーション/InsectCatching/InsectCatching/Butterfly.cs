using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InsectCatching
{
    // 蝶クラス
    class Butterfly : Insect
    {
        private int incrementX, incrementY;         //増分値
        private Random random;

        public Butterfly(int moveWidth, int moveHeight, Random random)
            : base(0, 0, moveWidth, moveHeight, Properties.Resources.butterfly_right)
        {
            this.random = random;

            //増分値を決める
            incrementX = this.random.Next(5, 20);
            incrementY = this.random.Next(5, 20);
        }

        // 逃げる
        public override void RunAway()
        {
            int x = base.Location.X;
            int y = base.Location.Y;

            // ヒラヒラと移動する
            double angle;
            if (incrementX > 0)
                angle = random.Next(-90, 90);
            else
                angle = random.Next(90, 270);
            double r = Math.Sqrt((incrementX * incrementX + incrementY * incrementY));
            x = (int)(x + r * Math.Cos(angle * Math.PI / 180.0));
            y = (int)(y - r * Math.Sin(angle * Math.PI / 180.0));

            if (x < 0)
            {
                // 右方向に向きを変える
                incrementX *= -1;
                x = 0;
                base.Image = Properties.Resources.butterfly_right;
            }
            if (x > base.MoveWidth - base.Size.Width)
            {
                // 左方向に向きを変える
                incrementX *= -1;
                x = base.MoveWidth - base.Size.Width;
                base.Image = Properties.Resources.butterfly_left;
            }
            if (y < 0)
            {
                // 下方向に向きを変える
                incrementY *= -1;
                y = 0;
            }
            if (y > base.MoveHeight - base.Size.Height)
            {
                // 上方向に向きを変える
                incrementY *= -1;
                y = base.MoveHeight - base.Size.Height;
            }

            base.Location = new Point(x, y);
        }

        // 位置、増分値、画像をリセットする
        public override void Reset()
        {
            base.Location = new Point(0, base.MoveHeight);
            incrementX = this.random.Next(5, 20);
            incrementY = this.random.Next(5, 20);
            base.Image = Properties.Resources.butterfly_right;
        }
    }
}
