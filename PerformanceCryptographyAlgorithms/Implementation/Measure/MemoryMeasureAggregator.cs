using System.Collections.Generic;
using System.Linq;
using PerformanceCryptographyAlgorithms.Helpers;
using PerformanceCryptographyAlgorithms.Model.Measure;

namespace PerformanceCryptographyAlgorithms.Implementation.Measure
{
    public class MemoryMeasureAggregator
    {
        private CloneableDictionary<string, CloneableList<double>> Measures { get; set; }

        public MemoryMeasureAggregator()
        {
            Measures = new CloneableDictionary<string, CloneableList<double>>();
        }

        public MemoryMeasureAggregator(CloneableDictionary<string, CloneableList<double>> measures)
        {
            Measures = measures;
        }

        public void Aggregate(string name, double totalTime)
        {
            CloneableList<double> current = null;
            if (Measures.TryGetValue(name, out current))
            {
                current.Add(totalTime);
            }
            else
            {
                Measures.Add(name, new CloneableList<double>() { totalTime });
            }
        }

        public Measurement Average(string name)
        {
            CloneableList<double> current = null;
            if (Measures.TryGetValue(name, out current))
            {
                return new Measurement(name, current.Average());
            }
            return new Measurement(name, 0.0);

        }

        public Measurement Median(string name)
        {
            CloneableList<double> current = null;
            if (Measures.TryGetValue(name, out current))
            {
                return new Measurement(name, current.Median());
            }
            return new Measurement(name, 0.0d);
        }

        public Measurement Max(string name)
        {
            CloneableList<double> current = null;
            if (Measures.TryGetValue(name, out current))
            {
                return new Measurement(name, current.Max());
            }
            return new Measurement(name, 0.0d);
        }

        public Measurement Min(string name)
        {
            CloneableList<double> current = null;
            if (Measures.TryGetValue(name, out current))
            {
                return new Measurement(name, current.Min());
            }
            return  new Measurement(name, 0.0d);
        }

        public Measurement StandardDeviation(string name)
        {
            CloneableList<double> current = null;
            if (Measures.TryGetValue(name, out current))
            {
                return new Measurement(name, current.StandardDeviation());

            }
            return new Measurement(name, 0.0d);
        }

        public Measurement GetFirstAverage()
        {
            var measure = Measures.FirstOrDefault();
            if (!measure.Equals(default(KeyValuePair<string, CloneableList<double>>)))
            {
                return Average(measure.Key);
            }
            return null;
        }
        public IEnumerable<Measurement> Average()
        {
            return Measures.Select(a => new Measurement(a.Key, a.Value.Average()));
        }

        public List<string> GetKeys()
        {
            return Measures.Keys.ToList();
        }

        public CloneableDictionary<string, CloneableList<double>> GetNewMeasuresDictionary()
        {
            return Measures.Clone();
        }
    }
}
