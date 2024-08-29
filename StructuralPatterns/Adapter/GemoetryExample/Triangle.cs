using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.GemoetryExample
{
    public class Triangle : ITriangle
    {
        public double BaseLength;
        public double Height;

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public double CalculateAreaOfTriangle()
        {
            return 0.5 * BaseLength * Height;
        }

        public void AboutTriangle()
        {
            Console.WriteLine("I am a triangle!");
        }
    }
}
