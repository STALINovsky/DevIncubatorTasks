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
            
            //declare 2 variables user's name and age
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
            
            //c)
            //declare variables to check their range of values
            byte x = 255;
            //check compilation error
            //x = 1000; 
            //x = 256;

            sbyte y = sbyte.MaxValue; // 127
            //check compilation error
            //y = sbyte.MaxValue + 1;// 128

            int z = int.MaxValue; //2147483647
            //check compilation error
            //z = Int32.MaxValue + 1; 2147483648

            float g = float.MaxValue; //~ 3.4 x 10^38
            //check compilation error
            g = float.MaxValue + float.MaxValue; // all works, but value of g is infinity
            
            //d)
            //declare variables
            string firstString = "Hello";
            string secondString = "Hello";
            string thirdString = "Hello";
            
            
            //display hash code 
            Console.WriteLine($"{nameof(firstString)}.GetHashCode() = {firstString.GetHashCode()}, " +
                              $" {nameof(secondString)}.GetHashCode() = {secondString.GetHashCode()}, " +
                              $" {nameof(thirdString)}.GetHashCode() = {thirdString.GetHashCode()}");
            //display values
            Console.WriteLine($"{nameof(firstString)} = {firstString}, " +
                              $" {nameof(secondString)} = {secondString}, " +
                              $" {nameof(thirdString)} = {thirdString}");
            
            // All hashes are same because all variables refer to same object
            // That's because string made by Flyweight pattern check CIL code or read MsDocs

            //declare number variables
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            
            //display hash code
            Console.WriteLine($"{nameof(firstNumber)}.GetHashCode() = {firstNumber.GetHashCode()}, " +
                              $"{nameof(secondNumber)}.GetHashCode() = {secondNumber.GetHashCode()}, " +
                              $"{nameof(thirdNumber)}.GetHashCode() = {thirdNumber.GetHashCode()}");
            
            Console.WriteLine($"{nameof(firstNumber)} = {firstNumber}, " +
                              $" {nameof(secondNumber)} = {secondNumber}, " +
                              $" {nameof(thirdNumber)} = {thirdNumber}");
            //all numbers are different and hashes are too;


        }
    }
}
