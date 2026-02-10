using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3
{
    internal class Synsmand : Mekaniker
    {
        public int synIUge { get; set; }
        public Synsmand(string navn, Adresse adresse, int svendePrøveÅr, int timeløn, int synIUge) : base(navn, adresse, svendePrøveÅr, timeløn)
        {
            this.synIUge = synIUge;
        }

        public override double ugeLøn()
        {
            return base.ugeLøn() + (synIUge * 50);
        }
    }
}
