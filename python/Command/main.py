from FileHandler import FileHandler
from Invoker import Invoker
from SaveFileCommand import SaveFileCommand
from ReadFileCommand import ReadFileCommand

if __name__ == "__main__":
    file = "FILE1"
    fileHandler = FileHandler()
    invoker = Invoker()
    invoker.SetCommand(ReadFileCommand(fileHandler, file))
    invoker.ExecuteCommand()

    invoker.SetCommand(SaveFileCommand(fileHandler, file))
    invoker.ExecuteCommand()

    invoker.SetCommand(ReadFileCommand(fileHandler, file))
    invoker.ExecuteCommand()