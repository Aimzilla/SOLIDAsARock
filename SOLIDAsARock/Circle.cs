using System;

namespace SOLIDAsARock
{
    //Original/old/bad:
    //public class Circle
    //{
    //    public double Radius { get; set; }
    //}



    //New and improved!
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}