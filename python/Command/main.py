from FileHandler import FileHandler
from Invoker import Invoker
from SaveCommand import SaveCommand

if __name__ == "__main__":
    file = "FILE1"
    fileHandler = FileHandler(file)

    invoker = Invoker(SaveCommand(fileHandler))
    invoker.ExecuteCommand()