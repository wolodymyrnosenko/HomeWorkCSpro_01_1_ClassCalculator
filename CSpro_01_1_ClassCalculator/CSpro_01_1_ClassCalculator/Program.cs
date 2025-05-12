using System.Text;

namespace CSpro_01_1_ClassCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;//To display "infinity" when divide by zero. Also ukrainian output.

            try
            {
                Console.WriteLine(SimpleCalculator<double>.Divide(50.23, 0));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            Console.WriteLine(SimpleCalculator<double>.Divide(50.23, 10));

            //ISimpleMathOperations<double> CalcTest = new SimpleCalculator<double>(345.67, 98.21);//No access throw interface to fields of class SimpleCalculator
            SimpleCalculator<double> simpleCalcTest = new SimpleCalculator<double>(345.67, 98.21);
            Console.WriteLine($"{simpleCalcTest.Number1} + {simpleCalcTest.Number2} = {simpleCalcTest.Add()}");
            simpleCalcTest = new SimpleCalculator<double>(345.67, 0);
            try
            {
                Console.WriteLine(simpleCalcTest.Divide());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            
            Console.WriteLine(EngineerCalculator<double>.Sqrt(144));
            EngineerCalculator<double> engCalc = new EngineerCalculator<double>(10, 3);
            Console.WriteLine($"{engCalc.Number1} ^ {engCalc.Number2} = {engCalc.Pow()}");

            ISimpleMathOperations<double> calcTest = new SimpleCalculator<double>(2000, 500);
            Console.WriteLine(calcTest.Subtract());
            calcTest = new EngineerCalculator<double>(100, 3);
            //Console.WriteLine(calcTest.Sqrt());//No access to method of ISomeEngineerOperations, cause type ISimpleMathOperations
            Console.WriteLine(calcTest.Divide());
        }
    }
}
