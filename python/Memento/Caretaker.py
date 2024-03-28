from IMemento import IMemento
from IOriginator import IOriginator

class Caretaker:

    def __init__(self, originator: IOriginator):
        print("CARETAKER: Creating cretaker")
        self.originator = originator
        self.history = list([IMemento])
        self.history.clear()

    def Backup(self) -> None:
        print("CARETAKER: Adding memento to history")
        self.history.append(self.originator.CreateBackup())

    def Restore(self) -> None:
        if (len(self.history) > 0):
            print("CARETAKER: Restoring from history")
            self.history[-1].RestoreMemento()
            self.history.pop()
    
    def ShowHistory(self) -> None:
        print("\nHISTORY")                      
        for mem in self.history:
            print(mem.ShowMemento())