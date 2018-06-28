using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersLanguage
{
    // 花ことばクラス
    static class FlowerLanguage
    {
        public static string Get(string name, string color)
        {
            Dictionary<string, string> flowers = FlowerFileIO.Read();

            // ファイルがなければエラーメッセージを返却
            if (flowers == null)
                return "「flower.csv」ファイルがありません。";

            // ファイルの内容がなければエラーメッセージを返却
            if (flowers.Count <= 0)
                return "「flower.csv」ファイルの中身が空です。";

            string searchKey;
            if (color != null && color != "")
            {
                searchKey = name + "(" + color + ")";
            }
            else
            {
                searchKey = name;
            }

            if (flowers.ContainsKey(searchKey))
            {
                string language = flowers[searchKey];
                return searchKey + "の花ことばは「" + language + "」です。";
            }
            else
            {
                return searchKey + "の花ことばは登録されていません。";
            }
        }

    }
}