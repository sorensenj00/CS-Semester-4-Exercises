using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3
{
    public class Firma : IharAdresse
    {
        public Adresse adresse { get; set; }
        public Firma(Adresse adresse) {
        this.adresse = adresse;
        }
    }
}
