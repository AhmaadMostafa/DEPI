using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class Calculator
    {
        public static int PerformOperation(int a, int b, Func<int, int, int> operation)
        {
            return operation(a, b);
        }
    }
}
