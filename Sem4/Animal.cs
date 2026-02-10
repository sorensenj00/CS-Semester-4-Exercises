using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem4
{
    public class Animal : IAnimal
    {
        public string specie { get; set; }
        public Animal(String specie)
        {
            this.specie = specie;
        }
        public bool isDog()
        {
            if (this.specie.ToLower() == "dog")
            {
                return true;
            }
            else return false; 
        }

        public override string ToString()
        {
            return this.specie;
        }
    }
}
