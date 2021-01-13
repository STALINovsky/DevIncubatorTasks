using System;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, decimal> mathOperation;

            Console.WriteLine("Enter first Number");
            var firstNumber = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation");
            var operatorSymbol = Console.ReadLine();

            Console.WriteLine("Enter second number");
            var secondNumber = decimal.Parse(Console.ReadLine());

            mathOperation = operatorSymbol switch
            {
                "+" => (left, right) => left + right,
                "-" => (left, right) => left - right,
                "*" => (left, right) => left * right,
                "/" => (left, right) => left / right,
                _ => throw new ArgumentOutOfRangeException(nameof(operatorSymbol), operatorSymbol, "Invalid type of operation")
            };

            Console.WriteLine($"Result of operation: {mathOperation(firstNumber, secondNumber)}");

        }
    }
}
