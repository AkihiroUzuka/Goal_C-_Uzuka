using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //「検索」ボタンクリックのイベントハンドラ
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FlowerLanguage.Get(textBoxName.Text, comboBoxColor.Text), "結果");
        }

        //「追加編集」ボタンクリックのイベントハンドラ
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2.Dispose();
        }
    }
}
