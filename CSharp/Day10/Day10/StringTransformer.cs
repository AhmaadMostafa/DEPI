using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class StringTransformer
    {
        public static List<string> TransformList(List<string> inputList, Func<string, string> transformation)
        {
            List<string> resultList = new List<string>();
            foreach (var item in inputList)
            {
                resultList.Add(transformation(item));
            }
            return resultList;
        }
    }
}
