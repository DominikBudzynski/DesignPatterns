using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Command
{
    class SaveCommand : ICommand
    {
        private FileHandler fileHandler;        

        public SaveCommand(FileHandler fileHadnler)
        {
            Console.WriteLine("COMMAND: Creating command");
            this.fileHandler = fileHadnler;            
        }

        public void Execute()
        {
            Console.WriteLine("COMMAND: Executing command from invoker, delgating to logic");
            fileHandler.SaveFile();
        }
    }
}
