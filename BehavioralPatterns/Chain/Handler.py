from abc import ABC, abstractmethod
from Request import ApplyRequest

class Manager(ABC):
    def __init__(self, name: str):
        self.name = name
        self.superior = None

    def set_superior(self, superior):
        self.superior = superior

    @abstractmethod
    def apply(self, request: ApplyRequest):
        pass

class CommonManager(Manager):
    def __init__(self, name: str):
        super().__init__(name)

    def apply(self, request: ApplyRequest):
        if request.requestType == "break" and request.requestCount <= 2:
            print(request.requestType + " : " + request.requestContent)
            print(str(request.requestCount) + " is applied by " + self.name)
        elif self.superior is not None:
            self.superior.apply(request)


class MajorDemo(Manager):
    def __init__(self, name: str):
        super().__init__(name)

    def apply(self, request: ApplyRequest):
        if request.requestType == "break" and request.requestCount <= 5:
            print(request.requestType + " : " + request.requestContent)
            print(str(request.requestCount) + " is applied by " + self.name)
        elif self.superior is not None:
            self.superior.apply(request)


class GeneralManager(Manager):
    def __init__(self, name: str):
        super().__init__(name)

    def apply(self, request: ApplyRequest):
        if request.requestType == "break":
            print(request.requestType + " : " + request.requestContent)
            print(str(request.requestCount) + " is applied by " + self.name)
        else:
            print("Error Message")
