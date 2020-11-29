using Patterns.Factory.Ingredients;

namespace Patterns.Factory.AbstractFactory.IngredientFactory
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CeateCheese();
        Clam CreateClam();
    }
}