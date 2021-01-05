using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Task17
{
    class Program
    {
        /// <summary>
        /// Read array of age
        /// </summary>
        /// <returns>array of int with age</returns>
        static int?[] ReadAgeArray()
        {
            int arrSize = int.Parse(Console.ReadLine());
            var arrayOfAge = new int?[arrSize];

            for (int i = 0; i < arrayOfAge.Length; i++)
            {
                var userInput = Console.ReadLine();
                arrayOfAge[i] = userInput == string.Empty ? null : int.Parse(userInput);
            }

            return arrayOfAge;
        }
        /// <summary>
        /// Calculate average age by age array
        /// </summary>
        /// <param name="arrOfAge"></param>
        /// <returns></returns>
        static double CalculateAverageAge(IEnumerable<int?> arrOfAge)
        {
            double sumOfAge = 0;
            int countOfAvailableAge = 0;

            foreach (var age in arrOfAge)
            {
                //considering only available values
                if (age.HasValue)
                {
                    countOfAvailableAge++;
                    sumOfAge += age.Value;
                }
            }

            return sumOfAge / countOfAvailableAge;
        }

        static void Main(string[] args)
        {

            var ageArray = ReadAgeArray();
            Console.WriteLine($"average age = {CalculateAverageAge(ageArray),2}");

        }
    }
}
