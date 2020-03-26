using System;

namespace LCDDigitsKata
{
    class Program
    {

        static void Main(string[] args)
        {
            LCDDigits digitDisplay = new LCDDigits();
            Random ran = new Random();
            while (!Console.KeyAvailable)
            {
                long input = NextLong(ran, 1000000000000000000, long.MaxValue);
                Console.WriteLine(digitDisplay.GetDigits(input));
                System.Threading.Thread.Sleep(125);
            }
            Console.ReadKey();
        }

        static long NextLong(Random random, long min, long max)
        {
            ulong uRange = (ulong)(max - min);
            ulong ulongRand;
            do
            {
                byte[] buf = new byte[8];
                random.NextBytes(buf);
                ulongRand = (ulong)BitConverter.ToInt64(buf, 0);
            } while (ulongRand > ulong.MaxValue - ((ulong.MaxValue % uRange) + 1) % uRange);
            return (long)(ulongRand % uRange) + min;
        }
    }
}
