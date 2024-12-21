using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Problem 6
    class ComplexNumber
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber
            {
                Real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                Imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real
            };
        }

        public override string ToString() => $"{Real} + {Imaginary}i";
    }
    #endregion
}
