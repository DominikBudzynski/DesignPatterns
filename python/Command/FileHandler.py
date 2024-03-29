import string
import datetime

class FileHandler:
    def __init__(self) -> None:
        self.fileName = ""
        self.date = datetime.date.today()
        self.alreadySaved = False

    def SaveFile(self, fileName: string) -> None:
        if not (self.alreadySaved):
            print(f"Saved file: {fileName} on {str(self.date)}")
            self.alreadySaved = True

    def ReadFile(self, fileName: string) -> None:
        if (self.alreadySaved == False):
            print("\nCan not read new file before saving current file\n")
        else:
            print(f"\nReading file: {fileName}\n")