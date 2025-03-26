using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApprectangle
{
    public class rRectangle: Shape
    {
        public double Width { set; get; }
        public double Height { set; get; }
        public override double Area()
        {
            return Width * Height;
        }


        public rRectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
