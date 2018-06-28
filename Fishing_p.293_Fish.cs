using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_p._293
{
    //魚クラス
    class Fish
    {
        //フィールド
        private System.Windows.Forms.PictureBox picture;

        //コンストラクター
        public Fish(int positionX, int positionY, int speed, System.Windows.Forms.PictureBox picture, int distanceX)
        {
            PositionX = positionX;
            PositionY = positionY;
            DistanceX = distanceX;
            Speed = speed;
            this.picture = picture;
        }

        //プロパティ
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public int DistanceX { get; set; }

        //進む
        //（仮引数）x : 更新座標x　y；更新座標Y
        //（戻り値）true：前進可能　false：時間終了
        public void Run(out int x, out int y)
        {
            //bool rc = true;

            //現在位置をスピード分進める
            PositionX += Speed;

            //右端についたら左から出現
            if (PositionX >= DistanceX)
            {
                PositionX = 0;
                x = PositionX;
            }


            x = PositionX;
            y = PositionY;

            
        }

        //ピクチャーボックスを移動する
        //（仮引数）x ：移動先座標x　y：移動先座標y
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
