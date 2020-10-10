using System;

namespace BilgeAdam.OOP.Common
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public override double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
