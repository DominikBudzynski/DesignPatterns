﻿using System;
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
        private Originator originator;

        public Memento(Originator originator, int state, string name)
        {
            Console.WriteLine("MEMENTO: Creating memento");
            this.originator = originator;
            this.state = state;            
            this.name = name;
        }

        //restoring orignator state from memento
        public void RestoreMemento()
        {
            Console.WriteLine("MEMENTO: Restoring state");
            originator.SetState(state, name);
        }               

        public override string ToString()
        {
            Console.Write("MEMENTO: Getting memento state: ");
            return state.ToString();
        }
    }
}
