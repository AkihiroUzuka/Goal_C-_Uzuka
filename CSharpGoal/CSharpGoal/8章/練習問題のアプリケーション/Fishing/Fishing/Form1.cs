using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class Form1 : Form
    {
        private Iwashi iwashi;              // イワシクラスのインスタンス
        private Utubo utubo;                // ウツボクラスのインスタンス
        private Ankou ankou;                // アンコウクラスのインスタンス
        private int remainingTime = 600;    // 残り時間（60秒×1000m秒÷100m秒周期）
        private bool isDayTime = true;      // 昼間はtrue;
        private int daytime = 100;          // 昼間の時間
        private int night = 50;             // 夜の時間
        private int score = 0;              // 得点

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;  // フォームのクライアント領域の幅

            // 魚のインスタンスの生成
            int x = pictureBoxIwashi.Location.X;
            int y = pictureBoxIwashi.Location.Y;
            iwashi = new Iwashi(x, y, 20, formSizeW, pictureBoxIwashi);
            x = pictureBoxUtubo.Location.X;
            y = pictureBoxUtubo.Location.Y;
            utubo = new Utubo(x, y, 10, formSizeW, pictureBoxUtubo);
            x = pictureBoxAnkou.Location.X;
            y = pictureBoxAnkou.Location.Y;
            ankou = new Ankou(x, y, 10, formSizeW, pictureBoxAnkou);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            swim();
        }

        // 泳ぐ処理
        private void swim()
        {
            int x, y;

            // 魚が泳ぎピクチャーボックスの位置を進める
            iwashi.Swim(out x, out y);
            iwashi.Move(x, y);
            utubo.Swim(out x, out y);
            utubo.Move(x, y);
            ankou.Swim(out x, out y);
            ankou.Move(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            labelTime.Text = "残り時間：" + (remainingTime / 10) + "秒";

            if (isDayTime == true)  // 昼間
            {
                daytime--;
                if (daytime == 0)
                {
                    isDayTime = false;      // 夜にする
                    iwashi.Sleep();         // イワシは寝る
                    utubo.Sleep();          // ウツボは寝る
                    daytime = 100;          // 10秒
                    this.BackColor = Color.Navy;
                }
            }
            else // 夜
            {
                night--;
                if (night == 0)
                {
                    isDayTime = true;       // 昼間にする
                    iwashi.WakeUp();        // イワシは起きる
                    utubo.WakeUp();         // ウツボは起きる
                    night = 50;             // 5秒
                    this.BackColor = Color.CornflowerBlue;
                }
            }

            if (remainingTime / 10 == 0)
            {
                timer1.Stop();
                labelTime.Text = "ゲームオーバー";
            }
            else
            {
                swim();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 数字キーを押下した
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                // 餌を食べる
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaS);
                score += utubo.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaL);
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaM);

                labelScore.Text = "得点：" + score;
            }
        }
    }
}
