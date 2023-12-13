using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure adventure = new Adventure();

            adventure.choiceStrategy(new NormalAttack());
            adventure.attack();

            adventure.choiceStrategy(new UseSkill());
            adventure.attack();

            adventure.choiceStrategy(new UseItem());
            adventure.attack();

            Console.ReadKey();
        }
    }
}
