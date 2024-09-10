using CreationalPatterns.Factories.VehicleExample.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factories.VehicleExample.CreatorInterface
{
    public interface VehicleFactory // factory interface
    {
        Vehicle createVehicle();
        // factory method
    }
}
