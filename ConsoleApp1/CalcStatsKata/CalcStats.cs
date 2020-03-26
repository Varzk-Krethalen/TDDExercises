using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStatsKata
{
    public class CalcStats
    {
        long[] items;
        long elements = 0;
        long average = 0;
        long max;
        long min;
        long sum = 0;

        public string CalculateStatistics<T>(T[] input)
        {
            return CalculateStatistics(input.Select(item => Convert.ToInt64(item)).ToArray());
        }

        public string CalculateStatistics(long[] input)
        {
            items = input;
            GetStatistics();
            return GenerateOutput();
        }

            private void GetStatistics()
        {
            elements = items.Count();
            min = max = items[0];

            foreach(int item in items)
            {
                Iterate(item);
            }

            average = sum / elements;
        }

        private void Iterate(int item)
        {
            sum += item;
            max = (item > max) ? item : max;
            min = (item < min) ? item : min;
        }

        private string GenerateOutput()
        {
            string averageString = "Average Value: " + average;
            string elementsString = "Number of Elements: " + elements;
            string maxString = "Maximum Value: " + max;
            string minString = "Minimum Value: " + min;
            string sumString = "Sum of Elements: " + sum;
            return elementsString + ", " + averageString + ", " + maxString + ", " + minString + ", " + sumString;
        }
    }
}
