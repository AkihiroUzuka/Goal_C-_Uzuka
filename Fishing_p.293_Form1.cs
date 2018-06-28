using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing_p._293
{
    public partial class Form1 : Form
    {
        int time = 60;
        int count = 10;
        int count_day = 10;
        int count_night = 5;
        int day_night_switch = 1;
        int point = 0;

        private Ankou ankou;    //インスタンス
        private Iwashi iwashi;
        private Utsubo utsubo;



        public Form1()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            run();

        }

        //進む処理
        private void run()
        {
            int x, y;
         
            //ピクチャボックスの位置を進める
            ankou.Run(out x, out y);
            ankou.PictureMove(x, y);
            iwashi.Run(out x, out y);
            iwashi.PictureMove(x, y);

            if (day_night_switch == 1)
            {
                utsubo.Run(out x, out y);
                utsubo.PictureMove(x, y);
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "残り時間：60秒";
            label2.Text = "得点： 0";

            int formSizeW = this.ClientSize.Width;

            //アンコウクラスのインスタンス生成
            int x = pictureBoxAnkou.Location.X;
            int y = pictureBoxAnkou.Location.Y;
            int distanceW = formSizeW;
            ankou = new Ankou(x, y, 10, pictureBoxAnkou, distanceW);

            //イワシクラスのインスタンス生成
            x = pictureBoxIwashi.Location.X;
            y = pictureBoxIwashi.Location.Y;
            distanceW = formSizeW;
            iwashi = new Iwashi(x, y, 20, pictureBoxIwashi, distanceW);

            //ウツボクラスのインスタンス生成
            x = pictureBoxUtsubo.Location.X;
            y = pictureBoxUtsubo.Location.Y;
            distanceW = formSizeW;
            utsubo = new Utsubo(x, y, 10, pictureBoxUtsubo, distanceW);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            run();


            count--;
            if (count == 0)
            {
                //制限時間制御
                count = 10;
                time--;
                label1.Text = "残り時間：" + time.ToString() + "秒";

                //昼夜サイクル制御_カウント
                switch (day_night_switch)
                {
                    case 1:
                        count_day--;
                        break;
                    case 0:
                        count_night--;
                        break;
                }
                //昼夜サイクル制御_切り替え
                if (count_day == 0)
                {
                    count_day = 10;
                    day_night_switch = 0;
                    this.BackColor = System.Drawing.Color.DarkCyan;
                }
                if (count_night == 0)
                {
                    count_night = 5;
                    day_night_switch = 1;
                    this.BackColor = System.Drawing.Color.Cyan;
                }


            }
            
            if (time == 0)
            {
                timer1.Stop();
            }
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar>= 49 && (int)e.KeyChar <= 57)
            {
                int x1, x2, w1, w2, eva;
                //アンコウ釣り_加点_座標リセット
                x1 = pictureBoxAnkou.Location.X;
                w1 = pictureBoxAnkou.Size.Width;
                x2 = pictureBoxPreyA.Location.X;
                w2 = pictureBoxPreyA.Size.Width;
                eva = (x1 + w1) - (x2 + w2);
                if (eva >= 0 && eva <= 30)
                {
                    point += (int)e.KeyChar - 48;
                    label2.Text = "得点：" + point.ToString();
                    ankou.PositionX = 0 - w1*2;
                }

                //イワシ釣り
                x1 = pictureBoxIwashi.Location.X;
                w1 = pictureBoxIwashi.Size.Width;
                x2 = pictureBoxPreyI.Location.X;
                w2 = pictureBoxPreyI.Size.Width;
                eva = (x1 + w1) - (x2 + w2);
                if (eva >= 0 && eva <= 30 && (int)e.KeyChar <= 51 && day_night_switch == 1)
                {
                    point += (int)e.KeyChar - 48;
                    label2.Text = "得点：" + point.ToString();
                    iwashi.PositionX = 0 - w1 * 2;
                }

                //ウツボ釣り
                x1 = pictureBoxUtsubo.Location.X;
                w1 = pictureBoxUtsubo.Size.Width;
                x2 = pictureBoxPreyU.Location.X;
                w2 = pictureBoxPreyU.Size.Width;
                eva = (x1 + w1) - (x2 + w2);
                if (eva >= 0 && eva <= 30 && (int)e.KeyChar >= 55 && day_night_switch == 1)
                {
                    point += (int)e.KeyChar - 48;
                    label2.Text = "得点：" + point.ToString();
                    utsubo.PositionX = 0-w1 - w1/2;
                }

            }


        }



    }
}
