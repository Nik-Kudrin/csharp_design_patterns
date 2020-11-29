using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State.States
{
    class SoldState : State
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            // todo: Please wait, we're already giving you a gumball   
        }

        public override void EjectQuarter()
        {
            // todo: Sorry, you already turned the crank
        }

        public override void TurnCrank()
        {
            // todo: Turning twice doesn't get you another gumball
        }

        public override void Dispense()
        {
            gumballMachine.ReleaseBall();

            if (gumballMachine.CountGumBall > 0)
            {
                gumballMachine.SetCurrentState(gumballMachine.NoQuarterState);
            }
            else
            {
                // todo: Oops, out of gumballs
                //gumballMachine.SetCurrentState(gumballMachine.SoldOutState);
            }
        }
    }
}
