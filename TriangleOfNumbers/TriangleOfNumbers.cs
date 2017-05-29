namespace TriangleOfNumbers
{
    using System;

    public class TriangleOfNumbers
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                PrintColumnc(i);
            }

            for (int i = number - 1; i > 0; i--)
            {
                PrintColumnc(i);
            }
        }

        static void PrintColumnc(int col)
        {
            for (int i = 1; i <= col; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
