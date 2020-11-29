using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.State.States;

namespace Patterns.State
{
    internal class GumballMachine
    {
        public SoldState SoldState { get; private set; }
        public NoQuarterState NoQuarterState { get; private set; }
        public HasQuarterState HasQuarterState { get; private set; }

        private Patterns.State.States.State currentState;
        public int CountGumBall { get; private set; }

        public GumballMachine(int numberGumBalls)
        {
            SoldState = new SoldState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);

            this.CountGumBall = numberGumBalls;

            if (CountGumBall > 0)
            {
                currentState = NoQuarterState;
            }
        }


        public void InsertQuarter()
        {
            currentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            currentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            currentState.TurnCrank();
        }

        public void Dispense()
        {
            currentState.Dispense();
        }

        public Patterns.State.States.State GetCurrentState()
        {
            return currentState;
        }

        public void SetCurrentState(Patterns.State.States.State state)
        {
            currentState = state;
        }

        public void ReleaseBall()
        {
            if (CountGumBall > 0)
            {
                CountGumBall -= 1;
            }
        }
    }
}