﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class SortingTwo<T>
    {
        public void Sort(T[] array, Comparison<T> comparison)
        {
            Array.Sort(array, comparison);
        }
    }
}
