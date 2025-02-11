using System.Numerics;
using System.Runtime.CompilerServices;

namespace Lab9
{
    class Circle : Point
    {
        public double radius;
        double square;
        public Circle(double figureXPoint, double figureYPoint, double radius) : base(figureXPoint, figureYPoint)
        {
            this.figureXPoint = figureXPoint;
            this.figureYPoint = figureYPoint;
            this.radius = radius;
            square = Math.Pow(radius,2) * Math.PI;
        }
        public double Square()
        {
            return square;
        }
        public bool checkIfCross(Circle anotherCircle)
        {
            return (anotherCircle.radius + radius) > FindDifference(anotherCircle);
        }
        public static bool operator >(Circle CircleA, Circle CircleB)
        {
            return CircleA.Square() > CircleB.Square();
        }
        public static bool operator <(Circle CircleA, Circle CircleB)
        {
            return CircleA.Square() < CircleB.Square();
        }
    }
}