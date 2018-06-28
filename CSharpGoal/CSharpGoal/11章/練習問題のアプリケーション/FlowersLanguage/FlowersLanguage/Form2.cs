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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // フォームロードのイベントハンドラ
        private void Form2_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> flowers = FlowerFileIO.Read();

            if (flowers == null)
            {
                MessageBox.Show("flower.csvが存在しません。", "エラー", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                foreach (string key in flowers.Keys)
                {
                    char[] delimiter = { '(', ')' };
                    string[] s = key.Split(delimiter);

                    if (s.Length >= 2)
                        dataGridViewContents.Rows.Add("削除", s[0], s[1], flowers[key]);
                    else
                        dataGridViewContents.Rows.Add("削除", key, "", flowers[key]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //「OKボタン」クリックのイベントハンドラ
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int count = dataGridViewContents.Rows.Count;
            Dictionary<string, string> flowers = new Dictionary<string, string>();

            for (int i = 0; i < count - 1; i++)
            {
                string c1 = (string)dataGridViewContents[1, i].Value;
                string c2 = (string)dataGridViewContents[2, i].Value;
                string c3 = (string)dataGridViewContents[3, i].Value;
                if (c2 == "")
                    flowers.Add(c1, c3);
                else
                    flowers.Add(c1 + "(" + c2 + ")", c3);
            }

            // DataGridViewの内容をファイルに保存
            FlowerFileIO.Write(flowers);
        }

        // セル内部のコンテンツクリックのイベントハンドラ
        private void dataGridViewContents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 削除ボタンの確認
            if (e.ColumnIndex == dataGridViewContents.Columns["DeleteButton"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("本当に削除してもいいですか？",
                        "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        // 削除
                        dataGridViewContents.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
