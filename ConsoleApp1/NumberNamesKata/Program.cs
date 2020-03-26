using System;

namespace NumberNamesKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string inputString = Console.ReadLine();
            long input = long.Parse(inputString);
            Console.WriteLine(NumberNames.Generate(input));
            Console.ReadKey();
        }
    }
}
