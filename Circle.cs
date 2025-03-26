using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApprectangle
{
    public class Circle: Shape
    {
        public double Radius { set; get; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }


        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
