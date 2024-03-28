from abc import ABC, abstractmethod
from IMemento import IMemento
import string

class IOriginator(ABC):

    @abstractmethod
    def CreateBackup(self) -> IMemento:
        pass

    @abstractmethod
    def ShowState() -> string:
        pass