using StructuralPatterns;
using StructuralPatterns.Adapter.GemoetryExample;
using StructuralPatterns.Decorator;
using StructuralPatterns.Decorator.CoffeeExample;
using StructuralPatterns.Decorator.PizzaExample;

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

            ICoffee coffee = new Coffee();
            coffee = new EspressoShotDecorator(coffee);
            coffee = new MilkShotDecorator(coffee);

            Console.WriteLine("Coffee costs " + coffee.Cost + "$ and has next ingredients: ");
            foreach (var i in coffee.Ingredients)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\n=============================================");

            Console.WriteLine();
            Console.WriteLine("=============== ADAPTER ===============");
            
            Rectangle rectangle = new Rectangle(20, 10);
            Console.WriteLine($"Area of rectangle is {rectangle.CalculateAreaOfRectangle()} sqare unit.");

            Triangle triangle = new Triangle(20, 10);
            Console.WriteLine($"\nArea of triangle is {triangle.CalculateAreaOfTriangle()} sqare unit.\n");

            IRectangle adapter = new TriangleAdapter(triangle);
            Console.WriteLine($"Area of triangle with triangle adapter is {GetArea(adapter)} square unit.");

            static double GetArea(IRectangle r)
            {
                r.AboutRectangle();
                return r.CalculateAreaOfRectangle();
            }
            Console.WriteLine("\n=============================================");
        }
    }
}
