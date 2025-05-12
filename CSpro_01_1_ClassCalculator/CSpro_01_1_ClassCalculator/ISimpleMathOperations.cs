using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpro_01_1_ClassCalculator
{
    internal interface ISimpleMathOperations<T>
    {
        T Add();
        T Subtract();
        T Multiply ();
        T Divide();
    }
}
