using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCDDigitsKata
{
    public class LCDDigits
    {
        private string threeSpaces = "   ";
        private string spaceScoreSpace = " _ ";
        private string pipeSpacePipe = "| |";
        private string spaceSpacePipe = "  |";
        private string spaceScorePipe = " _|";
        private string pipeScorePipe = "|_|";
        private string pipeScoreSpace = "|_ ";
        public string GetDigits(long input)
        {
            string output;
            if (input < 0)
                output = "";
            else
                output = StringDigitsFromInt(input);
            return output;
        }

        private string StringDigitsFromInt(long input)
        {
            long[] digitArray = SplitIntIntoArray(input);
            string upperString = GetLayerString(digitArray, GetDigitUpper);
            string middleString = GetLayerString(digitArray, GetDigitMiddle);
            string lowerString = GetLayerString(digitArray, GetDigitLower);
            return upperString + '\n' + middleString + '\n' + lowerString;
        }

        private static long[] SplitIntIntoArray(long input)
        {
            int digits = input.ToString().Length;
            long[] intArray = new long[digits];
            for (int count = digits - 1; count >= 0; count--)
            {
                intArray[count] = input % 10;
                input /= 10;
            }
            return intArray;
        }

        private string GetLayerString(long[] input, Func<long, string> digitFunc)
        {
            string layerString = "";
            for(int index = 0; index < input.Length; index++)
            {
                layerString += digitFunc(input[index]);
                layerString += GetSeparator(index, input.Length);
            }
            return layerString;
        }

        private string GetSeparator(int index, int digits)
        {
            return ((index + 1) < digits) ? threeSpaces: "";
        }

        private string GetDigitUpper(long input)
        {
            string digitUpper;
            switch (input)
            {
                case 1:
                    digitUpper = threeSpaces;
                    break;
                case 4:
                    digitUpper = threeSpaces;
                    break;
                default:
                    digitUpper = spaceScoreSpace;
                    break;
            }

            return digitUpper;
        }

        private string GetDigitMiddle(long input)
        {
            string digitMiddle;
            switch (input)
            {
                case 0:
                    digitMiddle = pipeSpacePipe;
                    break;
                case 2: case 3:
                    digitMiddle = spaceScorePipe;
                    break;
                case 5: case 6:
                    digitMiddle = pipeScoreSpace;
                    break;
                case 1: case 7:
                    digitMiddle = spaceSpacePipe;
                    break;
                default:
                    digitMiddle = pipeScorePipe;
                    break;
            }
            return digitMiddle;
        }

        private string GetDigitLower(long input)
        {
            string digitLower;
            switch (input)
            {
                case 2:
                    digitLower = pipeScoreSpace;
                    break;
                case 3: case 5:
                    digitLower = spaceScorePipe;
                    break;
                case 0: case 6: case 8:
                    digitLower = pipeScorePipe;
                    break;
                default:
                    digitLower = spaceSpacePipe;
                    break;
            }
            return digitLower;
        }
    }
}
