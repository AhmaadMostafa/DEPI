using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class NumberFilter
    {
        public static List<int> FilterList(List<int> inputList, Predicate<int> predicate)
        {
            List<int> resultList = new List<int>();
            foreach (var item in inputList)
            {
                if (predicate(item))
                {
                    resultList.Add(item);
                }
            }
            return resultList;
        }

    }
}
