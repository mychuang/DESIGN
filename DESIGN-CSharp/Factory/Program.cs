using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //創建訓練營
            TrainingCamp archerCamp = new ArcherCamp();
            TrainingCamp warriorCamp = new WarriorCamp();

            //訓練冒險者
            Adventurer archer = archerCamp.trainAdventurer();
            Adventurer warrior = warriorCamp.trainAdventurer();

            Console.WriteLine("Archer type: " + archer.getType());
            Console.WriteLine("Warrior type: " + warrior.getType());

            Console.ReadKey();
        }
    }
}
