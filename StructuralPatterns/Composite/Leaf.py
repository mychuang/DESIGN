from abc import abstractmethod
from component import AbstractAssociation

class Department(AbstractAssociation):
    def __init__(self, name):
        super().__init__(name)

    def add(self, a):
        print("Leaf cannot add node")

    def remove(self, a):
        print("Leaf cannot remove node")

    def display(self, depth):
        for i in range(depth):
            print("-", end="")
        print(self.name)

    @abstractmethod
    def line_of_duty(self):
        pass

class HumanResource(Department):
    def __init__(self, name):
        super().__init__(name)

    def line_of_duty(self):
        print(self.name + ": get people in")

class ServiceDepartment(Department):
    def __init__(self, name):
        super().__init__(name)

    def line_of_duty(self):
        print(self.name + ": handle customers")