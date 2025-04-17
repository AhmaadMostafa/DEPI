using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class NumberProcessor
    {
        public static List<int> ApplyFunction(List<int> inputList, Func<int, int> operation)
        {
            List<int> resultList = new List<int>();
            foreach (var item in inputList)
            {
                resultList.Add(operation(item));
            }
            return resultList;
        }
    }
}
