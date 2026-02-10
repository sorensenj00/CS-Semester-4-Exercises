using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3
{
    internal class Mekaniker : Medarbejder
    {
        public int svendePrøveÅr { get; set; }
        public int timeløn { get; set; }
        public Mekaniker(string navn, Adresse adresse, int svendePrøveÅr, int timeløn) : base(navn, adresse)
        {
            this.svendePrøveÅr = svendePrøveÅr;
            this.timeløn = timeløn;
        }

        public Mekaniker(string navn, Adresse adresse, CprNr cpr, int svendePrøveÅr, int timeløn) : base(cpr, navn, adresse)
        {
            this.svendePrøveÅr = 0;
            this.timeløn = 0;
        }

        public override double ugeLøn()
        {
            return TimerPrUge * timeløn;
        }
    }
}
