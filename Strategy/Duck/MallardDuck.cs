using Patterns.BehaviorPattern.DuckBehavior;
using Patterns.BehaviorPattern.DuckBehavior.Quack;

namespace Patterns.BehaviorPattern.Duck
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Squeak();
        }
    }
}