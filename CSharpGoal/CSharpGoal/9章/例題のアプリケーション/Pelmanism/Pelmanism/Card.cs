using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pelmanism
{
    // カードクラス
    class Card : Button
    {
        // カードの横幅と高さ    
        private const int sizeW = 50, sizeH = 70;
        // カードの表面の色    
        private Color openColor = Color.White;
        // カードの裏面の色 
        private Color closeColor = Color.LightSeaGreen;

        // コンストラクター
        public Card(string picture)
        {
            Picture = picture;
            State = false;
            base.Size = new Size(sizeW, sizeH);
            base.BackColor = closeColor;
            base.Font = new Font("MS UI Gothic", 14, FontStyle.Bold);
            base.Enabled = false;
        }

        // カードの絵柄
        public string Picture { get; set; }
        // カードの状態（true：表　false：裏）
        public bool State { get; set; }

        // カードを表にする
        public void Open()
        {
            State = true;           // 表
            base.BackColor = openColor;
            base.Text = Picture;
            base.Enabled = false;   // 選択不可
        }

        // カードを裏にする
        public void Close()
        {
            State = false;          // 裏
            base.BackColor = closeColor;
            base.Text = "";
            base.Enabled = true;    // 選択可
        }

        // カードをひっくり返す
        public void Turn()
        {
            if (State == true)
                Close();        // 裏にする
            else
                Open();         // 表にする
        }
    }
}
