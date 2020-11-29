using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override decimal Cost()
        {
            return 0.3M;
        }
    }
}
