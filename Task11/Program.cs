using System;
using System.Text;

namespace Task11
{
    class Program
    {
        /// <summary>
        /// Create full name by firstname, middleName, lastName
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        static string CreateFullName(string firstName = "", string middleName = "", string lastName = "")
        {
            var stringBuilder = new StringBuilder();
            var separator = " ";
            //using string concat to make it faster
            return string.Concat(firstName, separator, middleName, separator, lastName);
        }

        static void Main(string[] args)
        {
            //testing result of method
            Console.WriteLine(CreateFullName("Alex"));
            Console.WriteLine(CreateFullName("Fredd","McGregor"));
            Console.WriteLine(CreateFullName(firstName: "Dmitry", lastName: "Ovchinnikov"));
        }
    }
}
