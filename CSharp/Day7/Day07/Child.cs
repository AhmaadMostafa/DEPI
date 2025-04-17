using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public void Display()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z}");
        }

        public override int Product()  
        {
            return X * Y * Z;
        }
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

    }
}
