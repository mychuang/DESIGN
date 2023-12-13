using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class FlightStrategy
    {
        public abstract void execute();
    }

    public class NormalAttack : FlightStrategy
    {
        public override void execute()
        {
            Console.WriteLine("execute normal attack ");
        }
    }

    public class UseSkill : FlightStrategy
    {
        public override void execute()
        {
            Console.WriteLine("execute skill attack ");
        }
    }

    public class UseItem : FlightStrategy
    {
        public override void execute()
        {
            Console.WriteLine("execute item attack ");
        }
    }
}
