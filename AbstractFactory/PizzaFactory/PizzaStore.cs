using System;
using Patterns.AbstractFactory.Pizza;

namespace Patterns.AbstractFactory
{
    internal abstract class PizzaStore
    {
        public Pizza.Pizza OrderPizza(String pizzaType)
        {
            var pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.bake();
            pizza.cut();

            return pizza;
        }

        protected abstract Pizza.Pizza CreatePizza(String pizzaType);
    }
}