using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory.AbstractFactory.IngredientFactory;
using Patterns.Factory.Ingredients;

namespace Patterns.AbstractFactory.Pizza
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.pizzaIngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            dough = pizzaIngredientFactory.CreateDough();
            sauce = pizzaIngredientFactory.CreateSauce();
            cheese = pizzaIngredientFactory.CeateCheese();
        }
    }
}