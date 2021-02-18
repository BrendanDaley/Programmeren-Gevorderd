using System;
using System.Collections.Generic;
using System.Text;

namespace DrankWinkel
{
    class Wijn : Drank
    {
        public Wijn(double prijsPerStuk, String naam, Wijnspecificatie wijnspec, Setgrootte minimumHoeveelheid) 
            : base(prijsPerStuk, naam, minimumHoeveelheid, Drankspecificatie)
        { 
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
