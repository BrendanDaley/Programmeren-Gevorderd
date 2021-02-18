using System;
using System.Collections.Generic;

namespace ConsoleAppOvererving
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Heks h = new Heks("Gewndolien", 200, 300, 2.5);
            Kobol k = new Kobol("Karen", 300, 50, 8.0);
            Barbaar b = new Barbaar("Guy", 500, 500, 1.5);
            Console.WriteLine(h);
            Console.WriteLine(k);
            Console.WriteLine(b);
            List<Troep> troepen = new List<Troep>{ h, k, b};
            h.Verschijn();
            b.WordWild();
            foreach(Troep t in troepen)
            {
                t.Beweeg();
            }
            h.Verberg();
            k.SteelGoud();


            //er zijn ook abstacte classen waar we mee werken maar van deze kan je geen instantie maken.


        }
    }
}
