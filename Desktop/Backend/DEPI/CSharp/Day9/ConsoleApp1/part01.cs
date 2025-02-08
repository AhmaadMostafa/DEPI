using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Problem 10
    static class Helper
    {
        public static T Max<T>(T x, T y) where T : IComparable<T>
        {
            return x.CompareTo(y) > 0 ? x : y;
        }
    }
    #endregion

    #region Problem 11
    static class Helper3<T>
    {
        public static void ReplaceArray(T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(oldValue))
                {
                    array[i] = newValue;
                }
            }
        }
    }
    #endregion

    #region Problem 12
    struct Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Length: {Length}, Width: {Width}");
        }
    }

    static class RectangleHelper
    {
        public static void Swap(ref Rectangle r1, ref Rectangle r2)
        {
            var temp = r1;
            r1 = r2;
            r2 = temp;
        }
    }
    #endregion

    #region Problem 13
    class Department
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Department other)
            {
                return Name == other.Name;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }

    class EmployeeWithDepartment
    {
        public string Name { get; set; }
        public Department Department { get; set; }
    }
    #endregion

    #region Problem 14
    struct Circle1
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Circle1 other)
            {
                return Radius == other.Radius && Color == other.Color;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Radius, Color);
        }
    }

    class Circle
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Circle other)
            {
                return Radius == other.Radius && Color == other.Color;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Radius, Color);
        }
    }
    #endregion

}

