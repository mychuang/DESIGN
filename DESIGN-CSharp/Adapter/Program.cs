using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer = new NormalArcher();

            Console.WriteLine("We need an adapter ");
            
            Wizzard wizzard = new Adapt(archer);

            wizzard.fireBall();

            Console.ReadKey();
        }
    }
}
