from abc import ABC, abstractmethod

# 觀察者介面
class Adventure(ABC):
    def __init__(self, name: str):
        self.name = name
    
    @abstractmethod
    def getQuestions(self, questions: str):
        pass

class Archer(Adventure):
    def getQuestions(self, questions: str):
        print(f"Archer gets mission: {questions}")

class Warrior(Adventure):
    def getQuestions(self, questions: str):
        print(f"Warrior gets mission: {questions}")
        if len(questions) > 10:
            print("The mission is too complex")
        else:
            print("The mission is easy, should be performed")