using System;
using System.Runtime.CompilerServices;

namespace Command
{
    class Program
    {
        static void Main()
        {
            string file = "FILE1";
            FileHandler handler = new FileHandler(file);

            Invoker button = new Invoker(new SaveCommand(handler));
            button.ExecuteCommand();
        }
    }
}