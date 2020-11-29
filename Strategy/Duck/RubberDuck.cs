using Patterns.BehaviorPattern.DuckBehavior;
using Patterns.BehaviorPattern.DuckBehavior.Quack;

namespace Patterns.BehaviorPattern.Duck
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }
    }
}