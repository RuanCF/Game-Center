using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Game_Center.Song
{
    public class ClassSong
    {
        public void PlaySong()
        {
            SoundPlayer Song = new(@"C:\\Users\\ruan-\\Documents\\C#\\Game-Center\\Song\\8Bit-Nostalgia.wav");
            Song.Play();
        }

    }
}
