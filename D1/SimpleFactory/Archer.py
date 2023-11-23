class Archer:
    def get_type(self):
        pass

class Warrior(Archer):
    def get_type(self):
        print("This is Warrior")
        return type(self).__name__

class Adventurer(Archer):
    def get_type(self):
        print("This is Adventurer")
        return type(self).__name__