using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza)
            : base(pizza) { }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += ", cheese";
            return type;
        }

        public override decimal Cost()
        {
            return base.Cost() + 1.15M;
        }
    }
}
