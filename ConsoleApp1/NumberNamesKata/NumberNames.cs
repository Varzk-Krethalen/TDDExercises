
namespace NumberNamesKata
{
    static class NumberNames
    {
        public static string[] Generate(long[] input)
        {
            string[] names = new string[input.Length];
            for (long index = 0; index < input.Length; index++)
            {
                names[index] = Generate(input[index]);
            }
            return names;
        }

        public static string Generate(long input)
        {
            string output;
            if (input < 11)
            {
                output = GetZeroToTen(input);
            }
            else if (input < 20)
            {
                output = GetElevenToNineteen(input);
            }
            else if (input < 100)
            {
                output = GetTwentyToNinetyNine(input);
            }
            else if (input < 1000)
            {
                output = GetOneHundredToNineHundredNinetyNine(input);
            }
            else if (input < 1000000)
            {
                output = GetOneThousandTo999999(input);
            }
            else
            {
                output = GetOneMillionAndUp(input);
            }
            
            return output;
        }

        private static string GetZeroToTen(long input)
        {
            string output;
            switch (input)
            {
                case 10:
                    output = "Ten";
                    break;
                case 9:
                    output = "Nine";
                    break;
                case 8:
                    output = "Eight";
                    break;
                case 7:
                    output = "Seven";
                    break;
                case 6:
                    output = "Six";
                    break;
                case 5:
                    output = "Five";
                    break;
                case 4:
                    output = "Four";
                    break;
                case 3:
                    output = "Three";
                    break;
                case 2:
                    output = "Two";
                    break;
                case 1:
                    output = "One";
                    break;
                default:
                    output = "Zero";
                    break;
            }
            return output;
        }

        private static string GetElevenToNineteen(long input)
        {
            string output;

            switch (input)
            {
                case 11:
                    output = "Eleven";
                    break;
                case 12:
                    output = "Twelve";
                    break;
                case 13:
                    output = "Thirteen";
                    break;
                case 15:
                    output = "Fifteen";
                    break;
                default:
                    input = input % 10;
                    output = GetZeroToTen(input).Replace("t", "") + "teen";
                    break;
            }
            return output;
        }

        private static string GetTwentyToNinetyNine(long input)
        {
            long tens = input / 10;
            long ones = input % 10;
            string output = "";

            switch (tens)
            {
                case 9:
                    output = "Ninety";
                    break;
                case 8:
                    output = "Eighty";
                    break;
                case 7:
                    output = "Seventy";
                    break;
                case 6:
                    output = "Sixty";
                    break;
                case 5:
                    output = "Fifty";
                    break;
                case 4:
                    output = "Forty";
                    break;
                case 3:
                    output = "Thirty";
                    break;
                case 2:
                    output = "Twenty";
                    break;
                case 1:
                    ones = 10;
                    break;
            }

            if (input < 20 && input > 10)
            {
                output = GetElevenToNineteen(input);
            }
            else if (ones != 0)
            {
                output += " " + GetZeroToTen(ones);
            }
            return output;
        }
        private static string GetOneHundredToNineHundredNinetyNine(long input)
        {
            long hundreds = input / 100;
            long tens = input % 100;
            string output = (hundreds == 0) ? "" :(GetZeroToTen(hundreds) + " Hundred");

            if (tens != 0 )
            {
                string space = (tens > 10) ? " " : "";
                string and = (hundreds == 0) ? "": " and";
                output += and + space + GetTwentyToNinetyNine(tens);
                output = (output[0].Equals(' ')) ? output.Substring(1) : output;
            }
            return output;
        }

        private static string GetOneThousandTo999999(long input)
        {
            long thousands = input / 1000;
            string output = (thousands == 0) ? "": GetOneHundredToNineHundredNinetyNine(thousands) + " Thousand";
            long hundreds = input % 1000;

            if (hundreds != 0)
            {
                string space = (hundreds > 10) ? " " : "";
                string and = ((hundreds / 100) == 0) ? " and" : ",";
                output += and + space + GetOneHundredToNineHundredNinetyNine(hundreds);
            }
            return output;
        }

        private static string GetOneMillionAndUp(long input)
        {
            long millions = input / 1000000;
            string output = (millions > 999999) ? output = GetOneMillionAndUp(millions) : GetOneThousandTo999999(millions);
            output += " Million";
            output = (output.StartsWith(" and")) ? output.Remove(0, 4) : output;
            long thousands = input % 1000000;
            output += (thousands != 0) ? ", " + GetOneThousandTo999999(thousands) : "";
            output = (output[0].Equals(',')) ? output.Substring(1) : output;
            output = (output[0].Equals(' ')) ? output.Substring(1) : output;
            return output;
        }
    }
}
