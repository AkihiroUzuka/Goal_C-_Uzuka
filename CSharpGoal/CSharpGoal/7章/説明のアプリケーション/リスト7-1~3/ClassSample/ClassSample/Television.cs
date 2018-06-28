using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    public class Television
    {
        public bool power;                  // 電源の状態
        public int channel;                 // 現在のチャンネル
        public int volume;                  // 現在の音量
        public const int channelMin = 1;    // チャンネル下限
        public const int channelMax = 12;   // チャンネル上限
        public const int volumeMin = 0;     // 音量下限
        public const int volumeMax = 40;    // 音量上限  

        // メソッド    
        // テレビの電源をON/OFFする   
        public void OnOff()
        {
            if (power == true)
                power = false;    // 電源OFF    
            else
                power = true;     // 電源ON   
        }

        // チャンネルを設定する
        public void SetChannel(int c)
        {
            if (c >= channelMin && c <= channelMax)
                channel = c;
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
