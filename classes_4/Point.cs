using System;
namespace classes_4
{
    public class Point
    {
        readonly int x;
        readonly int y;
        readonly string pointName;

        public int X { get; }
        public int Y { get; }
        public string PointName { get; }

        public Point(int x, int y, string pointName)
        {
            X = x;
            Y = y;
            PointName = pointName;
        }
    }
}
