using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MinPlayer
{
    public class MinPlayer
    {
        readonly MediaPlayer player = new MediaPlayer();
        public bool NowPlay { get; private set; }
        public Uri Source { get { return player.Source; } }
        public double Volume { get { return player.Volume; } set { player.Volume = value; } }
        public double SpeedRatio { get { return player.SpeedRatio; } set { player.SpeedRatio = value; } }
        public TimeSpan Position { get { return player.Position; } set { player.Position = value; } }
        public void Open(Uri source) {
            if (source == null) { Close(); }
            else { NowPlay = true; player.Open(source); }
        }
        public void Open(string source) { Open(source != "" ? new Uri(source) : null); }
        public void Close() { NowPlay = false; player.Close(); }
        public void Play() { NowPlay = true; player.Play();}
        public void Pause() { NowPlay = false; player.Pause(); }
        public void Stop() { NowPlay = false; player.Stop(); }
        public void PlayPause() { if (NowPlay) { Pause(); } else { Play(); } }
        public event EventHandler MediaEnded
        {
            add { player.MediaEnded += value; }
            remove { player.MediaEnded -= value; }
        }
        public void SetPositionFromRadio(double radio)
        {
            double time = player.NaturalDuration.TimeSpan.TotalMilliseconds * radio;
            player.Position = TimeSpan.FromMilliseconds(time);
        }

    }
}
