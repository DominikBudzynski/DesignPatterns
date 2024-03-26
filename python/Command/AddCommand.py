from ICommand import ICommand
from SimpleCalc import SimpleCalc

class AddCommand:    
    def __init__(self, calculator: SimpleCalc, digits: list[float]) -> float:
        print("COMMAND: Creating command\n")
        self.calculator = calculator
        self.digits = digits

    def Execute(self) -> float:
        print("COMMAND: Executing command from invoker, delegating to logic\n")
        self.calculator.Sum(self.digits)