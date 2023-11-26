using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.Prak
{

    internal class Program
    {
        public delegate double MathOperation(double a, double b);
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b) => a / b;
        public static double PerformOperation(double a, double b, MathOperation operation)
        {
            return operation(a, b);
        }

        static void Main(string[] args)
        {
            var sample = new SampleClass();
            sample.Propertychanged += (sender, e) =>
            {
                Console.WriteLine($"Свойство {e.PropertyName} было изменено.");
            };

            sample.SampleProperty = 5;
            MathOperation opAdd = Add;
            MathOperation opSubtract = Subtract;
            MathOperation opMultiply = Multiply;
            MathOperation opDivide = Divide;

            MathOperation opLambdaAdd = (x, y) => x + y;
            MathOperation opAnonymousSubtract = delegate (double x, double y) { return x - y; };

            Console.WriteLine(PerformOperation(10, 5, opAdd));
            Console.WriteLine(PerformOperation(10, 5, opLambdaAdd));
            Console.WriteLine(PerformOperation(10, 5, opAnonymousSubtract));

            MathOperation opChain = opAdd + opSubtract;
            opChain += opMultiply;
            opChain(10, 5);
            Console.ReadKey();
        }
    }
}
