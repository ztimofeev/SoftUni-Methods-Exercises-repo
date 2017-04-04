namespace MasterNumber
{
    using System;

    public class MasterNumber
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            var numStr = num.ToString();

            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if (numStr[i] != numStr[numStr.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool SumOfDigits(int num)
        {
            var numStr = num.ToString();
            var sum = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                sum += (numStr[i] - '0');
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool ContainsEvenDigit(int num)
        {
            var numStr = num.ToString();

            for (int i = 0; i < numStr.Length - 1; i++)
            {
                if ((numStr[i] - '0') % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
