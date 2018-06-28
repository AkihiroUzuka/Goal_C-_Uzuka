using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 「消費税追加」ボタンクリックのイベントハンドラ
        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            int money;
            double addTax;
            const double tax = 0.08;    // 消費税率8%

            money = int.Parse(textBoxMoney.Text);
            addTax = money;
            addTax *= (1 + tax);
            money = (int)addTax;

            labelAddTax.Text = money + " 円";
        }
    }
}
