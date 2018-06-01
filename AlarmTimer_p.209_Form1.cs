using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmTimer_p._209
{
    public partial class Form1 : Form
    {
        //Define field for alarm
        private bool alarmSetFlag = false;
        private int alarmHour = 0;
        private int alarmMinute = 0;
        private int alarmSecond = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();     //タイマー起動
            labelStatus.Text = "";
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日(ddd)");
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //更新
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日(ddd)");
            //アラーム設定中
            if(alarmSetFlag == true)
            {
                //設定時刻になった時
                if(alarmHour == now.Hour && alarmSecond == now.Second)
                {
                    alarmSetFlag = false;
                    MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelStatus.Text = "";
                }
            }
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag = true;
                alarmHour = form2.alarmHour;
                alarmMinute = form2.alarmMinute;
                alarmSecond = form2.alarmSecond;
                labelStatus.Text = "♪ " + alarmHour.ToString("00") + ":" + alarmMinute.ToString("00") + ":" + alarmSecond.ToString("00");
            }
            form2.Dispose(); //不要になったフォームのリソースを開放

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            alarmSetFlag = false;
            labelStatus.Text = "";
        }
    }
}
