using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Problem 9
    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return Name == other.Name && Department == other.Department;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Department);
        }
    }

    static class Helper2<T>
    {
        public static bool SearchArray(T[] array, T value)
        {
            foreach (var item in array)
            {
                if (item.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
    }
    #endregion

}
