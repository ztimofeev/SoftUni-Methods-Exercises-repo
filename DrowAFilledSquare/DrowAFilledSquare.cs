namespace DrowAFilledSquare
{
    using System;

    public class DrowAFilledSquare
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            PrintTopBottomLine(number);
            
            for (int i = 0; i < number - 2; i++)
            {
                PrintMiddleRows(number);
            }

            PrintTopBottomLine(number);
        }

        private static void PrintMiddleRows(int n)
        {
                Console.WriteLine("-" + MagicString("\\/", n - 1) + "-");
        }

        private static void PrintTopBottomLine(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        private static object MagicString(string txt, int num)
        {
            string output = "";
            for (int i = 0; i < num; i++)
            {
                output += txt;
            }

            return output;
        }
    }
}
