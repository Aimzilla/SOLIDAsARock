
namespace SOLIDAsARock
{
    //Part of the wrong way:

    //public class Shape
    //{
    //}




    //the correct way to implement open/closed principle:
    public abstract class Shape
    {
        public abstract double Area();
    }
}