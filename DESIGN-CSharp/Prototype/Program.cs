using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume = new Resume("Jacke", "Newer", 1);
            resume.experience.date = "2021-01-01";
            resume.experience.location = "TW";

            Resume resume2 = (Resume)resume.Clone();
            resume2.level = 5;
            resume2.name = "Miller";
            resume2.experience.date = "2020-09-18";
            resume2.experience.location = "USA";

            Resume resume3 = (Resume)resume2.Clone();
            resume3.name = "Steve";
            resume3.profession = "fighter";
            resume3.level = 20;
            resume3.experience.date = "2019-11-22";
            resume3.experience.location = "CHA";

            Console.WriteLine("The First Resume");
            resume.Display();

            Console.WriteLine("The Second Resume");
            resume2.Display();

            Console.WriteLine("The Third Resume");
            resume3.Display();

            Console.ReadKey();
        }
    }
}
