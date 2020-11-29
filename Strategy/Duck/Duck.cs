using Patterns.BehaviorPattern.DuckBehavior.Quack;
using Patterns.BehaviorPattern.DuckBehaviour;

namespace Patterns.BehaviorPattern.Duck
{
    internal class Duck
    {
        protected IFlyBehavior FlyBehavior { get; set; }
        protected IQuackBehavior QuackBehavior { get; set; }

        public virtual void Display()
        {
        }

        public virtual void Eat()
        {
        }

        public virtual void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public virtual void PerformFly()
        {
            FlyBehavior.Fly();
        }
    }
}