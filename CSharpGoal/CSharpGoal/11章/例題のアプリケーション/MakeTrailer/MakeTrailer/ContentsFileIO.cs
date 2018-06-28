using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MakeTrailer
{
    // contents.csv ファイルの入出力クラス
    static class ContentsFileIO
    {
        // 予告の内容を読み込むメソッド
        public static List<string> Read()
        {
            List<string> list = new List<string>();
            // ファイルが無ければそのままリターン
            if (File.Exists(@"Data\contents.csv") == false)
            {
                return list;
            }

            // contents.csv の読み込み
            try
            {
                using (StreamReader reader =
                    new StreamReader(@"Data\contents.csv", Encoding.Default))
                {
                    // ファイルを1行ずつ読み出す
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }
        }

        // 予告の内容を書き込むメソッド
        public static void Write(List<string> list)
        {
            // Dataディレクトリが無ければ作成する
            if (Directory.Exists("Data") == false)
            {
                Directory.CreateDirectory("Data");
            }

            // 予告の内容を書き込む
            try
            {
                using (StreamWriter writer =
                    new StreamWriter(@"Data\contents.csv", false, Encoding.Default))
                {
                    foreach (string s in list)
                    {
                        writer.Write(s);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
