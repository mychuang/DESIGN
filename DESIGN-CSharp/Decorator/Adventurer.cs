using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //冒險者界面(component) - 規範冒險者的功能
    public abstract class Adventurer
    {
        public abstract void attack();
    }

    class Archer : Adventurer
    {
        public string name { get; set; }

        public Archer(string name) 
        {
            this.name = name;
        }

        public override void attack()
        {
            Console.WriteLine("Archar attack by " + this.name);
        }
    }

    //稱號界面(decorator)
    public abstract class Title : Adventurer 
    {
        protected Adventurer adventurer; //被裝飾的冒險者

        public Title(Adventurer adventurer) 
        {
            this.adventurer = adventurer;
        }

        public override void attack()
        {
            this.adventurer.attack();
        }
    }

    public class TitleStrong: Title
    {

        public TitleStrong(Adventurer adventurer) : base(adventurer)
        {
        }

        public override void attack()
        {
            Console.WriteLine(" Powerful ");
            base.attack();
        }
    }

    public class TitleAgile : Title
    {

        public TitleAgile(Adventurer adventurer) : base(adventurer)
        {
        }

        public override void attack()
        {
            Console.WriteLine(" Fast ");
            base.attack();
        }

        //該稱號的專屬技能
        public void useFlash() 
        {
            Console.WriteLine(" use Fast skill ");
        }
    }

    public class TitleFire : Title
    {

        public TitleFire(Adventurer adventurer) : base(adventurer)
        {
        }

        public override void attack()
        {
            Console.WriteLine(" Burning ");
            base.attack();
        }

        //該稱號的專屬技能
        public void useFire()
        {
            Console.WriteLine(" use Burning skill ");
        }
    }
}
