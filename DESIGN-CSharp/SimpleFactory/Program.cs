using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventurer A = Factory.trainAdventurer(1);
            string aClass = A.getType();
            Console.WriteLine(aClass);

            Adventurer B = Factory.trainAdventurer(2);
            string bClass = B.getType();
            Console.WriteLine(bClass);

            Console.ReadKey();
        }
    }
}
