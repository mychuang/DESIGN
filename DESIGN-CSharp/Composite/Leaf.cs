using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // 部門單位
    public abstract class Department: AbstractAssociation
    {
        public Department(string name) : base(name) {}

        public override void add(AbstractAssociation a)
        {
            Console.WriteLine("Leaf cannot add node");
        }

        public override void remove(AbstractAssociation a)
        {
            Console.WriteLine("Leaf cannot remove node");
        }

        public override void display(int depth)
        {
            for (int i = 0; i < depth; i++) 
            {
                Console.Write("-");
            }

            Console.WriteLine(this.name);
        }

        public abstract override void lineOfDuty(); //到子類別再決定實作
    }

    //人力支援部門
    public class HumanResource : Department 
    {
        public HumanResource(string name) : base(name) { }

        public override void lineOfDuty()
        {
            Console.WriteLine(this.name + ": get people in");
        }
    }

    //客服部門
    public class ServiceDepartment : Department
    {
        public ServiceDepartment(string name) : base(name) { }

        public override void lineOfDuty()
        {
            Console.WriteLine(this.name + ": handle customers");
        }
    }
}
