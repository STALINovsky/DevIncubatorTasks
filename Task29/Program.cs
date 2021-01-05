using System;
using System.Collections.Generic;


namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> circle = new LinkedList<int>();
            var circleCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= circleCount; i++)
            {
                circle.AddLast(i);
            }


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
