using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing circle with radius: {Radius}");
        }

    }
}
