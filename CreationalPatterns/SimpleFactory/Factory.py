from Adventurer import Warrior, Archer

class Factory:
    @staticmethod
    def trainAdventurer(type):
        if type == 1:
            return Archer()
        elif type == 2:
            return Warrior()
        else:
            return None