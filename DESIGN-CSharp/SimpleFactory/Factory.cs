using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Factory
    {
        public static Archer trainArcher(int type) {
            if (type == 1)
            {
                return new Adventurer();
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
