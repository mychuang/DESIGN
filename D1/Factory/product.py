class Adventurer:
    def getType(self):
        pass

class Warrior(Adventurer):
    def getType(self):
        print("This is Warrior")
        return type(self).__name__

class Archer(Adventurer):
    def getType(self):
        print("This is Adventurer")
        return type(self).__name__