using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.CoffeeExample
{
    public class MilkShotDecorator : ICoffee
    {
        protected readonly ICoffee _decoratedCoffee;
        public MilkShotDecorator(ICoffee decoratedCoffee)
        {
            _decoratedCoffee = decoratedCoffee;
            Cost = decoratedCoffee.Cost + 0.75M;
            foreach (var i in decoratedCoffee.Ingredients)
            {
                Ingredients.Add(i);
            }
            Ingredients.Add("milk shot");
        }

        public decimal Cost { get; set; }
        public List<string> Ingredients { get; set; } = new();

    }
}
