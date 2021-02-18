using System;
using System.Collections.Generic;

namespace Polymorfisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("leo");
            Console.WriteLine(a);
            Console.WriteLine("-------------------------");
            Dog d = new Dog("Santa");
            Console.WriteLine(d);
            Console.WriteLine("-------------------------");
            Cat c = new Cat("Snowball");
            Console.WriteLine("-------------------------");
            List<Animal> animals = new List<Animal>() { a, d, c };
            foreach( Animal animal in animals)
            {
                Console.WriteLine(animal);
                animal.MakeNoise();
                animal.Eat();
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            










        }
    }
}
