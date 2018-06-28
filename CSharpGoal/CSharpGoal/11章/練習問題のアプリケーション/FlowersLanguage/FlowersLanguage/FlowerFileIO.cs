using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FlowersLanguage
{
    // flower.csvファイルの入出力クラス
    static class FlowerFileIO
    {
        // 花ことばの内容を読み込むメソッド
        public static Dictionary<string, string> Read()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            // ファイルが無ければそのままリターン
            if (File.Exists(@"Data\flower.csv") == false)
            {
                return null;
            }

            // flower.csv の読み込み
            try
            {
                using (StreamReader reader =
                    new StreamReader(@"Data\flower.csv", Encoding.Default))
                {
                    // ファイルを1行ずつ読み出す
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] s = line.Split(',');
                        dictionary.Add(s[0], s[1]);
                    }
                }
                return dictionary;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dictionary;
            }
        }

        // 花言葉の内容を書き込むメソッド
        public static void Write(Dictionary<string, string> dictionary)
        {
            // Data ディレクトリが無ければ作成する
            if (Directory.Exists("Data") == false)
            {
                Directory.CreateDirectory("Data");
            }

            // 花言葉の内容を書き込む
            try
            {
                using (StreamWriter writer =
                    new StreamWriter(@"Data\flower.csv", false, Encoding.Default))
                {
                    foreach (string key in dictionary.Keys)
                    {
                        writer.WriteLine("{0},{1}", key, dictionary[key]);
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
