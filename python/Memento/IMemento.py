from abc import ABC, abstractmethod
import string

class IMemento(ABC):

    @abstractmethod
    def RestoreMemento(self) -> None:
        pass

    @abstractmethod
    def ShowMemento() -> string:
        pass