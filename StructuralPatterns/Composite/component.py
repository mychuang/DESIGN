from abc import ABC, abstractmethod

class AbstractAssociation(ABC):
    def __init__(self, name):
        self.name = name

    @abstractmethod
    def add(self, a):
        pass

    @abstractmethod
    def remove(self, a):
        pass

    @abstractmethod
    def display(self, depth):
        pass

    @abstractmethod
    def line_of_duty(self):
        pass

class Association(AbstractAssociation):
    def __init__(self, name):
        super().__init__(name)
        self.branches = []

    def add(self, a):
        self.branches.append(a)

    def remove(self, a):
        self.branches.remove(a)

    def display(self, depth):
        for i in range(depth):
            print("-", end="")
        print(self.name)

        for a in self.branches:
            a.display(depth + 2)

    def line_of_duty(self):
        for a in self.branches:
            a.line_of_duty()