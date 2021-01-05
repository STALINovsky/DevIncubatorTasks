using System;
using System.Collections.Generic;


namespace Task29
{
    class Program
    {
        /// <summary>
        /// Method that fill list [1, count]
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        static LinkedList<int> InitCircle(int count)
        {
            LinkedList<int> circle = new LinkedList<int>();
            for (int i = 1; i <= count; i++)
            {
                circle.AddLast(i);
            }

            return circle;
        }

        static void Main(string[] args)
        {
            //create circle
            var circleCount = int.Parse(Console.ReadLine());
            var circle = InitCircle(circleCount);
            
            //loop that remove every even element while circle count isn't 1
            bool isElementEven = false;
            LinkedListNode<int> currentElement = circle.First;
            while (circle.Count != 1)
            {
                var nextElement = currentElement.Next ?? circle.First;

                if (isElementEven)
                {
                    circle.Remove(currentElement);
                }

                isElementEven = !isElementEven;
                currentElement = nextElement;
            }

            Console.WriteLine(circle.First.Value);
            
        }
    }
}
