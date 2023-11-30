using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Factory
    {
        public static Adventurer trainAdventurer(int type) {
            if (type == 1)
            {
                return new Archer();
            }
            else if (type == 2)
            {
                return new Warrior();
            }
            else
            {
                return null;
            }
        }
    }
}
