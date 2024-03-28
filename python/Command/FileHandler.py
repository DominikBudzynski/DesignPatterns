import string
import datetime

class FileHandler:
    def __init__(self, fileName: string) -> None:
        self.fileName = fileName
        self.date = datetime.date.today()
        self.alreadySaved = False

    def SaveFile(self) -> None:
        if not (self.alreadySaved):
            print("Saved file: " + self.fileName + " on " + str(self.date))
            self.alreadySaved = True
