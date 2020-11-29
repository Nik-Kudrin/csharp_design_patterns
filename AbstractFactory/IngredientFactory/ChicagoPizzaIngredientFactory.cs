using Patterns.Factory.Ingredients;
using Patterns.Factory.Ingredients.RealIngredient;

namespace Patterns.Factory.AbstractFactory.IngredientFactory
{
    internal class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Cheese CeateCheese()
        {
            return new Mozzarella();
        }

        public Clam CreateClam()
        {
            return new FrozzenClam();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}