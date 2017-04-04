namespace CenterPoint
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var firstDistance = DistanceToCenter(x1, y1);
            var secondDistance = DistanceToCenter(x2, y2);

            if (firstDistance <= secondDistance)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }

        public static double DistanceToCenter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
