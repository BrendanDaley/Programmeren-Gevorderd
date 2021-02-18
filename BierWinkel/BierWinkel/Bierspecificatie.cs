using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel
{
    public class Bierspecificatie : Drankspecificatie
    {
        public Bierspecificatie(double alcoholPercentage, string brouwerij, string herkomstLand,Bierkleur? Bierkleur)
            : base(alcoholPercentage, brouwerij, herkomstLand)
        {
            Kleur = Bierkleur;
        }

        public Bierkleur? Kleur { get; private set;}




        public override string ToString()
        {
            return $"";
        }

        public override bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {
            if (!base.VoldoetAanSpecificatie(spec)) return false;
            if (spec.GetType() != typeof(Bierspecificatie)) return false;
            if (((Bierspecificatie)spec).Kleur != null && ((Bierspecificatie)spec).Kleur != this.Kleur) return false;
            return true;
        }



    }
}
