using System;

namespace classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4.5, 2.8);
            Console.WriteLine($"Rectangle area: {rectangle.Area}");
            Console.WriteLine($"Rectangle perimeter: {rectangle.Perimeter}");
        }
    }
}
