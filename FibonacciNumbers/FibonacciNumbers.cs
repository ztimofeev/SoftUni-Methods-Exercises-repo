namespace FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            var numFiboSeq = int.Parse(Console.ReadLine());

            var result = FiboSequence(numFiboSeq);
            Console.WriteLine(result);
        }

        public static int FiboSequence(int number)
        {
            var a = 1;
            var b = 1;

            if (number < 2)
            {
                return b;
            }
            for (int i = 0; i < number - 1; i++)
            {
                var fibo = a + b;
                a = b;
                b = fibo;
            }
            return b;
        }
    }
}
