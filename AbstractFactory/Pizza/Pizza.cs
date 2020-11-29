using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory.AbstractFactory.IngredientFactory;
using Patterns.Factory.Ingredients;

namespace Patterns.AbstractFactory.Pizza
{
    public abstract class Pizza
    {
        protected Dough dough;
        protected Sauce sauce;
        protected Clam clam;
        protected Cheese cheese;

        protected IPizzaIngredientFactory pizzaIngredientFactory;

        public abstract void Prepare();

        public void bake()
        {
        }

        public void cut()
        {
        }
    }
}