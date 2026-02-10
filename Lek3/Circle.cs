using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3
{
    public class Circle : Shape
    {
        private double radius; 

        public Circle(double radius, double x, double y) : base(x, y)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
