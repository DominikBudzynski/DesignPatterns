import Caretaker
import Originator

if __name__ == "__main__":
    originator = Originator.Originator(2)
    caretaker = Caretaker.Caretaker(originator)

    print(f"\nOriginator {originator.ShowState()}")
    caretaker.Backup()
    originator.DoubleState()

    print(f"\nOriginator {originator.ShowState()}")
    caretaker.Backup()
    originator.DoubleState()

    print(f"\nOriginator {originator.ShowState()}")
    caretaker.Backup()
    originator.DoubleState()    

    print(f"\nOriginator {originator.ShowState()}")
    caretaker.Backup()
    originator.DoubleState()    

    print(f"\nOriginator {originator.ShowState()}")
    caretaker.Backup()
    originator.DoubleState()    

    caretaker.ShowHistory()
    print(f"\nOriginator {originator.ShowState()}")

    caretaker.Restore()

    caretaker.ShowHistory()
    print(f"\nOriginator {originator.ShowState()}")

    caretaker.Restore()

    caretaker.ShowHistory()
    print(f"\nOriginator {originator.ShowState()}")