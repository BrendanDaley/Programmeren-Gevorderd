using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel
{
    public abstract class Drankspecificatie
    {
        public Drankspecificatie(double alcoholPercentage, String brouwerij, String herkomstLand, Volume? Volume)
        {
       
        }
 
        public double AlcoholPercentage { get; private set; }
        public String Brouwerij { get; private set; }
        public String HerkomstLand { get; private set; }


        public virtual bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {
            bool ok = true;
            if (spec.Brouwerij != null && spec.Brouwerij.Length > 0 && spec.Brouwerij.ToLower() != this.Brouwerij.ToLower()) ok = false;
            if (spec.volume != null && spec.volume != this.volume) ok = false;
            if (spec.AlcoholPercentage >= null && spec.AlcoholPercentage != this.AlcoholPercentage) ok = false;
            if (spec.HerkomstLand != null && spec.HerkomstLand != this.HerkomstLand) ok = false;
            return ok;
        }


        public override string ToString()
        {
            return base.ToString();
        }


    }
}
