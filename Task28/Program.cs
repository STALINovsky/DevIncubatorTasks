using System;
using System.Collections.Generic;

namespace Task28
{
    class Program
    {
        /// <summary>
        /// Method to check is number a prime number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsNumberPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Method to generate list array of prime numbers
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<int> GetPrimeNumbers(int count)
        {
            var primeNumbers = new int[count];

            int primeNumberCandidate = 2;
            for (int i = 0; i < count; i++)
            {
                while (!IsNumberPrime(primeNumberCandidate))
                {
                    primeNumberCandidate += 1;
                }

                primeNumbers[i] = primeNumberCandidate;
                primeNumberCandidate += 1;
            }

            return primeNumbers;
        }

        static void Main(string[] args)
        {
            //read count of prime numbers
            Console.WriteLine("Enter count of prime numbers");
            int countOfPrimeNumbers = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(' ',GetPrimeNumbers(countOfPrimeNumbers)));
        }
    }
}
