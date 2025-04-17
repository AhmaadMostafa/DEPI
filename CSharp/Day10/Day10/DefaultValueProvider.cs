using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class DefaultValueProvider
    {
        public static T GetDefault<T>()
        {
            return default(T);
        }
    }
}
