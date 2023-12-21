from abc import ABC, abstractmethod
from Adventurer import  Adventure

# 被觀察者介面
class Subject(ABC):
    def __init__(self):
        self._list = []

    def add(self, observer: Adventure):
        self._list.append(observer)

    def remove(self, observer: Adventure):
        self._list.remove(observer)
    
    @abstractmethod
    def sendQuestions(self, questions: str):
        pass

class Association(Subject):
    def sendQuestions(self, questions: str):
        for adventure in self._list:
            adventure.getQuestions(questions)