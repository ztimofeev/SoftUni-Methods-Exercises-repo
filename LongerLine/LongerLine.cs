namespace LongerLine
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var firstLineLenght = LineLen(x1, x2, y2, y2);
            var secondLineLenght = LineLen(x3, x4, y3, y4);

            if (firstLineLenght >= secondLineLenght)
            {
                PrintPoints(x1, y1, x2, y2);
            }
            else
            {
                PrintPoints(x3, y3, x4, y4);
            }
        }

        public static double LineLen(double a1, double a2, double b1, double b2)
        {
            var x = Math.Abs(a1 - a2);
            var y = Math.Abs(b1 - b2);
            return Math.Sqrt(x * x + y * y);
        }

        public static void PrintPoints(double x1, double y1, double x2, double y2)
        {
            var firstDistToCenter = Math.Sqrt(x1 * x1 + y1 * y1);
            var secondDistToCenter = Math.Sqrt(x2 * x2 + y2 * y2);

            if (firstDistToCenter <= secondDistToCenter)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
        }
    }
}
