from Equipment import Armor, Leather, Sword, Bow

class EquipmentFactory:
    def produceWeapon(self):
        pass

    def produceClothes(self):
        pass

class WarriorEquipmentFactory(EquipmentFactory):
    def produceClothes(self):
        armor = Armor()
        armor.defense = 10
        return armor

    def produceWeapon(self):
        sword = Sword()
        sword.attack = 100
        return sword


class ArcherEquipmentFactory(EquipmentFactory):
    def produceClothes(self):
        leather = Leather()
        leather.defense = 8
        return leather

    def produceWeapon(self):
        bow = Bow()
        bow.attack = 102
        return bow