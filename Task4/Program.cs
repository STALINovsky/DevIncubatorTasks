using System;
using System.Diagnostics;

namespace Task4
{
    class Program
    {
        static int ReadNumber()
        {
            return int.Parse(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter number of Day");
                var numberOfDay = ReadNumber();

                string message;
                switch (numberOfDay)
                {
                    case 1:
                        message = "Monday";
                        break;
                    case 2:
                        message = "Tuesday";
                        break;
                    case 3:
                        message = "Wednesday";
                        break;
                    case 4:
                        message = "Thursday";
                        break;
                    case 5:
                        message = "friday";
                        break;
                    case 6:
                        message = "Saturday";
                        break;
                    case 7:
                        message = "Sunday";
                        break;
                    default:
                        return;
                }

                Console.WriteLine(message);
            }
            
        }
    }
}
