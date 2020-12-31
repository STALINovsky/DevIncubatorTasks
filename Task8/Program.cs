using System;

namespace Task8
{
    class Program
    {
        /// <summary>
        /// Calculate operations with two int variable 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Value tuple with result of additional, subtraction, multiplication, division and sum of all operations</returns>
        static (int Addition, int Subtraction, int Multiplication, double Division, double SumOfOperations)
            CalculateExpressions(int a, int b)
        {
            var addition = a + b;
            var subtraction = a - b;
            var multiplication = a * b;
            var division = (double)a / b;
            var sumOfOperations = addition + subtraction + multiplication + division;
            return (a + b, a - b, a * b, (double)a / b, sumOfOperations);
        }
        /// <summary>
        /// Calculate operations with two int variable 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Value tuple with result of additional, subtraction, multiplication, division and sum of all operations
        /// (double Addition, double Subtraction, double Multiplication, double Division, double SumOfOperations)
        /// </returns>
        static (double Addition, double Subtraction, double Multiplication, double Division, double SumOfOperations)
            CalculateExpressions(double a, double b)
        {
            var addition = a + b;
            var subtraction = a - b;
            var multiplication = a * b;
            var division = (double)a / b;
            var sumOfOperations = addition + subtraction + multiplication + division;
            return (a + b, a - b, a * b, (double)a / b, sumOfOperations);
        }

        static void Main(string[] args)
        {

        }
    }
}
