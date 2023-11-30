using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Archer : Adventurer
    {
        public override string getType()
        {
            Console.WriteLine("this is Adventurer ");
            return this.GetType().Name;
        }
    }
}
