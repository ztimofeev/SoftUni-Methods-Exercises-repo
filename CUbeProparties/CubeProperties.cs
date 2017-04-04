namespace CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            var cubeSide = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine().ToLower();

            double result = 0;

            switch (parameter)
            {
                case "face":
                    result = CubeFaceDiagonal(cubeSide);
                    break;
                case "space":
                    result = CubeSpaceDiagonal(cubeSide);
                    break;
                case "volume":
                    result = CubeVolume(cubeSide);
                    break;
                case "area":
                    result = CubeArea(cubeSide);
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine("{0:f2}", result);
        }
        public static double CubeFaceDiagonal(double num)
        {
            return Math.Sqrt(2 * num * num);
        }

        public static double CubeSpaceDiagonal(double num)
        {
            var faceDiagonal = CubeFaceDiagonal(num);
            return Math.Sqrt(faceDiagonal * faceDiagonal + num * num);
        }

        public static double CubeVolume(double num)
        {
            return num * num * num;
        }

        public static double CubeArea(double num)
        {
            return 6 * num * num;
        }
    }
}
