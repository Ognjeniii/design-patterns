using StructuralPatterns;
using StructuralPatterns.Decorator;

namespace StructuralPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=============== DECORATOR ===============");
            IPizza pizza = new Pizza();
            pizza = new TomatoDecorator(pizza);
            pizza = new OnionDecorator(pizza);
            pizza = new MushroomDecorator(pizza);
            pizza = new CheeseDecorator(pizza);

            Console.WriteLine(pizza.GetPizzaType() + " now costs " + pizza.Cost() + "$");
            Console.WriteLine("\n=============================================");
        }
    }
}
