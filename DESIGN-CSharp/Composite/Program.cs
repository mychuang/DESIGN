using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // 創建冒險者協會
            AbstractAssociation root = new Association("Adventrurer Head");
            root.add(new HumanResource("Adventrurer Head - Human Resource"));
            root.add(new ServiceDepartment("Adventrurer Head - Service Department"));

            //創建分會
            AbstractAssociation mars = new Association("Mars Adventrurer");
            mars.add(new HumanResource("Mars Adventrurer - Human Resource"));
            mars.add(new ServiceDepartment("Mars Adventrurer - Service Department"));
            root.add(mars);

            AbstractAssociation saturn = new Association("Saturn Adventrurer");
            saturn.add(new HumanResource("Saturn Adventrurer - Human Resource"));
            saturn.add(new ServiceDepartment("Saturn Adventrurer - Service Department"));
            root.add(saturn);

            //創建分會下的子分會
            AbstractAssociation saturn01 = new Association("Saturn 01 Adventrurer");
            saturn01.add(new HumanResource("Saturn 01 Adventrurer - Human Resource"));
            saturn01.add(new ServiceDepartment("Saturn 01 Adventrurer - Service Department"));
            saturn.add(saturn01);

            AbstractAssociation saturn02 = new Association("Saturn 02 Adventrurer");
            saturn02.add(new HumanResource("Saturn 02 Adventrurer - Human Resource"));
            saturn.add(saturn02);

            Console.WriteLine("");
            Console.WriteLine("--- Show Structure ---");
            Console.WriteLine("");

            root.display(1);

            Console.WriteLine("");
            Console.WriteLine("--- Show Duty ---");
            Console.WriteLine("");

            root.lineOfDuty();

            Console.ReadKey();
        }
    }
}
