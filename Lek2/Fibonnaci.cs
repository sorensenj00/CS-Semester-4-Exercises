using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek2
{
    public class Fibonnaci
    {
        private int sluttal;
        public Fibonnaci(int sluttal)
        {
            this.sluttal = sluttal;
        }

        public void printFibonnaci()
        {
            int a = 0;
            int b = 1;
            Console.Write(a + " " + b + " ");
            int c = a + b;
            int count = 0;
            while (count == sluttal-2)
            {
                Console.Write(c + " ");
                a = b;
                b = c;
                c = a + b;
                count++; 
            }
        }

    }

}
