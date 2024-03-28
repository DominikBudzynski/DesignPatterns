using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    class Originator : IOriginator
    {
        private int state;
        private string name;
        private int counter;
        private DateTime date;

        public Originator(int state)
        {
            Console.WriteLine("ORIGINATOR: Creating originator");
            this.state = state;
            name = "multiplier x 1";
            counter = 1;
            date = DateTime.Now;
        }

        //creating memento initialized with originator internal state
        public IMemento CreateBackup()
        {
            Console.WriteLine("ORIGINATOR: Saving state");
            return new Memento(this, state, name, date);

        }

        //setting originator internal state
        public void SetState(int state, string name)
        {
            this.state = state;
            this.name = name;
        }        

        //simulating important logic operations
        public void DoubleState()
        {
            //Console.WriteLine("ORIGINATOR: Changing state value");
            state *= 2;
            counter++;
            name = "multiplier x " + counter.ToString();
        }

        public override string ToString()
        {
            return "State: " + state.ToString() + " Name: " + name.ToString();
        }
    }
}
