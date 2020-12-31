using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6
{
    static class Program
    {
        /// <summary>
        /// Return sequence of digit by number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>list of digits [0,9]</returns>
        static List<int> GetListOfNumeral(int number)
        {
            var digits = new List<int>();

            do
            {
                digits.Add(number % 10);
                number /= 10;
            } while (number != 0);

            return digits;
        }
        /// <summary>
        /// Show sequence of numbers
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
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            var digitsOfFirstNumber = GetListOfNumeral(firstNumber);
            var digitsOfSecondNumber = GetListOfNumeral(secondNumber);

            var sameDigits = new List<int>();

            //generate all decimal digits
            for (int i = 0; i < 10; i++)
            {
                //find count of Occurrences
                var countOfFirstNumberOccurrences = digitsOfFirstNumber.Count(digit => digit == i);
                var countOfSecondNumberOccurrences = digitsOfSecondNumber.Count(digit => digit == i);
                //if first and second have this digit
                if (countOfFirstNumberOccurrences >= 1 && countOfSecondNumberOccurrences >= 1)
                {
                    //add digits to collections
                    var countOfSameDigits = countOfFirstNumberOccurrences + countOfSecondNumberOccurrences - 1;
                    for (int j = 0;  j < countOfSameDigits; j++)
                    {
                        sameDigits.Add(i);
                    }
                }
            }


            PrintNumbers(sameDigits);
        }
    }
}
