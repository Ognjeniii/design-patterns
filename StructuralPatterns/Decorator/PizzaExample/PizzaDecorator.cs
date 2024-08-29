﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.PizzaExample
{
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }

        public virtual decimal Cost()
        {
            return _pizza.Cost();
        }
    }
}
