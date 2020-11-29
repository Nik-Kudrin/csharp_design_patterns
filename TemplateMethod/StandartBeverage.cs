using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    internal abstract class StandartBeverage
    {
        public void PrepareBeverage()
        {
            BoilWater();
            BrewBeverage();
            Pour();
            AddCondiments();
            AdditionalPreparation();
        }

        protected virtual void AdditionalPreparation()
        {
        }

        protected abstract void AddCondiments();

        protected abstract void BrewBeverage();

        private void Pour()
        {
        }

        private void BoilWater()
        {
        }
    }
}