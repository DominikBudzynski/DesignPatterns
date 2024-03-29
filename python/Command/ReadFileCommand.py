from ICommand import ICommand
import FileHandler
import string

class ReadFileCommand(ICommand):
    def __init__(self, fileHandler: FileHandler, fileName: string) -> None:
        print("COMMAND: Creating command\n")
        self.fileHandler = fileHandler
        self.fileName = fileName

    def Execute(self) -> None:
        print("COMMAND: Executing command from invoker, delegating to logic\n")
        self.fileHandler.ReadFile(self.fileName)