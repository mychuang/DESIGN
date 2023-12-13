from FlightStrategy import NormalAttack, UseSkill, UseItem

class Adventure:
    def __init__(self):
        self.flightStrategy = None

    def attack(self):
        if self.flightStrategy is None:
            self.flightStrategy = NormalAttack()
        self.flightStrategy.execute()

    def chooseStrategy(self, strategy):
        self.flightStrategy = strategy