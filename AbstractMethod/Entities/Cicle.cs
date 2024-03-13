using AbstractMethod.Entities.Enums;

namespace AbstractMethod.Entities
{
    internal class Cicle : Shape
    {
        public double Radius { get; set; }

        public Cicle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
