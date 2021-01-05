using System;

namespace Task18
{
    static class Program
    {
        static string GetNameOfDayOfWeek(int index)
        {
            string message;
            // if index isn't valid, then return index.toString();
            if (index < 1 || index > 7)
            {
                message = index.ToString();
            }
            else
            {
                // use %7 because first element of DayOfWeek enum is Sunday
                message = ((DayOfWeek)(index % 7)).ToString();
            }

            return message;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                // reading index of day of week
                int numberOfDayOfWeek = int.Parse(Console.ReadLine());
                var message = GetNameOfDayOfWeek(numberOfDayOfWeek);

                Console.WriteLine(message);
            }
        }
    }
}
