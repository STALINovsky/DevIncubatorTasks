using System;
using System.Collections.Generic;
using System.Text;

namespace Task22.Animals
{
    class Kangaroo : Animal
    {
        public Kangaroo(string animalName, int footNumber, bool hasMustache) : base(animalName, footNumber, hasMustache)
        {
        }
        //overriding methods
        public override void Voice()
        {
            Console.WriteLine("Khe-khe");
        }

        public override void Move()
        {
            Console.WriteLine("jump-jump");
        }

        public override void IsHungry()
        {
            Console.WriteLine("I want berries");
        }
    }
}
