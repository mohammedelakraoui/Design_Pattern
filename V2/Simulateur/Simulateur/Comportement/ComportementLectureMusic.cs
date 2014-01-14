using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;
namespace Simulateur.Comportement
{
    class ComportementLectureMusic
    {
        private WindowsMediaPlayer _theplayer;
       
      
        public void PlayMP3(string filepath)
        {
            _theplayer = new WindowsMediaPlayer { URL = filepath };
        }
        public void Play()
        {
            _theplayer.controls.play();
        }
        public void Pause()
        {
            _theplayer.controls.pause();
        }
        public void Stop()
        {
            _theplayer.controls.stop();
        }
    }
}
