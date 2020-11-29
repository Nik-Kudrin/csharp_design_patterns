using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    internal class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            beverage.Description += " + Whip";
        }

        public override String GetDescription()
        {
            return beverage.Description;
        }

        public override decimal Cost()
        {
            return 0.0381M + beverage.Cost();
        }
    }
}