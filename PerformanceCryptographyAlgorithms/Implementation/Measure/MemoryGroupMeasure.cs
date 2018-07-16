using System.Runtime.CompilerServices;

namespace PerformanceCryptographyAlgorithms.Implementation.Measure
{
    public class MemoryGroupMeasure : Measure
    {
        public MemoryMeasureAggregator Aggregator { get; set; }

        public MemoryGroupMeasure(MemoryMeasureAggregator aggregator, [CallerMemberName]string name = null)
            : base(name)
        {
            Aggregator = aggregator;
        }

        public override void OnMeasure(double milliseconds)
        {
            Aggregator.Aggregate(Name, milliseconds);
        }
    }
}
