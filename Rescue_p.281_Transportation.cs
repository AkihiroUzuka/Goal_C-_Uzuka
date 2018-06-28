using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue_p._281
{
    class Transportation
    {
        //フィールド
        private System.Windows.Forms.PictureBox picture;

        //コンストラクター
        public Transportation(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            DistanceX = distanceX;
            this.picture = picture;
        }

        //プロパティ
        public int PositionX { get; set; }  //位置X
        public int PositionY { get; set; }  //位置Y
        public int Speed { get; set; }      //スピード
        public int DistanceX { get; set; }  //目的地X

        //進む
        //（仮引数）X：更新座標X　　Y：更新座標Y
        //（戻り値）true：全身可能　false：到着
        public bool Run(out int x, out int y)
        {
            bool rc = true;

            //現在位置をスピード分進めす
            PositionX += Speed;

            //目的地についたらもう進めない
            if(PositionX >= DistanceX)
            {
                PositionX = DistanceX;
                rc = false;         //目的地についたらfalseを返す
            }

            x = PositionX;
            y = PositionY;

            return rc;
        }

        //ピクチャーボックスを移動する
        //（仮引数）X：移動先座標 X　　Y：移動先座標 Y
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
