using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChainsKata
{
    class NumberChains
    {
        public string GetNumberChain(int currentNumber)
        {
            string result = $"Original number was {currentNumber}";
            List<int> chainContents = new List<int>();
            int ascending;
            int descending;

            do
            {
                chainContents.Add(currentNumber);
                descending = DigitsDescending(currentNumber);
                ascending = DigitsAscending(currentNumber);
                currentNumber = descending - ascending;
                result += $"\n{descending} - {ascending} = {currentNumber}";
            }
            while (!chainContents.Contains(currentNumber));

            result += $"\nChain length {chainContents.Count}";

            return result;
        }

        private int DigitsAscending(int numberToSort)
        {
            return SortDigits(numberToSort);
        }

        private int DigitsDescending(int numberToSort)
        {
            return SortDigits(numberToSort, true);
        }

        private int SortDigits(int numberToSort, bool reverse = false)
        {
            int[] digits = SplitIntIntoArray(numberToSort);
            Array.Sort(digits);
            if (reverse)
            {
                Array.Reverse(digits);
            }
            return CombineArrayIntoInt(digits);
        }

        private static int[] SplitIntIntoArray(int input)
        {
            int digits = input.ToString().Length;
            int[] intArray = new int[digits];
            for (int count = digits - 1; count >= 0; count--)
            {
                intArray[count] = input % 10;
                input /= 10;
            }
            return intArray;
        }

        private static int CombineArrayIntoInt(int[] digitArray)
        {
            int result = 0;
            foreach(int digit in digitArray)
            {
                result *= 10;
                result += digit;
            }
            return result;
        }
    }
}
