using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3
{
    public abstract class Shape
    {
        private double x, y; 

        public Shape(double x, double y) {
            this.y = y;
            this.x = x;
        }

        public Shape() : this(1, 1) { 
  
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public abstract double Area();
    }
}
