using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax_p._121_exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            int money;

            if (int.TryParse(textBoxMoney.Text, out money) == true)
            {
                money = addTax(money);
                labelAddTax.Text = money + "円";
            }
            else
            {
                labelAddTax.Text = "入力文字列の形式が正しくありません。";
            }
        }

            private int addTax(int m)
            {
                const double tax = 0.08;
                return (int)(m * (1 + tax));
            }
        
    }
}
