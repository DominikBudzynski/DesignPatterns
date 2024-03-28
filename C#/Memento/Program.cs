using System;

namespace Memento.Memento
{

    class Program
    {
        static void Main()
        {
            Originator originator = new Originator(2);
            Caretaker caretaker = new Caretaker(originator);

            Console.WriteLine("\nOriginator " + originator.ToString());
            caretaker.Backup();
            originator.DoubleState();            

            Console.WriteLine();
            Console.WriteLine("\nOriginator " + originator.ToString());
            caretaker.Backup();
            originator.DoubleState();

            Console.WriteLine();
            Console.WriteLine("\nOriginator " + originator.ToString());
            caretaker.Backup();
            originator.DoubleState();

            Console.WriteLine();
            Console.WriteLine("\nOriginator " + originator.ToString());
            caretaker.Backup();
            originator.DoubleState();

            Console.WriteLine();
            Console.WriteLine("\nOriginator " + originator.ToString());
            caretaker.Backup();
            originator.DoubleState();

            Console.WriteLine("\nOriginator " + originator.ToString());
            caretaker.ShowHistory();

            caretaker.Restore();
            Console.WriteLine("\nOriginator " + originator.ToString());
            caretaker.ShowHistory();

            caretaker.Restore();
            Console.WriteLine("\nOriginator " + originator.ToString());
            caretaker.ShowHistory();
        }
    }
}