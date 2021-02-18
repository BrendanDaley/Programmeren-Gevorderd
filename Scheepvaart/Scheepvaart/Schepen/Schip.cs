using System;

namespace Scheepvaart.Schepen
{
    public abstract class Schip
    {
        public double Lengte { get; private set; }
        public double Breedte { get; private set; }
        public int Tonage { get; private set; }
        public String Naam { get; private set; }
        public Vloot Vloot { get; set; }


        public Schip(double lengte, double breedte, int tonage, String naam)
        {
            Lengte = lengte;
            Breedte = breedte;
            Tonage = tonage;
            Naam = naam;
        }






    }
}
