using System;
using System.Collections.Generic;
using System.Text;

namespace Task22.Animals
{
    class DragonFly : Animal
    {
        public DragonFly(string animalName, int footNumber, bool hasMustache) : base(animalName, footNumber, hasMustache)
        {
            
        }

        //overriding methods
        public override void Voice()
        {
            Console.WriteLine("bj-w-w");
        }

        public override void Move()
        {
            Console.WriteLine("flight");
        }

        public override void IsHungry()
        {
            Console.WriteLine("I want insets");
        }
    }
}
