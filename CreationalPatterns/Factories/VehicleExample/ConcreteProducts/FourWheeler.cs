using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatterns.Factories.VehicleExample.ProductInterface;

namespace CreationalPatterns.Factories.VehicleExample.ConcreteProducts
{
    public class FourWheeler : Vehicle
    {
        public override void printVehicle()
        {
            Console.WriteLine("I am four wheeler!");
        }
    }
}
