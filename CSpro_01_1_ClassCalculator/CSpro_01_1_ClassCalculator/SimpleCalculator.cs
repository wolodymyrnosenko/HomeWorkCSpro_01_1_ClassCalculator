using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpro_01_1_ClassCalculator
{
    internal class SimpleCalculator<T> : ISimpleMathOperations<T>
    {
        public dynamic Number1 { get; set; } = 0;
        public dynamic Number2 { get; set; } = 0;
        public SimpleCalculator(T number1, T number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public T Add() => (T)(Number1 + Number2);
        public T Subtract() => (T)(Number1 - Number2);
        public T Multiply() => (T)(Number1 * Number2);
        //public T Divide() => (T)(Number1 / Number2);//Returns infinity, but mistakes in simple math
        public T Divide()
        {
            if(Number2 == 0)
            {
                throw new DivideByZeroException("Ділення на нуль");
            }
            return (T)(Number1 / Number2);
        }

        public static T Add(T number1, T number2) => (T)((dynamic)number1 + (dynamic)number2);
        public static T Subtract(T number1, T number2) => (T)((dynamic)number1 - (dynamic)number2);
        public static T Multiply(T number1, T number2) => (T)((dynamic)number1 * (dynamic)number2);
        //public static T Divide(T number1, T number2) => (T)((dynamic)number1 / (dynamic)number2);
        public static T Divide(T number1, T number2)
        {
            if ((dynamic)number2 == 0)
            {
                throw new DivideByZeroException("Ділення на нуль");
            }
            return (T)((dynamic)number1 / (dynamic)number2);
        }
    }
}
