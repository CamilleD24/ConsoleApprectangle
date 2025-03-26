using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApprectangle
{
    public class Triangle : Shape
    {
        public double Height { set; get; }
        public double Length { set; get; }
        public override double Area()
        {
            return Height * Length / 2;
        }

        public Triangle(double height, double length)
        {
            Height = height;
            Length = length;
        }
    }

     
}
