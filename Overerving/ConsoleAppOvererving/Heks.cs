using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOvererving
{
    class Heks : Troep
    {
        public Heks(String naam, int levenspunten, int aanvalSterkte, double snelheid)
            :base(naam,levenspunten,aanvalSterkte,snelheid)
        {
        }
        public void Verschijn()
        {
            Console.WriteLine("Hier ben ik ");
        }
        public void Verberg()
        {
            Console.WriteLine("Je kan me niet zien hehe ");
        }

        public override string ToString()
        {
            return base.ToString() + $"[heks]";
        }

    }
}
