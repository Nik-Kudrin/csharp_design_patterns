using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    internal class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            beverage.Description += " + Mocha";
        }

        public override String GetDescription()
        {   
            return beverage.Description;
        }

        public override decimal Cost()
        {
            return 0.001M + beverage.Cost();
        }
    }
}