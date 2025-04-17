using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area
        {
            get { return Width * Height; }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing rectangle: {Width} x {Height}");
        }

    }
}
