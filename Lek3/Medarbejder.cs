using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3
{
    public abstract class Medarbejder : IharAdresse
    {
        public string navn { get; set; }
        public Adresse adresse { get; set; }

        public CprNr cpr { get; set; }

        private int timerPrUge = 37;

        public Medarbejder(CprNr cpr, string navn, Adresse adresse)
        {
            this.navn = navn;
            this.adresse = adresse;
            this.cpr = cpr;
        }

        public Medarbejder(string navn, Adresse adresse)
        {
            this.navn = navn;
            this.adresse = adresse;
            this.cpr = null;
        }

        public abstract double ugeLøn();

        public int TimerPrUge
        {
            get { return timerPrUge; }
            set { timerPrUge = value; }
        }

        public override string ToString()
        {
            if (cpr != null)
            {
                return $"Navn: {navn}, Adresse: {adresse}, CPR: {cpr}";
            }
            else return $"Navn: {navn}, Adresse: {adresse}, CPR: Ikke oplyst";
        }
    }
}
