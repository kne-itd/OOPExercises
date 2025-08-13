using System;
using System.Collections.Generic;

namespace Dyrepark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog("Fido", 4),
                new Cat("Misser", 2),
                new Cow("Molly", 5)
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
                Console.WriteLine(animal.Describe());
                Console.WriteLine();
            }
        }
    }
}
