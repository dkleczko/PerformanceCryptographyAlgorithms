using System.Linq;
using System.Runtime.Remoting.Messaging;
using PerformanceCryptographyAlgorithms.Implementation.Attribute;
using PerformanceCryptographyAlgorithms.Implementation.Measure;

namespace PerformanceCryptographyAlgorithms.Implementation.Factory
{
    public class MeasureFactory
    {
        public static Measure.Measure CreateInstance(IMethodMessage contextMessage, MemoryMeasureAggregator aggregator = null, string className = null)
        {
            var attrs = GetPerformanceAtribute(contextMessage);
            var name = GetName(contextMessage, className);
            if(attrs != null && aggregator != null)
                return new MemoryGroupMeasure(aggregator, name);
            if(attrs != null)
                return new ConsoleMeasure(name);

            return new Measure.Measure(name);
        }

        public static string GetName(IMethodMessage contextMessage, string className)
        {
            var attr = GetPerformanceAtribute(contextMessage);
            if (attr != null && !string.IsNullOrWhiteSpace(attr.Name))
            {
                return string.Format("{0} {1}",className, attr.Name);
            }
            return string.Format("{0} {1}", className, contextMessage.MethodName);
        }

        private static PerformanceAttribute GetPerformanceAtribute(IMethodMessage contextMessage)
        {
            return contextMessage.MethodBase.
                GetCustomAttributes(typeof(PerformanceAttribute), false).FirstOrDefault() as PerformanceAttribute;
        }
    }
}
