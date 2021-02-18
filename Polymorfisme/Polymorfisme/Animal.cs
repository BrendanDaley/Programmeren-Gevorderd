using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfisme
{
    class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }
        public String Name { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine("BRRRR");
        }
        public virtual void Eat() // oprioneel te overriden in de subclasses met virtual
        {
            Console.WriteLine("eating");
        }

        public override string ToString()
        {
            return $"[Animal] {Name}";
        }






    }
}
