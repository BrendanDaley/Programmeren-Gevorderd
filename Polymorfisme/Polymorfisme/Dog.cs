
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfisme
{
    class Dog : Animal
    {
        public Dog(string name) :base(name)
        {
        }
        public String Name { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine("Bark");
        }

        public void Eat()
        {
            Console.WriteLine("Eating dog food");
        }

        public override string ToString()
        {
            return $"[Dog] {Name}";
        }






    }
}
