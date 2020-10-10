using System;

namespace BilgeAdam.OOP.Common
{
    public class Square : Shape
    {
        public Square(double edgeLength)
        {
            EdgeLength = edgeLength;
        }

        public double EdgeLength { get; }

        public override double GetArea()
        {
            return Math.Pow(EdgeLength, 2);
        }

        public override double GetPerimeter()
        {
            return EdgeLength * 4;
        }
    }
}
