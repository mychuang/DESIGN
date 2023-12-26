using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //冒險者協會
    public abstract class AbstractAssociation
    {
        public string name { get; set; }

        public AbstractAssociation(string name)
        {
            this.name = name;
        }

        //新增分會
        public abstract void add(AbstractAssociation a);

        //移除分會
        public abstract void remove(AbstractAssociation a);

        //印出組織結構圖
        public abstract void display(int depth);

        //印出職責
        public abstract void lineOfDuty();
    }

    //Node: 分會
    public class Association : AbstractAssociation 
    {
        private List<AbstractAssociation> branchs = new List<AbstractAssociation>();

        public Association(string name) : base(name) 
        { 
        }

        public override void add(AbstractAssociation a)
        {
            this.branchs.Add(a);
        }

        public override void remove(AbstractAssociation a)
        {
            this.branchs.Remove(a);
        }

        //印出組織結構圖: 使用遞迴方法
        public override void display(int depth)
        {
            for (int i = 0; i < depth; i++) 
            {
                Console.Write("-");
            }

            Console.WriteLine(base.name);

            foreach (AbstractAssociation a in this.branchs)
            {
                a.display(depth + 2);
            }
        }

        //印出職責
        public override void lineOfDuty()
        {
            foreach (AbstractAssociation a in this.branchs)
            {
                a.lineOfDuty();
            }
        }
    }
}