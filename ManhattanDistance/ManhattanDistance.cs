using System;

namespace ManhattanDistance
{
    public struct Point
    {
        public int X;
        public int Y;
        
        public Point(int x, int y)
            => (X, Y) = (x, y);
    }
    public class ManhattanDistance
    {
        private readonly Point _pointA;
        private readonly Point _pointB;

        public ManhattanDistance(Point pointA, Point pointB)
            => (_pointA , _pointB) = (pointA, pointB);

        public int Calculate()
            => Math.Abs(_pointA.X - _pointB.X) + Math.Abs(_pointA.Y - _pointB.Y);
    }
}