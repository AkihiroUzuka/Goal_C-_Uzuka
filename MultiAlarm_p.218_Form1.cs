using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarm_p._218
{
    public partial class Form1 : Form
    {
        private bool alarmSetFlag_1 = false;  //アラームセット中フラグ
        private bool alarmSetFlag_2 = false;
        private bool alarmSetFlag_3 = false;
        private int alarmH_1 = 0;  //アラーム時
        private int alarmH_2 = 0;
        private int alarmH_3 = 0;
        private int alarmM_1 = 0;  //アラーム分
        private int alarmM_2 = 0;
        private int alarmM_3 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); //タイマーを起動
            labelTime.Text = DateTime.Now.ToLongTimeString();
            //ToLongTimeString-method: 長い形式の時刻の文字列形式に変換。

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();
            //ToLongTimeString-method: 長い形式の時刻の文字列形式に変換、をTimer1_Tickごとに更新。

            //アラーム設定中_1
            if (alarmSetFlag_1 == true)
            {
                //設定時刻になった
                if(alarmH_1 == now.Hour && alarmM_1 == now.Minute)
                {
                    alarmSetFlag_1 = false;
                    checkBox1.CheckState = CheckState.Unchecked;
                    checkBox1.Text = "00:00";
                    MessageBox.Show("時間ですよ！", "アラーム１", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //アラーム設定中_2
            if (alarmSetFlag_2 == true)
            {
                //設定時刻になった
                if (alarmH_2 == now.Hour && alarmM_2 == now.Minute)
                {
                    alarmSetFlag_2 = false;
                    checkBox2.CheckState = CheckState.Unchecked;
                    checkBox2.Text = "00:00";
                    MessageBox.Show("時間ですよ！", "アラーム２", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //アラーム設定中_3
            if (alarmSetFlag_3 == true)
            {
                //設定時刻になった
                if (alarmH_3 == now.Hour && alarmM_3 == now.Minute)
                {
                    alarmSetFlag_3 = false;
                    checkBox3.CheckState = CheckState.Unchecked;
                    checkBox3.Text = "00:00";
                   MessageBox.Show("時間ですよ！", "アラーム３", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonSet_1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag_1 = true;
                alarmH_1 = form2.alarmH;
                alarmM_1 = form2.alarmM;
                checkBox1.CheckState = CheckState.Checked;
                checkBox1.Text = alarmH_1.ToString("00") + ":" + alarmM_1.ToString("00");
            }
            form2.Dispose();
        }

        private void buttonSet_2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag_2 = true;
                alarmH_2 = form2.alarmH;
                alarmM_2 = form2.alarmM;
                checkBox2.CheckState = CheckState.Checked;
                checkBox2.Text = alarmH_2.ToString("00") + ":" + alarmM_2.ToString("00");
            }
            form2.Dispose();
        }

        private void buttonSet_3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag_3 = true;
                alarmH_3 = form2.alarmH;
                alarmM_3 = form2.alarmM;
                checkBox3.CheckState = CheckState.Checked;
                checkBox3.Text = alarmH_3.ToString("00") + ":" + alarmM_3.ToString("00");
            }
            form2.Dispose();
        }
    }
}
