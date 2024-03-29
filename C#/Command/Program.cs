using System;
using System.Runtime.CompilerServices;

namespace Command
{
    class Program
    {
        static void Main()
        {
            string file = "FILE1";
            FileHandler handler = new FileHandler();
            Invoker button = new Invoker();

            button.SetCommand(new ReadFileCommand(handler, "FILE1"));
            button.ExecuteCommand();

            button.SetCommand(new SaveFileCommand(handler, file));
            button.ExecuteCommand();

            button.SetCommand(new ReadFileCommand(handler, "FILE1"));
            button.ExecuteCommand();

        }
    }
}