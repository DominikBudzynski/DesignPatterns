from ICommand import ICommand
from FileHandler import FileHandler

class SaveCommand(ICommand):    
    def __init__(self, fileHandler: FileHandler) -> None:
        print("COMMAND: Creating command\n")
        self.fileHandler = fileHandler

    def Execute(self) -> None:
        print("COMMAND: Executing command from invoker, delegating to logic\n")
        self.fileHandler.SaveFile()