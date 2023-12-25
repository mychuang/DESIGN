using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public abstract class Wizzard
    {
        public abstract void fireBall();
    }

    //轉接器
    public class Adapt: Wizzard 
    {
        private Archer archer;

        public Adapt(Archer archer) 
        {
            this.archer = archer;
        }

        public override void fireBall()
        {
            Console.WriteLine("Change the data ");
            archer.shot();
            Console.WriteLine("Change data accomplished ");
        }
    }
}
