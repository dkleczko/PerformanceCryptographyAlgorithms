using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric;
using PerformanceCryptographyAlgorithms.Static;
using PerformanceCryptographyAlgorithms.Helpers;
using System.IO;

namespace PerformanceCryptographyAlgorithms.Implementation.Performance
{
    public class AsymetricPerformance : IPerformance
    {
        private readonly AsymetricExecution _execution;

        public AsymetricPerformance(AsymetricExecution execution)
        {
            _execution = execution;
        }
        public void PerformanceTest()
        {
            _execution.WarmUp(WarmUpValue.Value);
            Test25BitFile(Files.File25Bit);
            Test50BitFile(Files.File50Bit);
            Test75BitFile(Files.File75Bit);
            Test100BitFile(Files.File100Bit);
            Test150BitFile(Files.File150Bit);
            Test200BitFile(Files.File200Bit);
            Test245BitFile(Files.File245Bit);
        }

        private void Test25BitFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt25Bit(bytes);
            var decrypted = _execution.Decrypt25Bit(data);
        }

        private void Test50BitFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt50Bit(bytes);
            var decrypted = _execution.Decrypt50Bit(data);
        }
        private void Test75BitFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt75Bit(bytes);
            var decrypted = _execution.Decrypt75Bit(data);
        }

        private void Test100BitFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt100Bit(bytes);
            var decrypted = _execution.Decrypt100Bit(data);
        }

        private void Test150BitFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt150Bit(bytes);
            var decrypted = _execution.Decrypt150Bit(data);
        }

        private void Test200BitFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt200Bit(bytes);
            var decrypted = _execution.Decrypt200Bit(data);
        }

        private void Test245BitFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt245Bit(bytes);
            var decrypted = _execution.Decrypt245Bit(data);
        }
    }
}
