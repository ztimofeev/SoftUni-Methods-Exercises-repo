namespace PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            var startNumber = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());

            if (startNumber >= endNumber)
            {
                Console.WriteLine();
            }
            else
            {
                List<int> listOfPrime = new List<int>();

                for (int i = startNumber; i <= endNumber; i++)
                {
                    bool prime = IsPrimeChecker(i);
                    if (prime)
                    {
                        listOfPrime.Add(i);
                    }
                }

                int[] arrOfPrimes = listOfPrime.ToArray();
                var len = arrOfPrimes.Length;

                for (int i = 0; i < len - 1; i++)
                {
                    Console.Write("{0}, ", arrOfPrimes[i]);
                }
                Console.Write(arrOfPrimes[len - 1]);
            }
        }

        public static bool IsPrimeChecker(int num)
        {

            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
