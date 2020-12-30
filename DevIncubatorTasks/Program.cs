using System;

namespace Task1
{
    static class Program
    {
        static void Main(string[] args)
        {
            //a)
            Console.WriteLine("Hello World!");
            //declare 2 variables name - user name and age - user age
            string name;
            int age = 19;
            
            //request data for name
            name = Console.ReadLine();
            //request data for age
            age = int.Parse(Console.ReadLine());
            //display data about user
            Console.WriteLine($"My name is {name}, My age is {age}");
               
            //b)
            //declare 3 variables 
            double realNumber;
            byte smallNumber;
            char symbol;

            //request data for variables
            realNumber = double.Parse(Console.ReadLine());
            smallNumber = byte.Parse(Console.ReadLine());
            symbol = char.Parse(Console.ReadLine());


            //display data of variables
            Console.WriteLine($"{realNumber} {smallNumber} {symbol}");
        }
    }
}
