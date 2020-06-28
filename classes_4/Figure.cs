using System;
namespace classes_4
{
    public class Figure
    {
        Point[] points;
        string type;

        public Figure(Point A, Point B, Point C)
        {
            points = new Point[3];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            type = "Triangle";
        }

        public Figure(Point A, Point B, Point C, Point D)
        { 
            points = new Point[4];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            points[3] = D;
            type = "Square";
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        { 
            points = new Point[5];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            points[3] = D;
            points[4] = E;
            type = "Pentagon";
        }

        public double LengthSide (Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        public void PerimeterCalculator ()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            Console.WriteLine($"{type} perimeter equals {perimeter:f3}");
        }
    }
}
