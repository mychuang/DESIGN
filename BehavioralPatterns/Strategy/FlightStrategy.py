class FlightStrategy:
    def execute(self):
        pass

class NormalAttack(FlightStrategy):
    def execute(self):
        print("execute normal attack ")

class UseSkill(FlightStrategy):
    def execute(self):
        print("execute skill attack")

class UseItem(FlightStrategy):
    def execute(self):
        print("execute item attack")