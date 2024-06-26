﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Command
{
    class ReadFileCommand : ICommand
    {
        private FileHandler fileHandler;
        private string fileName;

        public ReadFileCommand(FileHandler fileHadnler, string fileName)
        {
            Console.WriteLine("COMMAND: Creating command");
            this.fileHandler = fileHadnler;
            this.fileName = fileName;
        }

        public void Execute()
        {
            Console.WriteLine("COMMAND: Executing command from invoker, delgating to logic");
            fileHandler.ReadFile(fileName);
        }
    }
}
