using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WhackAMole
{
    // モグラクラス
    class Mole : JumpAnimal
    {
        // true：飛び上がる　false：落ちる
        private bool upDown;

        public Mole(int holeX, int holeY, int speed)
            : base(holeX, holeY, speed, Properties.Resources.mole)
        {
            upDown = true;
        }

        // 飛び出す
        public override void Jump()
        {
            base.Jumping = true;

            int x = base.Location.X;
            int y = base.Location.Y;

            if (upDown == true)
            {
                // 上がる
                y -= base.Speed;
                if (y < base.HoleY - base.Size.Height * 2 / 3)
                {
                    // 身体を2/3だけ穴から出す
                    y = base.HoleY - base.Size.Height * 2 / 3;
                    upDown = false;
                }
            }
            else
            {
                // 下がる
                y += base.Speed;
                if (y > base.HoleY)
                {
                    // 穴の位置で止まる
                    y = base.HoleY;
                    upDown = true;
                    base.Jumping = false;
                }
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
            Score += 1;
            return Score;
        }
    }
}
