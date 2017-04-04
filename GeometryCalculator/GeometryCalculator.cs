namespace GeometryCalculator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var figure = Console.ReadLine().ToLower();

            double area = 0;

            switch (figure)
            {
                case "triangle":
                    var side = double.Parse(Console.ReadLine());
                    var height = double.Parse(Console.ReadLine());
                    area = TriangleArea(side, height);
                    break;

                case "square":
                    side = double.Parse(Console.ReadLine());
                    area = SquareArea(side);
                    break;

                case "rectangle":
                    var sideA = double.Parse(Console.ReadLine());
                    var sideB = double.Parse(Console.ReadLine());
                    area = RectangleArea(sideA, sideB);
                    break;

                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    area = CircleArea(radius);
                    break;

                default:
                    area = 0;
                    break;
            }

            Console.WriteLine("{0:f2}", area);
        }

        public static double TriangleArea(double side, double height)
        {
            return side * height / 2;
        }

        public static double SquareArea(double a)
        {
            return a * a;
        }

        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        public static double CircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}
