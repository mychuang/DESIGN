from EquipmentFactory import WarriorEquipmentFactory, ArcherEquipmentFactory

class Adventurer:
    def __init__(self):
        self.weapon = None
        self.clothes = None

    def display(self):
        pass

class Archer(Adventurer):
    def __init__(self):
        super().__init__() #super().__init__() 來調用父類的構造函數
        archerEquipmentFactory = ArcherEquipmentFactory()
        self.weapon = archerEquipmentFactory.produceWeapon()
        self.clothes = archerEquipmentFactory.produceClothes()

    def display(self):
        print("this is an archer; show equipment data")
        self.weapon.display()
        self.clothes.display()
        print("-------------------------------------")

class Warrior(Adventurer):
    def __init__(self):
        super().__init__()
        warriorEquipmentFactory = WarriorEquipmentFactory()
        self.weapon = warriorEquipmentFactory.produceWeapon()
        self.clothes = warriorEquipmentFactory.produceClothes()

    def display(self):
        print("this is a warrior; show equipment data")
        self.weapon.display()
        self.clothes.display()
        print("-------------------------------------")