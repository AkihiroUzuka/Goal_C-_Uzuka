using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample_p._263
{
    class Television : ElectronicProducts
    {
        //フィールド
        private int channel;
        private const int channelMin = 1;
        private const int channelMax = 12;
        private const int volumeMin = 0;
        private const int volumeMax = 40;

        //コンストラクター
        public Television()
        {
            Volume = 20;
            channel = 1;
        }

        //プロパティ
        public int Volume { get; private set; }
        public int Channel
        {
            get { return channel; }
            set
            {
                if (value >= channelMin && value <= channelMax)
                    channel = value;
            }
        }

        //メソッド
        //チャンネルを+1する
        public void ChannelUP()
        {
            if (channel < channelMax)
                channel++;
        }

        //チャンネルを-1する
        public void ChannelDown()
        {
            if (channel > channelMin)
                channel--;
        }

        //音量を上げる
        public void VolumeUP()
        {
            if (Volume < volumeMax)
                Volume++;
        }

        //音量を下げる
        public void VolumeDown()
        {
            if (Volume > volumeMin)
                Volume--;
        }

    }
}
