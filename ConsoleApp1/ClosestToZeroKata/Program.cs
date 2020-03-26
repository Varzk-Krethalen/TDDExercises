using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestToZeroKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int values");
            string inputString = Console.ReadLine();
            int[] inputValues = ParseIntArray(inputString);
            Console.WriteLine(ClosestToZero.Calculate(inputValues));
            Console.ReadKey();
        }

        static int[] ParseIntArray(string inputString)
        {
            int[] intArray = inputString.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            return intArray;
        }
    }
}
