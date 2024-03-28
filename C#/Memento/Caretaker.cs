using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    class Caretaker
    {
        private List<IMemento> history;
        private IOriginator originator;

        public Caretaker(IOriginator originator)
        {
            Console.WriteLine("CARETAKER: Creating caretaker");
            this.originator = originator;
            history = new List<IMemento>();
        }

        //adding memento to the history
        public void Backup()
        {
            Console.WriteLine("CARETAKER: Adding memento to history");
            history.Add(originator.CreateBackup());
        }

        //restoring originator state from last element in history
        public void Restore()
        {
            if (history.Count > 0 && originator != null)
            {
                Console.WriteLine("CARETAKER: Restoring from history");
                history.Last().RestoreMemento();
                history.Remove(history.Last());
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("HISTORY");
            foreach (IMemento mem in history)
            {
                Console.WriteLine(mem.ToString());
            }
        }

    }
}
