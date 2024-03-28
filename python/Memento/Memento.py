from IMemento import IMemento
import Originator
import string
import datetime

class Memento(IMemento):

    def __init__(self, originator: Originator, state: int, name: string) -> None:
        print("MEMENTO: Creating memento")
        self.originator = originator
        self.state = state
        self.name = name
        self.date = datetime.date.today()

    def RestoreMemento(self) -> None:
        print(f"MEMENTO: Restoring state from {self.date}")
        self.originator.SetState(self.state, self.name)

    def ShowMemento(self) -> string:
        return f"State: {str(self.state)}"