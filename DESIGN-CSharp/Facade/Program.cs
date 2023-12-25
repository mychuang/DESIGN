using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            VedioRoomFacade superRemote = new VedioRoomFacade();

            superRemote.showAllStatus();

            //Play KTV
            superRemote.readKTV();
            superRemote.selectSong("Moon");
            superRemote.playSong();
            superRemote.showAllStatus();

            Console.ReadKey();
        }
    }
}
