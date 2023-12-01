using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoy
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
            archer.display();

            Adventurer warrior = warriorCamp.trainAdventurer();
            warrior.display();

            Console.ReadKey();
        }
    }
}
