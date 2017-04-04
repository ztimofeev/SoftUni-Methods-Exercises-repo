namespace NumberInReversedOrder
{
    using System;

    public class ReversedNumber
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());

            var result = ReversingNumber(number);

            Console.WriteLine(result);
        }

        public static double ReversingNumber(double num)
        {
            var numString = num.ToString();
            string reversedString = String.Empty;

            for (int i = numString.Length - 1; i >= 0; i--)
            {
                reversedString += numString[i];
            }

            var reversedNum = double.Parse(reversedString);
            return reversedNum;
        }
    }
}

