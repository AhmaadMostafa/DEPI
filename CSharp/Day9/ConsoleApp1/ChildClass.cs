using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Problem 4
    class Parent
    {
        public virtual decimal Salary { get; set; }
    }

    class Child : Parent
    {
        public sealed override decimal Salary { get; set; }

        public void DisplaySalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        }
    }
    #endregion
}
