using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3
{
    public class Rectangle : Shape
    {
        private double width, height;
        public Rectangle(double width, double height, double x, double y) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public override double Area()
        {
            return width * height;
        }
    }
}
