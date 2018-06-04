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
    public partial class Form2 : Form
    {
        internal int alarmH = 0;
        internal int alarmM = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //現在時刻の表示
            numericUpDownH.Value = DateTime.Now.Hour;
            numericUpDownM.Value = DateTime.Now.Minute;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            alarmH = (int)numericUpDownH.Value;
            alarmM = (int)numericUpDownM.Value;
        }
    }
}
