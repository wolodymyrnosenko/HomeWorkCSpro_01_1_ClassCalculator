using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpro_01_1_ClassCalculator
{
    internal class EngineerCalculator<T> : SimpleCalculator<T>, ISomeEngineerMathOperations<T>
    {
        public EngineerCalculator(T number1, T number2) : base(number1, number2) { }
        public T Pow() => (T)Math.Pow(Number1, Number2);
        public T Sqrt() => (T)Math.Sqrt(Number1);
        public static T Sqrt(T number) => (T)Math.Sqrt((dynamic)number);
    }
}
