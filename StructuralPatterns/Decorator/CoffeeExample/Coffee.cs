using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.CoffeeExample
{
    public class Coffee : ICoffee
    {
        public Coffee()
        {
            Cost = 1.15M;
            Ingredients.Add("base coffee");
        }
        public decimal Cost { get; set; }
        public List<string> Ingredients { get; set; } = new();
    }
}
