from SimpleCalc import SimpleCalc
from Invoker import Invoker
from AddCommand import AddCommand

if __name__ == "__main__":
    digits = [1, 15]

    calc = SimpleCalc()
    invoker = Invoker(AddCommand(calc, digits))
    invoker.ExecuteCommand()