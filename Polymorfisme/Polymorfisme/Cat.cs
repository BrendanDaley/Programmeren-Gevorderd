using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfisme
{
    class Cat : Animal
    {
        public Cat(string name) :base(name)
        {
        }

        public String Name { get; set; }


        public new void MakeNoise()
        {
            base.MakeNoise()
            Console.WriteLine("Miauw");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("eating mice ");
        }


        public override string ToString()
        {
            return $"[Cat] {Name}";
        }






    }
}
