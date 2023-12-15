from abc import ABC, abstractmethod

# 冒險者界面(component) - 規範冒險者的功能
class Adventurer(ABC):
    @abstractmethod
    def attack(self):
        pass

class Archer(Adventurer):
    def __init__(self, name):
        self.name = name

    def attack(self):
        print(f"Archer attack by {self.name}")

# 稱號界面(decorator)
class Title(Adventurer, ABC):
    def __init__(self, adventurer):
        self.adventurer = adventurer

    def attack(self):
        self.adventurer.attack()

class TitleStrong(Title):
    def __init__(self, adventurer):
        super().__init__(adventurer)

    def attack(self):
        print("Powerful", end=" ")
        super().attack()

class TitleAgile(Title):
    def __init__(self, adventurer):
        super().__init__(adventurer)

    def attack(self):
        print("Fast", end=" ")
        super().attack()

    def useFlash(self):
        print(" use Fast skill")

class TitleFire(Title):
    def __init__(self, adventurer):
        super().__init__(adventurer)

    def attack(self):
        print("Burning", end=" ")
        super().attack()

    def useFire(self):
        print(" use Burning skill")