using System;

namespace Task8
{
    class Program
    {
        static (int Addition, int Subtraction, int Multiplication, double Division, double SumOfOperations)
            CalculateExpressions(int a, int b)
        {
            var addition = a + b;
            var subtraction = a - b;
            var multiplication = a * b;
            var division = (double)a / b;
            var sumOfOperations = addition + subtraction + multiplication + division;
            return (a + b, a - b, a * b, (double) a / b, sumOfOperations);
        }

        static (double Addition, double Subtraction, double Multiplication, double Division, double SumOfOperations)
            CalculateExpressions(double a, double b)
        {
            var addition = a + b;
            var subtraction = a - b;
            var multiplication = a * b;
            var division = (double)a / b;
            var sumOfOperations = addition + subtraction + multiplication + division;
            return (a + b, a - b, a * b, (double) a / b, sumOfOperations);
        }

        static void Main(string[] args)
        {
            
        }
    }
}
