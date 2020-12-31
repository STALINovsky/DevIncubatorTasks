using System;
using System.Text;

namespace Task11
{
    class Program
    {
        static string CreateFullName(string firstName = "", string middleName = "", string lastName = "")
        {
            var stringBuilder = new StringBuilder();
            var separator = " ";
            return string.Concat(firstName, separator, middleName, separator, lastName);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CreateFullName("Alex"));
            Console.WriteLine(CreateFullName("Fredd","McGregor"));
            Console.WriteLine(CreateFullName(firstName: "Dmitry", lastName: "Ovchinnikov"));
        }
    }
}
