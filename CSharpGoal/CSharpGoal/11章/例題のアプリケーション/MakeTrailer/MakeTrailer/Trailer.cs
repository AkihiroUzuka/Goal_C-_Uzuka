using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeTrailer
{
    // 予告クラス
    static class Trailer
    {
        private static Random random = new Random();

        // 予告を作成するメソッド
        public static string Get(string nameA, string nameB, string nameC)
        {
            string content;

            List<string> contentsList = ContentsFileIO.Read();

            // ファイルがなければnullを返却
            if (contentsList == null)
                return null;

            // ファイルの内容がなければnullを返却
            if (contentsList.Count <= 0)
                return null;

            int index = random.Next(contentsList.Count);
            content = contentsList[index];

            content = content.Replace(",", Environment.NewLine);
            content = content.Replace("[人物A]", nameA);
            content = content.Replace("[人物B]", nameB);
            content = content.Replace("[人物C]", nameC);

            return content;
        }
    }
}
