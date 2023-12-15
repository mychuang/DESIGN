class Clothes:
    def __init__(self):
        self.defense = 0

    def display(self):
        print(f"{self.__class__.__name__} defense={self.defense}")

class Armor(Clothes):
    pass

class Leather(Clothes):
    pass

class Weapon:
    def __init__(self):
        self.attack = 0

    def display(self):
        print(f"{self.__class__.__name__} attack={self.attack}")

class Sword(Weapon):
    pass

class Bow(Weapon):
    pass