using System.IO;
using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Helpers;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric;
using PerformanceCryptographyAlgorithms.Static;

namespace PerformanceCryptographyAlgorithms.Implementation.Performance.RsaKeyLength
{
    public class RsaStaticFilePerformance : IPerformance
    {
        private readonly AsymetricExecution _execution;

        public RsaStaticFilePerformance(AsymetricExecution execution)
        {
            _execution = execution;
        }
        public void PerformanceTest()
        {
            _execution.WarmUp(WarmUpValue.Value);
            Test117bit(Files.File117Bit);
        }
        private void Test117bit(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt117Bit(bytes);
            var encrypted = _execution.Decrypt117Bit(data);
        }
    }
}
