using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel
{
    public class Inventaris
    {
        public Inventaris()
        {

        }

        private Dictionary<String, Drank> Drankjes = new Dictionary<string, Drank>();

        public void VoegDrankToe(double prijsPerStuk, String naam, Bierkleur kleur, String brouwerij, Volume volume, double alcoholPercentage, Setgrootte minimumHoeveelheid)
        {
            Drank drank = new Drank(prijsPerStuk, naam, kleur, brouwerij, volume, alcoholPercentage, minimumHoeveelheid);
            if (Drankjes.ContainsKey(naam)) Drankjes.Add(drank.Naam, drank);
        }


        public Drank SelecteerDrank(String naam)
        {
            if (Drankjes.ContainsKey(naam)) return Drankjes[naam];
            return null;
        }

        public List<Drank> ZoekDrank(Drankspecificatie drank)
        {
            List<Drank> GevondenDrankjes = new List<Drank>();
            foreach(Drank d in Drankjes.Values)
            {
               if(d.Drankspecificatie.VoldoetAanSpecificatie(drank)) GevondenDrankjes.Add(d);
            }
            return GevondenDrankjes;
        }


    }
}
