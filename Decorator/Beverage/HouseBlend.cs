using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    internal class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend";
        }

        public override decimal Cost()
        {
            return 0.8511M;
        }
    }
}