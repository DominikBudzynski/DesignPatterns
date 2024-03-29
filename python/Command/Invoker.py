from ICommand import ICommand

class Invoker():        
    def __init__(self, command: ICommand = None) -> None:
        print("INVOKER: Creating invoker\n")
        self.command = command
    
    def SetCommand(self, command: ICommand) -> None:
        print("INVOKER: Setting new command\n")
        self.command = command
    
    def ExecuteCommand(self) -> float:
        print("INVOKER: Executing command")
        if (self.command != None):
            self.command.Execute()