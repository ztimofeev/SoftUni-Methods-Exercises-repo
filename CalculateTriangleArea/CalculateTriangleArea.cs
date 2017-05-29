namespace CalculateTriangleArea
{
    using System;
    
    public class CalculateTriangleArea
    {

        public static void Main()
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(triangleBase, triangleHeight);

            Console.WriteLine(area);
        }

        public static double GetTriangleArea(double triangleBase, double height)
        {
            return triangleBase * height / 2;
        }
    }
}
