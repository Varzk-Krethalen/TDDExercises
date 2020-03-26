using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParenthesesKata
{
    class BalancedParentheses
    {
        Stack<char> lastOpened = new Stack<char>();

        public bool IsBalanced(string stringToTest)
        {
            foreach (char character in stringToTest)
            {
                if (UpdateBrackets(character) == false)
                {
                    return false;
                }
            }
            return lastOpened.Count == 0;
        }

        private bool UpdateBrackets(char bracket)
        {
            switch (bracket)
            {
                case '(':
                case '[':
                case '{':
                    return OpenBracket(bracket);
                case ')':
                case ']':
                case '}':
                    return CloseBracket(bracket);
                default:
                    return true;
            }
        }

        private bool OpenBracket(char bracket)
        {
            lastOpened.Push(bracket);
            return true;
        }

        private bool CloseBracket(char bracket)
        {
            return lastOpened.Count > 0 && lastOpened.Pop() == GetOpeningBracket(bracket);
        }

        private char GetOpeningBracket(char bracket)
        {
            switch (bracket)
            {
                case ')':
                    return '(';
                case ']':
                    return '[';
                default:
                    return '{';
            }
        }
    }
}
