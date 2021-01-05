using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task15
{
    class Program
    {
        
        /// <summary>
        /// Read string from console without Repetitions
        /// </summary>
        /// <returns>string without Repetitions</returns>
        static string ReadStringWithoutRepetitions()
        {
            var sourceString = Console.ReadLine();
            var words = Regex.Split(sourceString, @"\W+");

            var resultStringBuilder = new StringBuilder(sourceString);
            
            words.Aggregate((left, right) =>
            {
                //if 2 same words follow each other then replace repetition to single word
                if (left == right)
                {
                    resultStringBuilder.Replace($"{left} {right}", left);
                }
                return right;
            });

            return resultStringBuilder.ToString();
        }
        /// <summary>
        /// Reverse source string 
        /// </summary>
        /// <param name="source">string to reverse</param>
        /// <returns>reversed string</returns>
        static string ReverseString(string source)
        {
            var resultStringBuilder = new StringBuilder();
            
            for (int i = source.Length - 1; i >= 0; i--)
            {
                resultStringBuilder.Append(source[i]);
            }

            return resultStringBuilder.ToString();
        }
        /// <summary>
        /// Read string without spaces to Console
        /// </summary>
        /// <returns>count of deleted spaces and string without spaces </returns>
        static (int removedSpacesCount, string ResultString) ReadStringWithoutSpaces()
        {
            // char to stop entering string
            const char stopChar = '.';
            // ignored character
            const char spaceSymbol = ' ';

            var resultStringBuilder = new StringBuilder();

            int countOfSpaces = 0;
            char enteredSymbol;
            do
            {
                enteredSymbol = Console.ReadKey().KeyChar;

                if (enteredSymbol != spaceSymbol)
                {
                    resultStringBuilder.Append(enteredSymbol);
                }
                else
                {
                    countOfSpaces++;
                }

            } while (enteredSymbol != stopChar);

            return (countOfSpaces, resultStringBuilder.ToString());
        }
        /// <summary>
        /// Show string to console in UPPERCASE
        /// </summary>
        /// <param name="source">string to print</param>
        static void PrintOnlyUpperCase(string source)
        {
            var resultStringBuilder = new StringBuilder();
            foreach (var symbol in source.Where(char.IsUpper))
            {
                resultStringBuilder.Append(symbol);
            }

            Console.WriteLine(resultStringBuilder.ToString());
        }

        /// <summary>
        /// print only even elements of string in UPPERCASE
        /// </summary>
        /// <param name="source">string to show</param>
        static void PrintOnlyEvenIndexSymbolsInUpperCase(string source)
        {
            var resultStringBuilder = new StringBuilder();
            for (int i = 0; i < source.Length; i += 2)
            {
                resultStringBuilder.Append(char.ToUpper(source[i]));
            }
            Console.WriteLine(resultStringBuilder.ToString());
        }


        static void Main(string[] args)
        {
            //testing read without repetitions
            Console.WriteLine(ReadStringWithoutRepetitions());
            //testing
            Console.WriteLine(ReadStringWithoutSpaces());

        }
    }
}
