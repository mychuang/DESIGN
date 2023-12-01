using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoy
{
    public abstract class Adventurer
    {
        protected internal Weapon weapon;
        
        protected internal Clothes clothes;

        public abstract void display();
    }

    public class Archer : Adventurer
    {
        public Archer()
        {
            EquipmentFactory archerEquipmentFactory = new ArcherEquipmentFactory();
            weapon = archerEquipmentFactory.produceWeapon();
            clothes = archerEquipmentFactory.produceClothes();
        }

        public override void display()
        {
            Console.WriteLine("this is an archer; show equipment data");
            weapon.display();
            clothes.display();
            Console.WriteLine("-------------------------------------");
        }
    }

    public class Warrior : Adventurer
    {
        public Warrior()
        {
            EquipmentFactory warriorEquipmentFactory = new WarriorEquipmentFactory();
            weapon = warriorEquipmentFactory.produceWeapon();
            clothes = warriorEquipmentFactory.produceClothes();
        }

        public override void display()
        {
            Console.WriteLine("this is a warrior; show equipment data");
            weapon.display();
            clothes.display();
            Console.WriteLine("-------------------------------------");
        }
    }
}
