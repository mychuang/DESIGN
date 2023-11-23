using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Adventurer : Archer
    {
        public override string getType()
        {
            Console.WriteLine("this is Adventurer ");
            return this.GetType().Name;
        }
    }
}
