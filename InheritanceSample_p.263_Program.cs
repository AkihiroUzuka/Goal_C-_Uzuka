using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample_p._263
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();

            Console.WriteLine("電源：{0}　チャンネル：{1}　音量：{2}", tv.Power ? "ON" : "OFF", tv.Channel, tv.Volume);

            Console.WriteLine("電源ボタンを押します。");
            tv.OnOff();
            Console.WriteLine("電源：{0}", tv.Power ? "ON" : "OFF");

            Console.WriteLine("電源ボタンを押します。");
            tv.OnOff();
            Console.WriteLine("電源：{0}", tv.Power ? "ON" : "OFF");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
