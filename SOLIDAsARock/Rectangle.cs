
namespace SOLIDAsARock
{
    //The original/bad way:

    //public class Rectangle
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }
    //}



    //Open/closed principle:
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
}