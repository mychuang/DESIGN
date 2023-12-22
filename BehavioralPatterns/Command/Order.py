from abc import ABC, abstractmethod
from KitchenWorker import KitchenWorker

class Order(ABC):
    def __init__(self, receiver: KitchenWorker):
        self.name = None
        self.receiver = receiver
    
    def sendOrder(self):
        self.receiver.finishOrder()

class DrinkOrder(Order):
    def __init__(self, receiver: KitchenWorker):
        super().__init__(receiver)
        self.name = "drinkOrder"

class SnakeOrder(Order):
    def __init__(self, receiver: KitchenWorker):
        super().__init__(receiver)
        self.name = "snakeOrder"