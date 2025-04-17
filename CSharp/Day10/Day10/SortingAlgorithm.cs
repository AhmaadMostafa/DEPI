using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class SortingAlgorithm<T> 
    {
        public void Sort(T[] array, Comparison<T> comparison)
        {
            Array.Sort(array, comparison);
        }
        public static void Swap<TItem>(TItem[] array, int index1, int index2)
        {
            TItem temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

    }
}
