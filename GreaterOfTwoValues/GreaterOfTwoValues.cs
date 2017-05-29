namespace GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            var valueType = Console.ReadLine().ToLower();

            if (valueType == "int")
            {
                var firstValue = int.Parse(Console.ReadLine());
                var secondValue = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(firstValue, secondValue));
            }
            else if (valueType == "char")
            {
                var firstChar = char.Parse(Console.ReadLine());
                var secondChar = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(firstChar, secondChar));
            }
            else if (valueType == "string")
            {
                var firstString = Console.ReadLine();
                var secondString = Console.ReadLine();

                Console.WriteLine(GetMax(firstString, secondString));
            }
        }

        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        public static char GetMax(char a, char b)
        {
            return (char)Math.Max((int)a, (int)b);
        }

        public static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) < 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
