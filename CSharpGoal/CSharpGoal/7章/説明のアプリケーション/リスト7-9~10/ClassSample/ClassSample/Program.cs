using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();

            Console.WriteLine("TV1　電源：{0}　チャンネル:{1}　音量：{2}", 
                tv.Power ? "ON" : "OFF", tv.Channel, tv.Volume);

            Console.WriteLine("チャンネルを+2します。");
            tv.ChannelUP();
            tv.ChannelUP();
            Console.WriteLine("TV1は{0}チャンネルです。", tv.Channel);

            Console.WriteLine("音量を-2します。");
            tv.VolumeDown();
            tv.VolumeDown();
            Console.WriteLine("TV1の音量は{0}です。", tv.Volume);

            Television tv2 = new Television(8, 25);

            Console.WriteLine("TV2　電源：{0}　チャンネル:{1}　音量：{2}", 
                tv2.Power ? "ON" : "OFF", tv2.Channel, tv2.Volume);

            Console.WriteLine("チャンネルを+2します。");
            tv2.ChannelUP();
            tv2.ChannelUP();
            Console.WriteLine("TV2は{0}チャンネルです。", tv2.Channel);

            Console.WriteLine("音量を-2します。");
            tv2.VolumeDown();
            tv2.VolumeDown();
            Console.WriteLine("TV2の音量は{0}です。", tv2.Volume);

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }

    }
}
