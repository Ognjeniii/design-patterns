using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class MushroomDecorator : PizzaDecorator
    {
        public MushroomDecorator(IPizza pizza)
            : base(pizza) { }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += ", mushrooms";
            return type;
        }

        public override decimal Cost()
        {
            return base.Cost() + 0.75M;
        }
    }
}
