using BierWinkel;
using System;
using System.Collections.Generic;

namespace ConsoleAppBierWinkel
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Bier B1 = new Bier(1.05, "palm", Bierkleur.Amber, "palm", Biervolume.cl25, 5.2, Setgrootte.Zes);
            Bier B2 = new Bier(1.05, "palm", Bierkleur.Amber, "palm", Biervolume.cl25, 5.2, Setgrootte.Zes);
            Bier B3 = new Bier(1.05, "palm", Bierkleur.Amber, "palm", Biervolume.cl25, 5.2, Setgrootte.Zes);
            Bier B4 = new Bier(1.05, "palm", Bierkleur.Amber, "palm", Biervolume.cl25, 5.2, Setgrootte.Zes); */
            Inventaris inventaris = new Inventaris();
            inventaris.VoegBierToe(1.05, "Palm", Bierkleur.Amber, "Palm", Volume.cl25, 5.2, Setgrootte.Zes);
            inventaris.VoegBierToe(1.05, "Roden Back", Bierkleur.Bruin, "Palm", Volume.cl25, 5.2, Setgrootte.Zes);
            inventaris.VoegBierToe(1.05, "Leffe Bruin", Bierkleur.Bruin, "Leffe", Volume.cl33, 6.2, Setgrootte.Zes);
            inventaris.VoegBierToe(1.05, "Duvel", Bierkleur.Blond, "Duvel Moortgat", Volume.cl33, 8.5, Setgrootte.Vier);
            Bier x = inventaris.SelecteerBier("Palm");
            Console.WriteLine($"Bier: {x}");
            Bierspecificatie Bierspec = new Bierspecificatie(Bierkleur.Bruin, null, null, null);
            List<Bier> ly = inventaris.ZoekBier(Bierspec);
            foreach(Bier y in ly)
            {
                Console.WriteLine($"Bier: {y}");
            }


        }
    }
}
