using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Task22.Animals
{
    /// <summary>
    /// Base class for animals
    /// </summary>
    class Animal
    {
        public string AnimalName { get; set; }
        public int FootNumber { get; set; }
        public bool HasMustache { get; set; }

        public Animal()
        {
            
        }

        public Animal(string animalName, int footNumber, bool hasMustache)
        {
            AnimalName = animalName;
            FootNumber = footNumber;
            HasMustache = hasMustache;
        }

        //base implementation of virtual methods
        public virtual void Voice()
        {
            Console.WriteLine("Voice");
        }

        public virtual void Move()
        {
            Console.WriteLine("Movement");
        }

        public virtual void IsHungry()
        {
            Console.WriteLine("Not hungry");
        }

    }
}
