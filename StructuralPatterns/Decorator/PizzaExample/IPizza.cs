using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.PizzaExample
{
    public interface IPizza
    {
        string GetPizzaType();
        decimal Cost();
    }
}
