from Adventurer import Warrior, Archer

class TrainingCamp:
    def train_adventurer(self):
        pass

class ArcherCamp(TrainingCamp):
    def trainAdventurer(self):
        print("train an Archer")
        return Archer()

class WarriorCamp(TrainingCamp):
    def trainAdventurer(self):
        print("train a Warrior")
        return Warrior()