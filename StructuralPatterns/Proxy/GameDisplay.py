from abc import ABC, abstractmethod

class GameDisplay(ABC):
    @abstractmethod
    def play(self):
        pass

class RealGameDisplay(GameDisplay):
    def play(self):
        print("--- Show game ---")

class ProxyGameDisplay(GameDisplay):
    def __init__(self, realGameDisplay: RealGameDisplay):
        self.__realGameDisplay = realGameDisplay
    
    def play(self):
        print("--- Loading game ---")
        self.__realGameDisplay.play()

