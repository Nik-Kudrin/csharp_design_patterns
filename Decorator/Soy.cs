using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    internal class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {   
            this.beverage = beverage;
            beverage.Description += " + Soy";
        }

        public override String GetDescription()
        {
            return beverage.Description;
        }

        public override decimal Cost()
        {
            return 0.12M + beverage.Cost();
        }
    }
}