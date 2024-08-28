using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza)
            : base(pizza) { }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += ", onions";
            return type;
        }

        public override decimal Cost()
        {
            return base.Cost() + 0.45M;
        }
    }
}
