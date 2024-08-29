using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.PizzaExample
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "pizza";
        }

        public decimal Cost()
        {
            return 5.5M;
        }
    }
}
