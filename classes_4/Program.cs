using System;

namespace classes_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 0, "A");
            Point b = new Point(3, 3, "B");
            Point c = new Point(3, 0, "C");
            Point d = new Point(-2, 2, "D");
            Point e = new Point(-1, 1, "E");

            Figure abc = new Figure(a, b, c);
            Figure abcd = new Figure(a, b, c, d);
            Figure abcde = new Figure(a, b, c, d, e);

            abc.PerimeterCalculator();
            abcd.PerimeterCalculator();
            abcde.PerimeterCalculator();
        }
    }
}
