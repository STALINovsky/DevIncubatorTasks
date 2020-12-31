using System;

namespace Task10
{
    class Program
    {
        static void Swap<T>(ref T left, ref T right)
        {
            (left, right) = (right, left);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
