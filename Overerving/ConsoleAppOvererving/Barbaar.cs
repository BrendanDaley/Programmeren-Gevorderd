
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOvererving
{
    class Barbaar :  Troep
    {
        public Barbaar(String naam, int levenspunten, int aanvalSterkte, double snelheid)
            : base(naam, levenspunten, aanvalSterkte, snelheid)
        {
        }

        public void WordWild()
        {
            Console.WriteLine("Barbarian go Brrrrrrrrrrrrrrrt");
        }

        public override string ToString()
        {
            return base.ToString() + $"[barbaar]";
        }
    }
}
