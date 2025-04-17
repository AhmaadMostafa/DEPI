using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class StringProcessor
    {
        public static void ApplyActionToList(List<string> inputList, Action<string> action)
        {
            foreach (var item in inputList)
            {
                action(item);
            }
        }
    }
}
