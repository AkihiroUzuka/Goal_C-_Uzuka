using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeTrailer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // フォームロードのイベントハンドラ
        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> contentsList = ContentsFileIO.Read();

            foreach (string s in contentsList)
            {
                if (s.IndexOf(',') != -1)
                {
                    string[] c = s.Split(',');
                    dataGridViewContents.Rows.Add("削除", c[0], c[1], c[2]);
                }
            }
        }

        //「OKボタン」クリックのイベントハンドラ
        private void buttonOK_Click(object sender, EventArgs e)
        {
            int count = dataGridViewContents.Rows.Count;
            List<string> contentsList = new List<string>();

            for (int i = 0; i < count - 1; i++)
            {
                string c1 = (string)dataGridViewContents[1, i].Value;
                string c2 = (string)dataGridViewContents[2, i].Value;
                string c3 = (string)dataGridViewContents[3, i].Value;
                contentsList.Add(c1 + ',' + c2 + ',' + c3 + Environment.NewLine);
            }

            // DataGridViewの内容をファイルに保存
            ContentsFileIO.Write(contentsList);
        }

        // セル内部のコンテンツクリックのイベントハンドラ
        private void dataGridViewContents_CellContentClick
            (object sender, DataGridViewCellEventArgs e)
        {
            // 削除ボタンの確認
            if (e.ColumnIndex == dataGridViewContents.Columns["DeleteButton"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("本当に削除してもいいですか？",
                        "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    // 削除
                    try
                    {
                        dataGridViewContents.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
