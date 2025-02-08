using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Problem 7
    enum Gender : byte { Male, Female }
    internal class GenderEnum
    {
        public static void DisplayGenderSize()
        {
            Console.WriteLine(sizeof(Gender));
        }
    }
    #endregion
}
