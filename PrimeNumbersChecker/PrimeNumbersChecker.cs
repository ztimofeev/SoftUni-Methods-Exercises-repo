namespace PrimeNumbersChecker
{
    using System;

    public class PrimeNumbersChecker
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());

            bool result = IsPrimeChecker(number);
            Console.WriteLine(result);
        }

        public static bool IsPrimeChecker(long num)
        {
            bool isPrime = true;

            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
