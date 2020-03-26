namespace ClosestToZeroKata
{
    public static class ClosestToZeroV2
    {
        public static int Calculate(int[] values)
        {
            int minPos = int.MaxValue;
            int minNeg = -int.MaxValue;
            foreach (int value in values)
            {
                minPos = (value < minPos && value > 0) ? value : minPos;
                minNeg = (value > minNeg && value < 0) ? value : minNeg;
            }
            return ((minPos < -minNeg) || (minPos == -minNeg)) ? minPos : minNeg;
        }
    }
}
