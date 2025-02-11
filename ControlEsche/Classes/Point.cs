namespace Lab9
{
    class Point
    {
        public double figureXPoint;
        public double figureYPoint;
        public Point(double figureXPoint, double figureYPoint)
        {
            this.figureXPoint = figureXPoint;
            this.figureYPoint = figureYPoint;
        }
        public double FindDifference(Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.figureXPoint - figureXPoint,2)+ Math.Pow(point2.figureYPoint - figureYPoint,2));
        }
    }
}