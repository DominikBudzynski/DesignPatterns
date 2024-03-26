
class SimpleCalc:
    def __init__(self) -> None:
        print("CALCULATOR: Creating calculator\n")
        self.sum_ = 0
        self.diff_ = 0
    
    def Sum(self, digits: list[float]) -> float:
        print("CALCULATOR: Calculating sum\n")
        
        if (digits != None):
            self.sum_ = sum(digits)
            return self.sum_
        
    def Diff(self, digits: list[float]) -> float:
        print("CALCULATOR: Calculating difference\n")

        if (digits != None):
            for digit in digits:
                self.diff -= digit
            return self.diff