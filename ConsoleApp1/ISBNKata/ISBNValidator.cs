using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ISBNKata
{
    class ISBNValidator
    {
        enum multiplier
        {
            One = 1,
            Three = 3
        }

        public bool Validate(string input, int type)
        {
            input = RemoveNonIntegerCharacters(input);
            if ((type == 10 || type == 13) && (input.Length == type))
            {
                return (type == 10) ? Validate10(input): Validate13(input);
            }
            return false;
        }

        private string RemoveNonIntegerCharacters(string input)
        {
            return string.Join(string.Empty, Regex.Matches(input, @"\d+").OfType<Match>().Select(m => m.Value));
        }

        public bool Validate13(string input)
        {
            string checksumString = input.Substring(0, input.Length - 1);
            return GetChecksumDigitFor13(checksumString) == input.LastOrDefault();
        }

        public bool Validate10(string input)
        {
            string checksumString = input.Substring(0, input.Length - 1);
            return GetChecksumDigitFor10(checksumString) == input.LastOrDefault();
        }

        private char GetChecksumDigitFor13(string input)
        {
            int result = 0;
            multiplier mult = multiplier.One;
            foreach (char digit in input)
            {
                result += (int)char.GetNumericValue(digit) * (int)mult;
                mult = (mult == multiplier.One) ? multiplier.Three : multiplier.One;
            }
            result = (10 - (result % 10));
            result = (result == 10) ? 0 : result;
            return result.ToString()[0];
        }

        private char GetChecksumDigitFor10(string input)
        {
            int result = 0;
            for (int index = 0; index < input.Count(); index++)
            {
                result += (int)char.GetNumericValue(input[index]) * (index + 1);
            }
            result = result % 11;
            result = (result == 10) ? 0 : result;
            return result.ToString()[0];
        }
    }
}
