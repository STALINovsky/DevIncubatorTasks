using System;

namespace Task12
{
    class Program
    {
        /// <summary>
        /// Methods to print types of objects to console
        /// </summary>
        /// <param name="objects"></param>
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
            //testing result of method
            Print(10, "Hello", 10.0);
            Print();
        }
    }
}
