namespace PerformanceCryptographyAlgorithms.Implementation.Proxy
{
    public class Proxy
    {
        public static T Create<T>() where T : PerformanceByRefObject
        {
            return PerformanceProxy<T>.CreateInstance();
        }


    }
}
