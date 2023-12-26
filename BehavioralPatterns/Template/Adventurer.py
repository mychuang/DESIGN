class Adventurer():
    def __init__(self):
        self.level = 0
        self.type = ""

class GundamJustice(Adventurer):
    def __init__(self):
        super().__init__()
        self.type = "Gundam-Justice"
        self.level = 100

class Sabar(Adventurer):
    def __init__(self):
        super().__init__()
        self.type = "Sabar"
        self.level = 10