using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //創建沒有稱號的弓箭手
            Adventurer archer = new Archer("Miller");
            Console.WriteLine(" --- Archar Miller ---");
            archer.attack();

            Console.WriteLine(" ");
            
            Console.WriteLine(" --- get Strong Archar Miller ---");
            TitleStrong sArcher = new TitleStrong(archer);
            sArcher.attack();

            Console.WriteLine(" ");

            Console.WriteLine(" --- get Agile Strong Archar Miller ---");
            TitleAgile aArcher = new TitleAgile(sArcher);
            aArcher.attack();

            Console.WriteLine(" ");

            Console.WriteLine(" --- get Fire Agile Strong Archar Miller ---");
            TitleFire fArcher = new TitleFire(aArcher);
            fArcher.attack();

            Console.WriteLine(" ");

            Console.WriteLine(" --- get Strong Fire Agile Strong Archar Miller ---");
            TitleStrong ssArcher = new TitleStrong(fArcher);
            ssArcher.attack();

            Console.ReadKey();
        }
    }
}
