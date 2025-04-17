using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class MathOperations
    {
        public static int PerformOperation(int a, int b, Func<int, int, int> operation)
        {
            return operation(a, b);
        }
        public static double PerformOperation(double a, double b, Func<double, double, double> operation)
        {
            return operation(a, b);
        }
    }
}
