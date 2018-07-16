using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceCryptographyAlgorithms.Helpers
{
    public static class DoubleListExtended
    {
        public static double Median(this List<double> list)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentException("Median of empty array not defined.");

           var sortedPNumbers = (double[])list.ToArray().Clone();
            Array.Sort(sortedPNumbers);

            var size = sortedPNumbers.Length;
            var mid = size / 2;
            var median = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
            return median;
        }

        public static double StandardDeviation(this List<double> list)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentException("Standard Deviation of empty array not defined.");

            var average = list.Average();
            var sumOfSquaresOfDifferences = list.Select(val => (val - average) * (val - average)).Sum();
            var sd = Math.Sqrt(sumOfSquaresOfDifferences / list.Count);

            return sd;
        }
    }
}
