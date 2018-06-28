using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InsectCatching
{
    // カブトムシクラス
    class Beetle : Insect
    {
        private int increment, incrementX, incrementY;  //増分値
        private Random random;

        public Beetle(int moveWidth, int moveHeight, Random random)
            : base(0, 0, moveWidth, moveHeight, Properties.Resources.beetle_up)
        {
            this.random = random;

            //増分値を決める
            increment = this.random.Next(10, 30);
            incrementX = 0;
            incrementY = -increment;
        }

        // 逃げる
        public override void RunAway()
        {
            int x = base.Location.X;
            int y = base.Location.Y;

            x += incrementX;
            y += incrementY;

            if (y < 0)
            {
                // 左向きに向きを変える
                incrementX = -increment;
                incrementY = 0;
                base.Image = Properties.Resources.beetle_upsidedown;
                x = base.MoveWidth - base.Size.Width;
                y = 0;
            }
            else if (x < 0)
            {
                // 真下に向きを変える
                incrementX = 0;
                incrementY = increment;
                base.Image = Properties.Resources.beetle_down;
                x = 0;
                y = 0;
            }
            else if (y > base.MoveHeight - base.Size.Height)
            {
                // 右向きに向きを変える
                incrementX = increment;
                incrementY = 0;
                base.Image = Properties.Resources.beetle_right;
                x = 0;
                y = base.MoveHeight - base.Size.Height;
            }
            else if (x > base.MoveWidth - base.Size.Width)
            {
                // 真上に向きを変える
                incrementX = 0;
                incrementY = -increment;
                base.Image = Properties.Resources.beetle_up;
                x = base.MoveWidth - base.Size.Width;
                y = base.MoveHeight - base.Size.Height;
            }

            base.Location = new Point(x, y);
        }

        // 位置、増分値、画像をリセットする
        public override void Reset()
        {
            base.Location = new Point(base.MoveWidth - base.Size.Width,
                                    base.MoveHeight - base.Size.Height);
            increment = this.random.Next(10, 30);
            incrementX = 0;
            incrementY = -increment;
            base.Image = Properties.Resources.beetle_up;
        }
    }
}
