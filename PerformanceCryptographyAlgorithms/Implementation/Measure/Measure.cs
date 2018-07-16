using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PerformanceCryptographyAlgorithms.Implementation.Measure
{
    public class Measure : IDisposable
    {
        public Stopwatch Watch { get; set; }
        public string Name { get; set; }

        public Measure([CallerMemberName] string name = null)
        {
            Name = name;
            Watch = new Stopwatch();
            Watch.Start();
        }

        public void Dispose()
        {
            Watch.Stop();
            OnMeasure(GetTime());
        }

        public double GetTime()
        {
            return 1000.0d * Watch.ElapsedTicks / Stopwatch.Frequency;
        }

        public virtual void OnMeasure(double ms)
        {
            Debug.WriteLine("{0}: {1:F4}", Name, ms);
        }
    }
}
