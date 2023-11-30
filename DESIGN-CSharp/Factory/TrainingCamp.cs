using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class TrainingCamp
    {
        public abstract Adventurer trainAdventurer();
    }

    public class ArcherCamp : TrainingCamp
    {
        public override Adventurer trainAdventurer()
        {
            Console.WriteLine("train an Archar ");
            return new Archer();
        }
    }

    public class WarriorCamp : TrainingCamp
    {
        public override Adventurer trainAdventurer()
        {
            Console.WriteLine("train an Warrior ");
            return new Warrior();
        }
    }
}
