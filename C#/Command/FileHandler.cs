using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class FileHandler
    {
        private string fileName;
        private DateTime date;
        private bool alreadySaved;

        public FileHandler()
        {
            this.fileName = "";
            date = DateTime.Now;
            alreadySaved = false;
        }

        public bool SaveFile(string fileName)
        {
            if (alreadySaved) return false;
            Console.WriteLine($"\nSaved file: {fileName} on + {date}");
            alreadySaved = true;
            return true;
        }

        public void ReadFile(string fileName)
        {
            if (alreadySaved == false)
            {
                Console.WriteLine($"\nCan not read new file before saving current file\n");
            }
            else
            {
                Console.WriteLine($"\nReading file: {fileName}\n");
            }
        }
    }
}
