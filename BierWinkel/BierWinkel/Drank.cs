
using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel
{
    public class Drank
    {
        public Drank(double prijsPerStuk, string naam, Setgrootte? minimumHoeveelheid)
        {
            PrijsPerStuk = prijsPerStuk;
            Naam = naam;
        }

        public Drank(double prijsPerStuk, string naam, Setgrootte? minimumHoeveelheid, Drankspecificatie drankspecificatie)
        {
            if (prijsPerStuk <= 0) throw new Exception(" De Prijs moet groter dan 0 zijn.");
            PrijsPerStuk = prijsPerStuk;
            if (string.IsNullOrWhiteSpace(naam)) throw new Exception("De naam mag niet leeg zijn.");
            Naam = naam;
            MinimumHoeveelheid = minimumHoeveelheid;

        }
        public Drankspecificatie drankspecificatie { get; private set; }
        public double PrijsPerStuk { get; private set; }
        public String Naam { get; private set; }
        public Setgrootte MinimumHoeveelheid { get; private set; }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
 