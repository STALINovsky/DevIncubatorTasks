using System;

namespace Task1
{
    static class Program
    {
        static void Main(string[] args)
        {
            //a)
            //acquaintance with world
            Console.WriteLine("Hello World!");
            
            //declare 2 variables
            string name;
            int age = 19;
           
            // request data
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());

            //display data about user
            Console.WriteLine($"My name is {name}. My age is {age}");
            
            //b)
            //declare 3 variables
            double realNumber;
            byte smallNumber;
            char symbol;
            
            //request data for numbers and symbol
            Console.WriteLine("Enter real number");
            realNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter small number");
            smallNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter symbol");
            symbol = char.Parse(Console.ReadLine());

            //display data
            Console.WriteLine($"{realNumber} {smallNumber} {symbol}");
        }
    }
}
