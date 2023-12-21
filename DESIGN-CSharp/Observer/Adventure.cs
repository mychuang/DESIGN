using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Adventure
    {
        protected String name { get; set; }

        public Adventure(String name) 
        {
            this.name = name;
        }

        //接收任務
        public abstract void getQuestions(String questions);
    }

    //弓箭手繼承冒險者
    public class Archer : Adventure
    {
        public Archer(String name) : base(name)
        {
        }

        public override void getQuestions(String questions) 
        {
            Console.WriteLine("Archar get mission");
        }
    }

    //勇士繼承冒險者
    public class Warrior : Adventure
    {
        public Warrior(String name) : base(name)
        {
        }

        public override void getQuestions(String questions)
        {
            if (questions.Length > 10)
            {
                Console.WriteLine("Warrior get mission, The mission is too complex");
            }
            else 
            {
                Console.WriteLine("Warrior get mission, The mission is easy, should be performed");
            }
        }
    }
}
