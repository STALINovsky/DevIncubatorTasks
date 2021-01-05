using System;
using System.Diagnostics;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();

            //checking time of empty loop
            timer.Start();
            for (int i = 0; i < 1000000000; i++)
            {
                
            }
            timer.Stop();
            Console.WriteLine($"empty loop = {timer.ElapsedMilliseconds} ms");

            //checking time of loop with variable = i;
            timer.Start();
            for (int i = 0; i < 1000000000; i++)
            {
                var variable = i;
            }
            timer.Stop();
            //showing result
            Console.WriteLine($"loop with variable = {timer.ElapsedMilliseconds} ms");
        }
    }
}
