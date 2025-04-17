using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class ListTransformer
    {
        public static List<R> TransformList<T, R>(List<T> inputList, Func<T, R> transformation)
        {
            List<R> resultList = new List<R>();
            foreach (var item in inputList)
            {
                resultList.Add(transformation(item));
            }
            return resultList;
        }
    }
}
