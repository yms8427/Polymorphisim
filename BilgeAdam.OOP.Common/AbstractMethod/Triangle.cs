namespace BilgeAdam.OOP.Common
{
    public class Triangle : Shape
    {
        public Triangle(double baseEdge, double edge2, double edge3, double heigth)
        {
            BaseEdge = baseEdge;
            Edge2 = edge2;
            Edge3 = edge3;
            Heigth = heigth;
        }

        public double BaseEdge { get; }
        public double Edge2 { get; }
        public double Edge3 { get; }
        public double Heigth { get; }

        public override double GetArea()
        {
            return BaseEdge * Heigth / 2;
        }

        public override double GetPerimeter()
        {
            return BaseEdge + Edge2 + Edge3;
        }
    }
}
