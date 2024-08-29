using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.GemoetryExample
{
    public class Rectangle : IRectangle
    {
        public double Length;
        public double Width;
            
        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public double CalculateAreaOfRectangle()
        {
            return Length * Width;
        }

        public void AboutRectangle()
        {
            Console.WriteLine("I am a rectangle!");
        }
    }
}
