namespace EngNameOfLastDigit
{
    using System;

    public class EngNameOfLastDigit
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());

            var lastDigit = (int)Math.Abs(number % 10);
            string result = NumberToWord(lastDigit);

            Console.WriteLine(result);
        }

        public static string NumberToWord(int number)
        {
            var numbersWords = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            return numbersWords[number];
        }
    }
}
