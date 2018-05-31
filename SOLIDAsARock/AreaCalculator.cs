//------------------------------------------------------------------------------------------
// <copyright file="AreaCalculator.cs">
//     Copyright &copy; Amy Pennybacker. 2018.
//     All rights reserved. 
//     Don't even think about trying to steal this amazing demonstration!!  :)
// </copyright>
//-------------------------------------------------------------------------------------------

namespace SOLIDAsARock
{
    //The business asks for the area of a rectangle (original request):

    //public class AreaCalculator
    //{
    //    public double Area(Rectangle[] shapes)
    //    {
    //        double area = 0;
    //        foreach (var shape in shapes)
    //        {
    //            area += shape.Width * shape.Height;
    //        }
    //        return area;
    //    }
    //}


    //Business comes back and asks for area of circle, too...
    //Have to modify the class to make it work.
    //This code below does not follow the open/closed principle:

    //public class AreaCalculator
    //{
    //    public double Area(object[] shapes)
    //    {
    //        double area = 0;
    //        foreach (var shape in shapes)
    //        {
    //            if (shape is Rectangle)
    //            {
    //                Rectangle rectangle = (Rectangle)shape;
    //                area += rectangle.Width * rectangle.Height;
    //            }
    //            else
    //            {
    //                Circle circle = (Circle)shape;
    //                area += circle.Radius * circle.Radius * Math.PI;
    //            }
    //        }
    //        return area;
    //    }
    //}




    //New and improved!
    //Follows the open/closed principle!
    //Look how nice and simple this is!
    public class AreaCalculator
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}