using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WhackAMole
{
    // 鳥クラス
    class Bird : JumpAnimal
    {
        public Bird(int holeX, int holeY, int speed)
            : base(holeX, holeY, speed, Properties.Resources.bird)
        {
        }

        // 飛び出す
        public override void Jump()
        {
            base.Jumping = true;

            int x = base.Location.X;
            int y = base.Location.Y;

            // 飛び去る
            y -= base.Speed;
            if (y + base.Size.Height < 0)
            {
                y = HoleY;
                base.Jumping = false;
            }

            // PictureBoxの位置を更新する
            base.Location = new Point(x, y);
        }

        // 当たった
        //（返却値）更新した得点
        public override int Hit()
        {
            // 位置を戻す
            base.Location = new Point(HoleX, HoleY);

            Jumping = false;

            // 加点する
            Score += 4;
            return Score;
        }
    }
}
