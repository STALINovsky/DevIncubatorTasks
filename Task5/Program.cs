using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Task5
{
    class Program
    {
        /// <summary>
        /// Method return List of even numbers [min,max]
        /// </summary>
        /// <param name="min">start of range</param>
        /// <param name="max">end of range</param>
        /// <returns>even numbers between [min,max]</returns>
        static List<int> GetRangeOfEvenNumbers(int min, int max)
        {
            var evenNumbers = new List<int>();
            for (int i = min; i <= max; i++)
            {
                if (i % 2 != 0) // if number isn't even, then start new iteration
                {
                    continue;
                }
                evenNumbers.Add(i);
            }

            return evenNumbers;
        }

        /// <summary>
        /// Show sequence of numbers on console
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintNumbers(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        static void Main(string[] args)
        {
            //define and assign limits of even numbers
            Console.WriteLine("Enter first Limit");
            int firstLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Limit");
            int secondLimit = int.Parse(Console.ReadLine());

            //guarantees the correct work of the method
            var evenNumbers = firstLimit > secondLimit
                ? GetRangeOfEvenNumbers(secondLimit, firstLimit)
                : GetRangeOfEvenNumbers(firstLimit, secondLimit);
            
            //output
            PrintNumbers(evenNumbers);
        }
    }
}
