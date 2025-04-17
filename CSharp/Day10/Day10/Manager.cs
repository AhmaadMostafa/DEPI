using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class Manager : Employee, IComparable<Manager>
    {
        public int CompareTo(Manager other)
        {
            if (other == null) return 1;
            return Salary.CompareTo(other.Salary);
        }
    }
}
