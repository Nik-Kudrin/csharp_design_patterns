using Patterns.Factory.Ingredients;
using Patterns.Factory.Ingredients.RealIngredient;

namespace Patterns.Factory.AbstractFactory.IngredientFactory
{
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Cheese CeateCheese()
        {
            return new ReggianoCheese();
        }

        public Clam CreateClam()
        {
            return new FreshClam();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
