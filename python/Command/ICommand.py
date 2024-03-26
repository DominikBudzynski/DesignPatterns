from abc import ABC, abstractmethod

class ICommand(ABC):
    
    @abstractmethod
    def Execute(self):
        pass