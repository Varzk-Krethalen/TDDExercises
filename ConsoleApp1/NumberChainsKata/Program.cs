using System;

namespace NumberChainsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberChains chains = new NumberChains();
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(chains.GetNumberChain(input));
            Console.ReadKey();
        }
    }
}
