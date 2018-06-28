using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsectCatching
{
    // ゲームの進行を制御する
    public partial class Form1 : Form
    {
        private Insect[] insect;            // 虫の配列
        private int counter;                // 現在出現中の虫の数
        private int remainingTime;          // 残り時間
        private Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            insect = new Insect[61];

            random = new Random();

            int formSizeW = ClientSize.Width;       // Formのクライアント領域の幅
            int formSizeH = ClientSize.Height;      // Formのクライアント領域の高さ

            for (int i = 0; i < insect.Length; i++)
            {
                // 61匹分昆虫を用意する
                switch (random.Next(0, 3))
                {
                    case 0:
                        insect[i] = new Beetle(formSizeW, formSizeH, random);
                        break;
                    case 1:
                        insect[i] = new Butterfly(formSizeW, formSizeH, random);
                        break;
                    case 2:
                        insect[i] = new Dragonfly(formSizeW, formSizeH, random);
                        break;
                }
            }

            SuspendLayout();
            for (int i = 0; i < insect.Length; i++)
            {
                // ピクチャーボックスのNameを設定
                insect[i].Name = "insect" + i.ToString();
                // イベントハンドラに関連付け
                insect[i].Click += new EventHandler(insect_Click);
            }
            Controls.AddRange(insect);
            ResumeLayout(false);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            remainingTime = 60;
            timerTime.Start();
            timerInsect.Start();
            Insect.Score = 0;
            counter = 0;

            // 全部の虫の位置を初期化
            foreach (Insect i in insect)
            {
                i.Reset();
            }

            // 最初の1匹が逃げる
            insect[counter].Visible = true;
            insect[counter++].RunAway();

            labelScore.Text = "得点：0";
            labelTime.Text = "残り時間：" + remainingTime + "秒";
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            labelTime.Text = "残り時間：" + remainingTime + "秒";

            // ゲームオーバー
            if (remainingTime <= 0)
            {
                timerInsect.Stop();
                timerTime.Stop();

                labelTime.Text = "ゲームオーバー";
                buttonStart.Enabled = true;

                // 全部の虫を非表示にする
                foreach (Insect i in insect)
                {
                    i.Visible = false;
                }
            }
            else
            {
                // 1秒ごとに1匹出現
                counter++;
                insect[counter].Visible = true;
                insect[counter].RunAway();
            }
        }

        private void timerInsect_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < counter; i++)
            {
                insect[i].RunAway();
            }
        }

        // ピクチャーボックスクリックのイベントハンドラ
        private void insect_Click(object sender, EventArgs e)
        {
            // 添字を取得
            int n = int.Parse(((PictureBox)sender).Name.Substring(6));

            // ヒット処理
            int score = insect[n].Hit();
            labelScore.Text = "得点：" + score;
        }
    }
}
