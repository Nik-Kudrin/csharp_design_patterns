using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State.States
{
    internal class HasQuarterState : State
    {
        private GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            // todo: You can't insert another quarter
        }

        public override void EjectQuarter()
        {
            gumballMachine.SetCurrentState(gumballMachine.NoQuarterState);
        }

        public override void TurnCrank()
        {
            gumballMachine.SetCurrentState(gumballMachine.SoldState);
        }

        public override void Dispense()
        {
            // todo: No gumball dispensed
        }
    }
}