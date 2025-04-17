using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public interface IShape
    {
        double Area { get; }
        void Draw();
    }
}
