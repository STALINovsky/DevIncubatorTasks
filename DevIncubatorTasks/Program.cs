using System;

namespace Task1
{
    static class Program
    {
        static void Main(string[] args)
        {
            //acquaintance with world
            Console.WriteLine("Hello World!");
            
            //declare 2 variables
            string name;
            int age = 19;
           
            // request data
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());

            //display data about user
            Console.WriteLine($"My name is {name}. My age is {age}");
            
        }
    }
}
