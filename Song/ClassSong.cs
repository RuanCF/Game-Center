using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Game_Center.Song
{
    public class ClassSong
    {
        SoundPlayer Song = new(Path.GetFullPath(@"..\\Song\\Japanese_Future.wav")); 
        public void PlaySong()
        {
            Song.Play();
        }
        public void PlayLoopSong()
        {
            Song.PlayLooping();
        }

        public void StopSong()
        {
            Song.Stop();
        }

    }
}
  