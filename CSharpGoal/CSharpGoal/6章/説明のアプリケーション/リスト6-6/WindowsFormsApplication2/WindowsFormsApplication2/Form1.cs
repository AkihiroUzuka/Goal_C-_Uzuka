using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Button button1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1 = new Button();

            this.button1.Name = "button1";
            this.button1.Text = "開く";

            this.button1.Location = new Point(100, 100);
            this.button1.Size = new Size(80, 20);

            this.Controls.Add(this.button1);
        }
    }
}
