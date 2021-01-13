using System;

namespace Task30
{
    static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new InvalidArgumentException("Invalid type of argument");
            }
            catch (InvalidArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
