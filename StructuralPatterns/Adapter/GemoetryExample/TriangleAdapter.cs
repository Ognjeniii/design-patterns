using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.GemoetryExample
{
    public class TriangleAdapter : IRectangle
    {
        Triangle triangle;

        public TriangleAdapter(Triangle triangle)
        {
            this.triangle = triangle;
        }

        // ovde se očekuje vrednost rectangle-a zbog interface-a, mi vraćamo vrednost iz triangle-a
        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }

        // ista priča
        public double CalculateAreaOfRectangle()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}
