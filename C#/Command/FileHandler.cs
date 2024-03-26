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

        public FileHandler(string fileName)
        {
            this.fileName = fileName;
            date = DateTime.Now;
            alreadySaved = false;
        }

        public bool SaveFile()
        {
            if (alreadySaved) return false;
            Console.WriteLine("Saved file: " + fileName.ToString() + " on " + date.ToString());
            alreadySaved = true;
            return true;
        }

        public void ChangeFile()
        {
            if (alreadySaved)
            {
                Console.WriteLine("Changed file successfully");
            }
            else
            {
                Console.WriteLine("Current file not saved, can't change file");
            }
        }
    }
}
