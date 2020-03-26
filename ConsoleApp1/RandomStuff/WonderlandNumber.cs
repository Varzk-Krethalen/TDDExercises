using System.Linq;

namespace RandomStuff
{
    static class WonderlandNumber
    {
        public static int GetWonderlandNumber()
        {
            for (int i = 100000; i < (1000000 / 6); i++)
            {
                if (IsWonderlandNumber(i))
                {
                    return i;
                }
            }
            return 0;
        }

        static bool IsWonderlandNumber(int i)
        {
            if (ContainsOriginalDigits(i, i * 2) &&
                ContainsOriginalDigits(i, i * 3) &&
                ContainsOriginalDigits(i, i * 4) &&
                ContainsOriginalDigits(i, i * 5) &&
                ContainsOriginalDigits(i, i * 6))
            {
                return true;
            }
            return false;
        }

        static bool ContainsOriginalDigits(int i, int multiplied)
        {
            string multString = multiplied.ToString();
            foreach (char c in i.ToString())
            {
                if (!multString.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
