using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactory.Pizza;
using Patterns.Factory.AbstractFactory.IngredientFactory;

namespace Patterns.AbstractFactory
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza.Pizza CreatePizza(String item)
        {
            Pizza.Pizza pizza;

            IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();

            switch (item)
            {
                case "cheese":
                {
                    pizza = new CheesePizza(pizzaIngredientFactory);
                    return pizza;
                }
                case "clam":
                {
                    pizza = new ClamPizza(pizzaIngredientFactory);
                    return pizza;
                }
                default:
                {
                    return null;
                }
            }
        }
    }
}