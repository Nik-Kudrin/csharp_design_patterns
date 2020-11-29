using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal sealed class ChocolateBoiler
    {
        private static ChocolateBoiler boiler = new ChocolateBoiler();

        private ChocolateBoiler()
        {
        }

        public static ChocolateBoiler GetChocolateBoiler()
        {
            return boiler;
        }

        public void SomethingMethod()
        {
        }

        public void SomethingAnotherMethod()
        {
        }
    }
}