using System;
using System.Runtime.CompilerServices;

namespace PerformanceCryptographyAlgorithms.Implementation.Measure
{
    public class ConsoleMeasure : Measure
    {
        public ConsoleMeasure([CallerMemberName] string name = null)
            : base(name)
        {
            
        }

        public override void OnMeasure(double ms)
        {
            Console.WriteLine("{0}: {1:F4}", Name, ms);
        }
    }
}
