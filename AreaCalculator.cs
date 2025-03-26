using ConsoleApprectangle;
using System.Drawing;

public class AreaCalculator
{
    public double TotalArea(object[] arrObjects)
    {
        double area = 0;
        Rectangle objRectangle;
        Circle objCircle;
        Triangle objTriangle;
        foreach (var obj in arrObjects)
        {
            if (obj is Rectangle)
            {
                objRectangle = (Rectangle)obj;
                area += objRectangle.Height * objRectangle.Width;
            }
            if (obj is Circle)
            {
                objCircle = (Circle)obj;
                area += objCircle.Radius * objCircle.Radius * Math.PI;
            }

            if (obj is Triangle)
            {
                objTriangle = (Triangle)obj;
                area += objTriangle.Height * objTriangle.Length / 2;
                ;
            }
        }

        return area;
    }
}
