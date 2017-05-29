namespace MultiplayEvensByOdds
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var sumEven = SumDigits(number, 0);
            var sumOdds = SumDigits(number, 1);
            var result = Math.Abs(sumEven * sumOdds);
            Console.WriteLine(result);
        }

        public static int SumDigits(int number, int i)
        {
            var sum = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == i)
                {
                    sum += digit;
                }
            }

            return sum;
        }
    }
}
