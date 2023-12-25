using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public abstract class Archer
    {
        public abstract void shot();
    }

    public class NormalArcher : Archer 
    {
        public override void shot()
        {
            Console.WriteLine("Shoot! ");
        }
    }
}
