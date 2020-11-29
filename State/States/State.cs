using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State.States
{
    internal abstract class State
    {
        public abstract void InsertQuarter();
        public abstract void EjectQuarter();
        public abstract void TurnCrank();
        public abstract void Dispense();
    }
}