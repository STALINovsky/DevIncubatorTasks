using System;
using System.Collections.Generic;

namespace Task13
{
    class Program
    {
        /// <summary>
        /// sort array by bubble sort algorithm
        /// </summary>
        /// <typeparam name="T">needs to realize IComparable</typeparam>
        /// <param name="collection">Collection to sort</param>
        static void BubbleSort<T>(IList<T> collection) where T : IComparable
        {
            //default realization of bubble sorting 
            for (int i = 1; i <= collection.Count - 1; ++i)
            {
                for (int j = 0; j < collection.Count - i; ++j)
                {
                    if (collection[j].CompareTo(collection[j + 1]) > 0)
                    {
                        //swap elements
                        (collection[j], collection[j + 1]) = (collection[j + 1], collection[j]);
                    }
                }
            }
        }
        /// <summary>
        /// Return numbers by user input
        /// </summary>
        /// <returns></returns>
        static List<int> ReadNumbers()
        {
            var numbers = new List<int>();
            //request to input
            Console.WriteLine("Enter numbers, to stop just press enter");
            while (true)
            {
               var userInput = Console.ReadLine();
               if (userInput == string.Empty)
               {
                   return numbers;
               }
               else
               {
                   numbers.Add(int.Parse(userInput));
               }
            }
        }
        /// <summary>
        /// Method to print array to console
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var obj in collection)
            {
                Console.WriteLine($"{obj} ");
            }
        }


        static void Main(string[] args)
        {
            var numbers = ReadNumbers();

            BubbleSort(numbers);

            PrintCollection(numbers);
        }
    }
}
