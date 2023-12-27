using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public abstract class GameDisplay
    {
        public abstract void play();
    }

    //被代理的類別
    public class RealGameDisplay : GameDisplay 
    {
        public override void play()
        {
            Console.WriteLine("--- Show game ---");
        }
    }

    //代理類別
    public class ProxyGameDisplay : GameDisplay 
    {
        private RealGameDisplay realGameDisplay;

        public ProxyGameDisplay(RealGameDisplay realGameDisplay) 
        {
            this.realGameDisplay = realGameDisplay;
        }

        public override void play()
        {
            Console.WriteLine("--- Loading game ---");
            this.realGameDisplay.play(); //跑這段程式碼可能要花費很多時間
        }
    }
}
