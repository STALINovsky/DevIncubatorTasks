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
            // That's because string because strings are loaded from metadata check CIL code or read MsDocs

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

            //e)
            object firstObject = 0;
            object secondObject = 0;
            object thirdObject = 1;

            //checking Equals method
            Console.WriteLine($"{nameof(firstObject)}.Equals({nameof(secondObject)}) = {firstObject.Equals(secondObject)} " +
                              $"{nameof(secondObject)}.Equals({nameof(thirdObject)}) = {secondObject.Equals(thirdObject)} ");

            //checking ReferenceEquals method
            Console.WriteLine($"object.ReferenceEquals({nameof(firstObject)}, {nameof(secondObject)}) = " +
                              $"{object.ReferenceEquals(firstObject, secondObject)} " +

                              $"object.ReferenceEquals({nameof(secondObject)}, {nameof(thirdObject)}) = " +
                              $"{object.ReferenceEquals(secondObject, thirdObject)} ");


            //f - g) 
            //declaring variables for calculator
            byte a;
            byte b;
            //request values for a and b
            Console.WriteLine("Enter A");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = byte.Parse(Console.ReadLine());
            
            //calculate sum
            byte resultOfSum;
            checked // add overflow checking 
            {
                resultOfSum = (byte)(a + b);
            }
            
            Console.WriteLine($"Result of Sum = {resultOfSum}");

            //h 
            long aLong = long.MaxValue;
            int bInt = int.MaxValue;
            
            aLong = bInt;// all is ok because long has larger range;
            //bInt = aLong; that's wrong, we need to use implicit 
            bInt = (int)aLong;// That's works

        }
    }
}
