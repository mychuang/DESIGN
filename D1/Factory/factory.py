from product import Warrior, Archer

class TrainingCamp:
    def trainAdventurer(self):
        pass

class ArcherCamp(TrainingCamp):
    def trainAdventurer(self):
        print("train an Archar")
        return Archer()

class WarriorCamp(TrainingCamp):
    def trainAdventurer(self):
        print("train an Warrior")
        return Warrior()