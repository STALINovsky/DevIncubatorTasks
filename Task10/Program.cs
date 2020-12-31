using System;

namespace Task10
{
    class Program
    {
        /// <summary>
        /// Swap two elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static void Swap<T>(ref T left, ref T right)
        {
            (left, right) = (right, left);
        }

        static void Main(string[] args)
        {
            //Assign test variables 
            Console.WriteLine("enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());

            Swap(ref a, ref b);
            //Show result of method
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
