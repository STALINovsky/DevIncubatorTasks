using System;
using System.Data;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating users
            var users = new User[]
            {
                new User(1, "Alice", "Cooper",19),
                new User(2 , "Andrew",null, 20),
                new User(3, "Alex","Gordon", 26),
            };
            //init table by users 
            var table = new Table<User>("Id | First Name | SurName | Age", users);

            //show table information
            Console.WriteLine("Table has:");
            Console.WriteLine(table.ToString());
        }
    }
}
