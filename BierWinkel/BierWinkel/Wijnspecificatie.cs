using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel
{
    public class Wijnspecificatie : Drankspecificatie
    {
        public Wijnspecificatie(double alcoholPercentage, string brouwerij, string herkomstLand, WijnKleur? kleur) 
            : base(alcoholPercentage, brouwerij, herkomstLand)
        {
            Kleur = (WijnKleur)kleur;
        }
        public WijnKleur Kleur;

        public override bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {
            if (!base.VoldoetAanSpecificatie(spec)) return false;
            if (spec.GetType() != typeof(Wijnspecificatie)) return false;
            if (((Bierspecificatie)spec).Kleur != null && ((Wijnspecificatie)spec).Kleur != this.Kleur) return false;
            return true;
        }





    }
}
