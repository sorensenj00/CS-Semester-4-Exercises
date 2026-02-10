using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3
{
    internal class Værkfører : Mekaniker
    {
        public int værkførerÅr { get; set; }
        public int tillæg { get; set; }
        public Værkfører(string navn, Adresse adresse, int svendePrøveÅr, int timeløn, int værkførerÅr, int tillæg) : base(navn, adresse, svendePrøveÅr, timeløn)
        {
            this.værkførerÅr = værkførerÅr;
            this.tillæg = tillæg;
        }

        public override double ugeLøn()
        {
            return base.ugeLøn() + (værkførerÅr * tillæg);
        }
    }
}

