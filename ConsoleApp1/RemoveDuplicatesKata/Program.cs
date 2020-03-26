using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your list:");
            string[] input = Console.ReadLine().Split(',');
            for (int i = 0; i < input.Length; i++) { input[i] = input[i].Trim(); }
            input = RemoveDuplicates.Simplify(input);
            Console.WriteLine("Removing duplicates...");
            string output = "";
            foreach (string s in input) { output += s + ", "; }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
