namespace ClosestToZeroKata
{
    public static class ClosestToZero
    {
        public static int Calculate(int[] inputValues)
        {
            int result = 2147483647;

            for (int i = 0; i < inputValues.Length; i++)
            {
                if (NewValueIsCloserToZero(inputValues[i], result))
                {
                    result = inputValues[i];
                }
            }

            return result;
        }

        static int AbsoluteValue(int value)
        {
            if (value < 0)
            {
                value = -value;
            }
            return value;
        }

        static bool NewValueIsCloserToZero(int current, int previous)
        {
            return (AbsoluteIsSmaller(current, previous) 
                || AbsoluteIsTheSameAndCurrentIsPositive(current, previous));
        }

        static bool AbsoluteIsSmaller(int current, int previous)
        {
            return AbsoluteValue(current) < AbsoluteValue(previous);
        }

        static bool AbsoluteIsTheSameAndCurrentIsPositive(int current, int previous)
        {
            return (AbsoluteValue(current) == AbsoluteValue(previous) && current > 0);
        }
    }
}
