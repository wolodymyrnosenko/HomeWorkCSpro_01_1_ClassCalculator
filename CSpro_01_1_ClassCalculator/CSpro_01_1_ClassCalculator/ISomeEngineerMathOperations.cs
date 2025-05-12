using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpro_01_1_ClassCalculator
{
    internal interface ISomeEngineerMathOperations<T>
    {
        T Pow();
        T Sqrt();
    }
}
