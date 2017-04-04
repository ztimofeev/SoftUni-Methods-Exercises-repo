namespace HelloName
{
    using System;

    public class HelloName
    {
        public static void Main()
        {
            var name = Console.ReadLine();

            PrintHello(name);
        }

        public static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
