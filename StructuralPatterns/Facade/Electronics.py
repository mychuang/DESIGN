class Electronics:
    def __init__(self):
        self.power = False

    def power_on(self):
        self.power = True

    def power_off(self):
        self.power = False

    def is_power_on(self):
        return self.power

    def show_status(self):
        if self.power:
            print(type(self).__name__ + " is working ")
        else:
            print(type(self).__name__ + " not work ")


class KTVSystem(Electronics):
    def __init__(self):
        super().__init__()
        self.song = ""

    def select_song(self, song):
        self.song = song

    def play_song(self):
        print(" play song: " + self.song)


class PS3(Electronics):
    def __init__(self):
        super().__init__()
        self.CD = ""

    def put_CD(self, CD):
        self.CD = CD

    def play(self):
        print(" play CD: " + self.CD)

    def show_status(self):
        super().show_status()
        if self.is_power_on():
            print(" play CD: " + self.CD)