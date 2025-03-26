using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApprectangle
{
    public class Square : Shape
    {

        public double Side { set; get; }
        public override double Area()
        {
            return Side * Side;
        }
        public Square(double side) 
        {
            Side = side;
        }
    }
}
