namespace MathPower
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        public static double RaiseToPower(double num, int pow)
        {
            double result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }
    }
}
