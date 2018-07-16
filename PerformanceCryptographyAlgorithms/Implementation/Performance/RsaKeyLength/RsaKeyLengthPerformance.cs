using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric.Rsa;

namespace PerformanceCryptographyAlgorithms.Implementation.Performance.RsaKeyLength
{
    public class RsaKeyLengthPerformance :IPerformance
    {
        public void PerformanceTest()
        {
            var rsa1024Key = new RsaStaticFilePerformance(Proxy.Proxy.Create<Rsa1024Key>());
            rsa1024Key.PerformanceTest();
            var rsa2048Key = new RsaStaticFilePerformance(Proxy.Proxy.Create<Rsa2048Key>());
            rsa2048Key.PerformanceTest();
            var rsa4096Key = new RsaStaticFilePerformance(Proxy.Proxy.Create<Rsa4096Key>());
            rsa4096Key.PerformanceTest();
            var rsa8192Key = new RsaStaticFilePerformance(Proxy.Proxy.Create<Rsa8192Key>());
            rsa8192Key.PerformanceTest();
            var rsa16384Key = new RsaStaticFilePerformance(Proxy.Proxy.Create<Rsa16384Key>());
            rsa16384Key.PerformanceTest();
        }
    }
}
