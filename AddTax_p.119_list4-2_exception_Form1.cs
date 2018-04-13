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

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            int money;
            try
            {

                money = int.Parse(textBoxMoney.Text);
                money = addTax(money);
                labelAddTax.Text = money + " 円";
            }
            catch (FormatException ex)
            {
                labelAddTax.Text = ex.Message;
            }
        }

        private int addTax(int m)
        {
            const double tax = 0.08;

            return (int)(m * (1 + tax));
        }
    }
}
