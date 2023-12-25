using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class VedioRoomFacade
    {
        PS3 ps = new PS3();
        KTVSystem ktv = new KTVSystem();

        public void readyPlayMovie(string cd) 
        {
            ps.powerOn();
            ps.putCD(cd);
        }

        public void playMovie() 
        {
            if (ps.isPowerOn()) 
            {
                ps.play();
            }
        }

        public void turnOffAll() 
        {
            ktv.powerOff();
            ps.powerOff();
        }

        public void readKTV() 
        {
            ktv.powerOn();
        }

        public void selectSong(string song) 
        {
            if (ktv.isPowerOn()) 
            {
                ktv.selectSong(song);
            }
        }

        public void playSong() 
        {
            if (ktv.isPowerOn()) 
            {
                ktv.playSong();
            }
        }

        public void showAllStatus() 
        {
            ps.showStatus();
            ktv.showStatus();
        }
    }
}
