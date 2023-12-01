using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoy
{
    public abstract class EquipmentFactory
    {
        public abstract Weapon produceWeapon();

        public abstract Clothes produceClothes();
    }

    public class WarriorEquipmentFactory : EquipmentFactory
    {
        public override Clothes produceClothes()
        {
            Clothes armor = new Armor();
            armor.def = 10;
            return armor;
        }

        public override Weapon produceWeapon()
        {
            Weapon sword = new Sword();
            sword.atk = 100;
            return sword;
        }
    }

    public class ArcherEquipmentFactory : EquipmentFactory
    {
        public override Clothes produceClothes()
        {
            Clothes leather = new Leather();
            leather.def = 8;
            return leather;
        }

        public override Weapon produceWeapon()
        {
            Weapon bow = new Bow();
            bow.atk = 102;
            return bow;
        }
    }
}
