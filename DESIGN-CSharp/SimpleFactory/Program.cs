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
            Archer A = Factory.trainArcher(1);
            string aClass = A.getType();
            Console.WriteLine(aClass);

            Archer B = Factory.trainArcher(2);
            string bClass = B.getType();
            Console.WriteLine(bClass);

            Console.ReadKey();
        }
    }
}
