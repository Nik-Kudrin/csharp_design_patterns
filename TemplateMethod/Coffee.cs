using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    class Coffee : StandartBeverage
    {
        protected override void AddCondiments()
        {
            // add sugar and milk
        }

        protected override void BrewBeverage()
        {
            // brew coffee in the cup
        }
    }
}
