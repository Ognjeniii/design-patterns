using CreationalPatterns.Factories.VehicleExample.ConcreteProducts;
using CreationalPatterns.Factories.VehicleExample.CreatorInterface;
using CreationalPatterns.Factories.VehicleExample.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factories.VehicleExample.ConcreteCreators
{
    public class TwoWheelerFactory : VehicleFactory
    {
        public Vehicle createVehicle()
        {
            return new TwoWheeler();
        }
    }
}
