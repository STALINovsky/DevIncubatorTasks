using System;
using System.Collections.Generic;
using System.Text;

namespace Task22.Animals
{
    class Horse :Animal
    {
        public Horse(string animalName, int footNumber, bool hasMustache) : base(animalName, footNumber, hasMustache)
        {
        }
        //overriding methods
        public override void Voice()
        {
            Console.WriteLine("I-go-go");
        }

        public override void Move()
        {
            Console.WriteLine("Top-top");
        }

        public override void IsHungry()
        {
            Console.WriteLine("I want Hay");
        }
    }
}
