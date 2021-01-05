using System;

namespace Task16
{
    class Program
    {
        /// <summary>
        /// Method to Read string array from console if string is Empty then element = null
        /// </summary>
        /// <returns>string arr</returns>
        static string[] ReadStringArray()
        {
            Console.WriteLine("Enter size of array");
            var countOfArray = int.Parse(Console.ReadLine());

            var stringArray = new string[countOfArray];
            //filling array
            for (int i = 0; i < stringArray.Length; i++)
            {
                var itemToAdd = Console.ReadLine();
                if (itemToAdd == string.Empty)
                {
                    itemToAdd = null;
                }

                stringArray[i] = itemToAdd;
            }

            return stringArray;
        }
        /// <summary>
        /// Print string arr, if item is null then show String is Empty
        /// </summary>
        /// <param name="arr">array to show</param>
        static void PrintStringArray(string[] arr)
        {
            const string nullMessage = "String is Empty";
            foreach (var str in arr)
            {
                //writing string if element == null then writing String is Empty
                Console.WriteLine(str ?? nullMessage);
            }
        }

        static void Main(string[] args)
        { 
            //reading array from console
            var array = ReadStringArray();
            Console.WriteLine("Array :");
            //output
            PrintStringArray(array);
        }
    }
}
