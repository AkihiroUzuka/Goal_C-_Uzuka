using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost_p._93
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cost;
            int NumP;
            double addTax;
            const double tax = 0.08;

            cost = int.Parse(textBoxCost.Text);
            addTax = cost * (1 + tax);
            NumP = int.Parse(textBoxPeople.Text);

           


            labelPerPerson.Text = (int)addTax / NumP + " 円";
            labelAmari.Text = (int)(addTax % NumP) + " 円";
        }
    }
}
