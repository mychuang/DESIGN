from Archer import Warrior, Adventurer

class Factory:
    @staticmethod
    def train_archer(type):
        if type == 1:
            return Adventurer()
        elif type == 2:
            return Warrior()
        else:
            return None