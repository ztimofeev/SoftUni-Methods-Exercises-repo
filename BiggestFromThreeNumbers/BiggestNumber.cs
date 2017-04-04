namespace BiggestFromThreeNumbers
{
    using System;
    public class BiggestNumber
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());

            var tempBiggerNumber = BiggerTwoNumbers(firstNum, secondNum);
            var biggestNumber = BiggerTwoNumbers(tempBiggerNumber, thirdNum);

            Console.Write(biggestNumber);
        }

        public static int BiggerTwoNumbers(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }
    }
}
