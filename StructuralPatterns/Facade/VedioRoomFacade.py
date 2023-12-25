from Electronics import PS3, KTVSystem

class VideoRoomFacade:
    def __init__(self):
        self.ps = PS3()
        self.ktv = KTVSystem()

    def ready_play_movie(self, cd):
        self.ps.power_on()
        self.ps.put_CD(cd)

    def play_movie(self):
        if self.ps.is_power_on():
            self.ps.play()

    def turn_off_all(self):
        self.ktv.power_off()
        self.ps.power_off()

    def read_ktv(self):
        self.ktv.power_on()

    def select_song(self, song):
        if self.ktv.is_power_on():
            self.ktv.select_song(song)

    def play_song(self):
        if self.ktv.is_power_on():
            self.ktv.play_song()

    def show_all_status(self):
        self.ps.show_status()
        self.ktv.show_status()