using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //for example some kind of button
    class Invoker
    {
        private ICommand? command;


        public Invoker()
        {
            command = null;
        }
        public Invoker(ICommand command)
        {
            Console.WriteLine("INVOKER: Creating invoker");
            this.command = command;
        }

        public void SetCommand(ICommand command)
        {
            Console.WriteLine("INVOKER: Setting new command");
            this.command = command;
        }        

        public void ExecuteCommand()
        {
            Console.WriteLine("INVOKER: Executing command");
            if (command != null)
            {
                command.Execute();
            }
        }

    }
}
