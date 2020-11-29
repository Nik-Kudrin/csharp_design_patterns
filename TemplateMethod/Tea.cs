using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    internal class Tea : StandartBeverage
    {
        protected override void AddCondiments()
        {
            // add lemon
        }

        protected override void BrewBeverage()
        {
            // brew tea in the cup
        }

        protected override void AdditionalPreparation()
        {
            // add some pieces of orange
        }
    }
}