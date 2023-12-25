from abc import ABC, abstractmethod

class Archer(ABC):
    @abstractmethod
    def shot(self):
        pass

class NormalArcher(Archer):
    def shot(self):
        print(f"Shoot!")