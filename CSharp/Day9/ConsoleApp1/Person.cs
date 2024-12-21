using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        #region Problem 3
        public string Name { get; set; }
        public string Department { get; set; }
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Department: {Department}");
        }
        
        #endregion
    }
}
