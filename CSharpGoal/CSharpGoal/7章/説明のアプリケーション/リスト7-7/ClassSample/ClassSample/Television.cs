using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    public class Television
    {
        private bool power;                  // 電源の状態
        private int channel;                 // 現在のチャンネル
        private int volume;                  // 現在の音量
        private const int channelMin = 1;    // チャンネル下限
        private const int channelMax = 12;   // チャンネル上限
        private const int volumeMin = 0;     // 音量下限
        private const int volumeMax = 40;    // 音量上限  

        // プロパティ    
        public bool Power
        {
            get { return power; }
        }

        public int Channel
        {
            get { return channel; }
            set {
                if (value >= channelMin && value <= channelMax)
                    channel = value;
            }
        }

        public int Volume {
            get { return volume; }
        }

        // メソッド    
        // テレビの電源をON/OFFする   
        public void OnOff()
        {
            if (power == true)
                power = false;    // 電源OFF    
            else
                power = true;     // 電源ON   
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
            if (volume < volumeMax)
                volume++;
        }

        // 音量を下げる   
        public void VolumeDown()
        {
            if (volume > volumeMin)
                volume--;
        }
    }
}
