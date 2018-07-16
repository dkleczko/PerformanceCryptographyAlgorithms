namespace PerformanceCryptographyAlgorithms.Model.Measure
{
    public class Measurement
    {
        public string Name { get; private set; }
        public double Value { get; private set; }

        public Measurement(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public static implicit operator double(Measurement m)
        {
            return m.Value;
        }
    }
}
