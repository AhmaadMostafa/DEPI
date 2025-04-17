using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class StringFilter
    {
        public static List<string> FilterList(List<string> inputList, Predicate<string> condition)
        {
            List<string> resultList = new List<string>();
            foreach (var item in inputList)
            {
                if (condition(item))
                {
                    resultList.Add(item);
                }
            }
            return resultList;
        }

    }
}
