﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    interface IOriginator
    {
        public IMemento CreateBackup();
    }
}
