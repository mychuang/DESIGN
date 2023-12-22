from abc import ABC, abstractmethod

class KitchenWorker(ABC):
    @abstractmethod
    def finishOrder(self):
        pass

class Barkeep(KitchenWorker):
    def finishOrder(self):
        print("Complete Baverage")

class Chef(KitchenWorker):
    def finishOrder(self):
        print("Complete Food")
