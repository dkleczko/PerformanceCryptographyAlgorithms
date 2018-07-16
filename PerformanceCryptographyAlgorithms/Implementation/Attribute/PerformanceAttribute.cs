using System;

namespace PerformanceCryptographyAlgorithms.Implementation.Attribute
{
    [AttributeUsage(AttributeTargets.Method)]
    public class PerformanceAttribute : System.Attribute
    {
        public string Name { get; set; }
        public PerformanceAttribute(string name)
        {
            Name = name;
        }
    }
}
