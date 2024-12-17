using System;
using System.Buffers;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1
{
    #region Problem 1
    public interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }
    #endregion

    #region Problem 2
    public class SquareSeries : IShapeSeries
    {
        public int CurrentShapeArea { get; set; }
        private int sideLength = 1;

        public void GetNextArea()
        {
            CurrentShapeArea = sideLength * sideLength;
            sideLength++;
        }

        public void ResetSeries()
        {
            sideLength = 1;
            CurrentShapeArea = 1;
        }
    }

    public class CircleSeries : IShapeSeries
    {
        public int CurrentShapeArea { get; set; }
        private int radius = 1;

        public void GetNextArea()
        {
            CurrentShapeArea = (int)(Math.PI * radius * radius);
            radius++;
        }

        public void ResetSeries()
        {
            radius = 1;
            CurrentShapeArea = (int)(Math.PI * radius * radius);
        }
    }

    public class ShapePrinter
    {
        public void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine($"Shape {i + 1}: {series.CurrentShapeArea}");
            }
        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            IShapeSeries squareSeries = new SquareSeries();
            IShapeSeries circleSeries = new CircleSeries();

            ShapePrinter printer = new ShapePrinter();

            Console.WriteLine("First 10 areas of SquareSeries:");
            printer.PrintTenShapes(squareSeries);

            Console.WriteLine("\nFirst 10 areas of CircleSeries:");
            printer.PrintTenShapes(circleSeries);
        }
    }
}
