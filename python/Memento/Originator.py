from IMemento import IMemento
import Memento
from IOriginator import IOriginator
import string

class Originator(IOriginator):

    def __init__(self, state: int) -> None:
        print("ORIGINATOR: Creating originator")
        self.state = state
        self.name = "power x 1"
        self.counter = 1            

    #creating memento initialized with originator internal state
    def CreateBackup(self) -> IMemento:
        print("ORIGINATOR: Saving state")
        return Memento.Memento(self, self.state, self.name)
    
    #setting originator internal state
    def SetState(self, state: int, name: string) -> None:
        self.state = state
        self.name = name
        self.counter -= 1

    #simulating important logic operations
    def DoubleState(self) -> None:
        self.state *= 2
        self.counter += 1
        self.name = f"power x {str(self.counter)}"

    def ShowState(self) -> string:
        return f"State: {str(self.state)} Name: {self.name}"