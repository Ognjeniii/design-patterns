using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.GemoetryExample
{
    public interface ITriangle
    {
        double CalculateAreaOfTriangle();
        void AboutTriangle();
    }
}
