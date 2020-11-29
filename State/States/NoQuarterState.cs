using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State.States
{
    internal class NoQuarterState : State
    {
        private GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            gumballMachine.SetCurrentState(gumballMachine.HasQuarterState);
        }

        public override void EjectQuarter()
        {
            // todo: You haven't insert a quarter
        }

        public override void TurnCrank()
        {
            // todo: You turned, but there's no quarter
        }

        public override void Dispense()
        {
            // todo: You need to pay first
        }
    }
}