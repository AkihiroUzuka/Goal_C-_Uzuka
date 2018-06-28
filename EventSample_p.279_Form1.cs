using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSample_p._279
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sener, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'A')
                label1.Text = "A";
            else   //A以外の文字を入力したらそのまま表示
                label1.Text = e.KeyChar.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                label2.Text = "A か a";
            else  // A以外の文字を入力したらそのまま表示
                label2.Text = e.KeyCode.ToString();

        }
    }
}
