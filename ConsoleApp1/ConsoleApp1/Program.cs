using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Anagram anagram = new Anagram(input);
            Console.WriteLine(anagram.Generate());
            Console.ReadKey();
        }

    }
}
