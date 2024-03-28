using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    class Memento : IMemento
    {
        private int state;
        private string name;
        private DateTime date;
        private Originator originator;

        public Memento(Originator originator, int state, string name, DateTime date)
        {
            Console.WriteLine("MEMENTO: Creating memento");
            this.originator = originator;
            this.state = state;            
            this.name = name;
            this.date = date;
        }

        //restoring orignator state from memento
        public void RestoreMemento()
        {
            Console.WriteLine($"MEMENTO: Restoring state from {date}");
            originator.SetState(state, name);
        }               

        public override string ToString()
        {            
            return $"State: {state.ToString()}";
        }
    }
}
