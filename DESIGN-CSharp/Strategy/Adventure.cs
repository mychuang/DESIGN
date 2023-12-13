using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strategy
{
    class Adventure
    {
        FlightStrategy flightStrategy;

        public void attack() 
        {
            if (flightStrategy == null) 
            {
                flightStrategy = new NormalAttack();
            }
            flightStrategy.execute();
        }

        public void choiceStrategy(FlightStrategy strategy)
        {
            this.flightStrategy = strategy;
        }
    }
}
