using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Warrior: Archer
    {
        public override string getType() {
            Console.WriteLine("this is Warrior ");
            return this.GetType().Name;
        }
    }
}
