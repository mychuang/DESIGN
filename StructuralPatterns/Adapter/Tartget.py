from abc import ABC, abstractmethod
from Adaptee import Archer

#目標介面
class Wizzard(ABC):
    @abstractmethod
    def fireBall(self):
        pass

#轉接器
class Adapt(Wizzard):
    def __init__(self, archer: Archer):
        self.archer = archer
        
    def fireBall(self):
        print("Change the data ")
        self.archer.shot()
        print("Change data accomplished ")