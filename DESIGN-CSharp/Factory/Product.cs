using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Adventurer
    {
        public abstract string getType();
    }

    public class Archer : Adventurer
    {
        public override string getType()
        {
            Console.WriteLine("this is Archar ");
            return this.GetType().Name;
        }
    }

    public class Warrior : Adventurer
    {
        public override string getType()
        {
            Console.WriteLine("this is Warrior ");
            return this.GetType().Name;
        }
    }
}
