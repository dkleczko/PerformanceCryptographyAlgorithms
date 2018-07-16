using PerformanceCryptographyAlgorithms.Implementation.Measure;
using System.Collections.Generic;
using PerformanceCryptographyAlgorithms.Helpers;
using PerformanceCryptographyAlgorithms.Model.Measure;

namespace PerformanceCryptographyAlgorithms.Static
{
    public static class Aggregator
    {
        public static MemoryMeasureAggregator MeasureAggregator = new MemoryMeasureAggregator();

        public static void GenerateCsv(string fileName)
        {
            var csvMeasure = new List<CsvMeasure>();
            foreach (var key in MeasureAggregator.GetKeys())
            {
                var max = MeasureAggregator.Max(key);
                var min = MeasureAggregator.Min(key);
                var average = MeasureAggregator.Average(key);
                var median = MeasureAggregator.Median(key);
                var standardDeviation = MeasureAggregator.StandardDeviation(key);
                csvMeasure.Add(new CsvMeasure()
                {
                    Name = max.Name,
                    Max = max.Value,
                    Average = average.Value,
                    Min = min.Value,
                    StandardDeviation = standardDeviation.Value,
                    Median = median.Value
                });

            }
            CsvExport<CsvMeasure> csvExport = new CsvExport<CsvMeasure>(csvMeasure);
            csvExport.ExportToFile(string.Format("{0}.csv", fileName));

        }
    }
}
