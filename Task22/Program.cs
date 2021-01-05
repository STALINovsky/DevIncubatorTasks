using System;
using Task22.Animals;

namespace Task22
{
    class Program
    {
        /// <summary>
        /// Factory method return array of different animals
        /// </summary>
        /// <returns></returns>
        static Animal[] CreateAnimals()
        {
            var animals = new Animal[]
            {
                new Horse("Horse",4,false),
                new Horse("Horse",4,false),
                new Kangaroo("Kangaroo",2,false),
                new Kangaroo("Kangaroo",2,false),
                new DragonFly("DragonFly",6,false),
                new DragonFly("DragonFly",6,false),
                new Animal("Unknown Type ",10,true)
            };

            return animals;
        }

        static void Main(string[] args)
        {
            //creating animals
            var animals = CreateAnimals();
            var kangaroo = new Kangaroo("Kangaroo", 4, true);
            var horse = new Horse("Horse", 4, false);
            var dragonFly = new DragonFly("Dragonfly",6,true);
            
            //checking animals voice
            foreach (var animal in animals)
            {
                animal.Voice();
            }

            kangaroo.Voice();
            horse.Voice();
            dragonFly.Voice();

            //checking animals move
            foreach (var animal in animals)
            {
                animal.Move();
            }

            kangaroo.Voice();
            horse.Voice();
            dragonFly.Voice();

            //checking are animals hungry 
            foreach (var animal in animals)
            {
                animal.IsHungry();
            }

            kangaroo.Voice();
            horse.Voice();
            dragonFly.Voice();

        }
    }
}
