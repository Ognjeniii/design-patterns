using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.CoffeeExample
{
    public class EspressoShotDecorator : ICoffee
    {
        protected readonly ICoffee _decoratedCoffee;
        public EspressoShotDecorator(ICoffee decoratedCoffee)
        {
            _decoratedCoffee = decoratedCoffee;
            Cost = decoratedCoffee.Cost + 1;
            foreach (var i in decoratedCoffee.Ingredients)
            {
                Ingredients.Add(i);
            }
            Ingredients.Add("espresso shot");
        }

        public decimal Cost { get; set; }
        public List<string> Ingredients { get; set; } = new();
    }
}
