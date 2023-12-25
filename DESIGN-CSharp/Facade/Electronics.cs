using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public abstract class Electronics
    {
        private bool power = false;

        public void powerOn()
        {
            this.power = true;
        }

        public void powerOff() 
        {
            this.power = false;
        }

        public bool isPowerOn() 
        {
            return this.power;
        }

        public virtual void showStatus() 
        {
            if (this.power)
            {
                Console.WriteLine(this.GetType().Name + " is working ");
            }
            else 
            {
                Console.WriteLine(this.GetType().Name + " not work ");
            }
        }
    }

    public class KTVSystem : Electronics 
    {
        private string song { get; set; }

        public void selectSong(string song) 
        {
            this.song = song;
        }

        public void playSong() 
        {
            Console.WriteLine(" play song: " + this.song);
        }
    }

    public class PS3 : Electronics 
    {
        private string CD { get; set; }

        public void putCD(string CD) 
        {
            this.CD = CD;
        }

        public void play() 
        {
            Console.WriteLine(" play CD: " + this.CD);
        }

        public override void showStatus() 
        {
            base.showStatus();
            if (isPowerOn()) 
            {
                Console.WriteLine(" play CD: " + this.CD);
            }
        }
    }
}
