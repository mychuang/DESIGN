using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoy
{
    public abstract class Clothes
    {
        protected internal int def { get; set; }

        public void display()
        {
            Console.WriteLine(this.GetType().Name + " defense=" + def);
        }
    }

    public class Armor : Clothes
    {
    }

    public class Leather : Clothes
    {
    }

    public abstract class Weapon
    {
        protected internal int atk;

        public void display()
        {
            Console.WriteLine(this.GetType().Name + " attack=" + atk);
        }
    }

    public class Sword : Weapon
    {
    }

    public class Bow : Weapon
    {
    }

}