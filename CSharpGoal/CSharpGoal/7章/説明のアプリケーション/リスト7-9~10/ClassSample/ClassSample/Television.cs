using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    public class Television
    {
        private int channel;                 // 現在のチャンネル
        private const int channelMin = 1;    // チャンネル下限
        private const int channelMax = 12;   // チャンネル上限
        private const int volumeMin = 0;     // 音量下限
        private const int volumeMax = 40;    // 音量上限  

        // コンストラクター   
        public Television()
        {
            Console.WriteLine("引数のないコンストラクターの呼び出し");
            Power = false;
            Channel = 1;
            Volume = 20;
        }

        public Television(int channel, int volume)
        {
            Console.WriteLine("引数が2個のコンストラクターの呼び出し");
            Power = false;
            Channel = channel;
            Volume = volume;
        }

        public Television(bool power, int channel, int volume)
        {
            Console.WriteLine("引数が3個のコンストラクターの呼び出し");
            Power = power;
            Channel = channel;
            Volume = volume;
        }

        // プロパティ    
        public bool Power { get; private set; }     // テレビのON/OFF状態
        public int Volume { get; private set; }     // 現在の音量 

        public int Channel
        {
            get { return channel; }
            set {
                if (value >= channelMin && value <= channelMax)
                    channel = value;
            }
        }

        // メソッド    
        // テレビの電源をON/OFFする   
        public void OnOff()
        {
            if (Power == true)
                Power = false;    // 電源OFF    
            else
                Power = true;     // 電源ON   
        }

        // チャンネルを+1する  
        public void ChannelUP()
        {
            if (channel < channelMax)
                channel++;
        }

        // チャンネルを-1する 
        public void ChannelDown()
        {
            if (channel > channelMin)
                channel--;
        }

        // 音量を上げる   
        public void VolumeUP()
        {
            if (Volume < volumeMax)
                Volume++;
        }

        // 音量を下げる   
        public void VolumeDown()
        {
            if (Volume > volumeMin)
                Volume--;
        }
    }
}
