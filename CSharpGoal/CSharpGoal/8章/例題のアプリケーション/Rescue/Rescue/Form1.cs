using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue
{
    public partial class Form1 : Form
    {
        private Helicopter helicopter;  // ヘリコプタークラスのインスタンス
        private Ambulance ambulance;    // 救急車クラスのインスタンス
        private Motorcycle motorcycle;  // バイククラスのインスタンス
        private Random random;          // 疑似乱数のインスタンス

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            // バイククラスのインスタンス生成
            int x = pictureBoxMotorcycle.Location.X;
            int y = pictureBoxMotorcycle.Location.Y;
            int distanceW = formSizeW - pictureBoxMotorcycle.Size.Width;
            motorcycle = new Motorcycle(x, y, 10, distanceW, pictureBoxMotorcycle);

            // 救急車クラスのインスタンス生成
            x = pictureBoxAmbulance.Location.X;
            y = pictureBoxAmbulance.Location.Y;
            distanceW = formSizeW - pictureBoxAmbulance.Size.Width;
            ambulance = new Ambulance(x, y, 15, distanceW, pictureBoxAmbulance);

            // ヘリコプタークラスのインスタンス生成
            x = pictureBoxHelicopter.Location.X;
            y = pictureBoxHelicopter.Location.Y;
            distanceW = formSizeW - pictureBoxHelicopter.Size.Width;
            helicopter = new Helicopter(x, y,
                30, distanceW, pictureBoxHelicopter, 30, y);

            random = new Random();  // 乱数のインスタンス生成

            labelNotice.Text = "";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            run();
        }

        // 進む処理
        private void run()
        {
            int x, y;

            // ピクチャボックスの位置を進める
            bool rc1 = motorcycle.Run(out x, out y);
            motorcycle.PictureMove(x, y);
            bool rc2 = ambulance.Run(out x, out y);
            ambulance.PictureMove(x, y);
            bool rc3 = helicopter.Run(out x, out y);
            helicopter.PictureMove(x, y);

            if (rc1 == false && rc2 == false && rc3 == false)
            {
                timer1.Stop();
                labelNotice.Text = "終了";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            run();

            int r = random.Next(100);
            if (r == 0)
            {
                ambulance.TrafficJam(); // 救急車に渋滞を通知
                labelNotice.Text += " 渋滞発生 ";
            }
            else if (r == 50)
            {
                helicopter.Storm();     // ヘリコプターに嵐を通知
                labelNotice.Text += " 嵐発生 ";
            }
        }
    }
}
