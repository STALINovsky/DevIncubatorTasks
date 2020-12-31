using System;

namespace Task12
{
    class Program
    {
        static void Print(params object[] objects)
        {
            foreach (var obj in objects)
            {
                var objectType = obj.GetType();
                Console.Write($"{objectType} ");
            }
        }

        static void Main(string[] args)
        {
            Print(10, "Hello", 10.0);
            Print();
        }
    }
}
