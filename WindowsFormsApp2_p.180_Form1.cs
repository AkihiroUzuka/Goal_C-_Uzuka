using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_p._180
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

            this.button1.Click += new EventHandler(button1_Click);

            this.Controls.Add(this.button1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                label1.Text = form2.feeling;
                //MessageBox.Show()をつかってみた。
                DialogResult result = MessageBox.Show("削除してもよかですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    label2.Text = "Yes";
                }
                else
                {
                    label2.Text = "No";
                }
            }
            form2.Dispose();
        }
    }
}
