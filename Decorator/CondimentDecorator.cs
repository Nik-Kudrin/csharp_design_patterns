using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public abstract String GetDescription();

        public Beverage GetBeverage
        {
            get { return beverage; }
        }
    }
}