using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWrapKata
{
    class WordWrapper
    {
        public string Wrap(string inputLine, int columnWidth)
        {
            if (InputIsValid(columnWidth, inputLine.Length))
            {
                return WrapIntoColumn(inputLine, columnWidth);
            }
            return "";
        }

        private bool InputIsValid(int columnWidth, int length)
        {
            return (columnWidth > 0);
        }

        private string WrapIntoColumn(string inputLine, int columnWidth)
        {
            string result = "";
            while (!inputLine.Equals(""))
            {
                MoveNextRowToResult(ref inputLine, columnWidth, ref result);
            }
            return result.TrimEnd('\n');
        }

        private void MoveNextRowToResult(ref string inputLine, int columnWidth, ref string result)
        {
            string substring = GetNextRow(inputLine, columnWidth);
            RemoveRowFromInput(ref inputLine, substring);
            result += substring;
        }

        private string GetNextRow(string inputLine, int columnWidth)
        {
            string substring = "";
            if (columnWidth <= inputLine.Length)
            {
                substring = inputLine.Substring(0, columnWidth);
                substring = substring.Contains(" ") ? GetRowForWords(substring) : substring;
                substring += '\n';
            }
            else
            {
                substring = inputLine.Substring(0);
            }
            return substring;
        }

        private string GetRowForWords(string substring)
        {
            int spaceIndex = substring.Length - 1;
            for (int index = substring.Length -1; index >= 0; index--)
            {
                if (substring[index] == ' ')
                {
                    spaceIndex = index;
                    break;
                }
            }
            int width = spaceIndex;
            return substring.Substring(0, width);
        }

        private void RemoveRowFromInput(ref string inputLine, string substring)
        {
            substring = substring.Replace("\n", "");
            inputLine = inputLine.Remove(inputLine.IndexOf(substring), substring.Length);
            inputLine = inputLine.TrimStart(' ');
        }
    }
}
