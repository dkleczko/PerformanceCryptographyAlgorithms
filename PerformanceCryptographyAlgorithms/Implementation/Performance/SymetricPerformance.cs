using System.IO;
using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Helpers;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Symetric;
using PerformanceCryptographyAlgorithms.Static;

namespace PerformanceCryptographyAlgorithms.Implementation.Performance
{
    public class SymetricPerformance : IPerformance
    {
        private readonly SymetricExecution _execution;

        public SymetricPerformance(SymetricExecution symetricExecution)
        {
            _execution = symetricExecution;
        }

        public void PerformanceTest()
        {
            _execution.WarmUp(WarmUpValue.Value);
            Test1MbFile(Files.File1Mb);
            Test2MbFile(Files.File2Mb);
            Test4MbFile(Files.File4Mb);
            Test8MbFile(Files.File8Mb);
            Test16MbFile(Files.File16Mb);
            Test32MbFile(Files.File32Mb);
            Test64MbFile(Files.File64Mb);
            Test128MbFile(Files.File128Mb);

        }
        private void Test1MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt1(bytes);
            var decrypted = _execution.Decrypt1(data);
        }
        private void Test2MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt2(bytes);
            var decrypted = _execution.Decrypt2(data);
        }
        private void Test4MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt4(bytes);
            var decrypted = _execution.Decrypt4(data);
        }
        private void Test8MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt8(bytes);
            var decrypted = _execution.Decrypt8(data);
        }
        private void Test16MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt16(bytes);
            var decrypted = _execution.Decrypt16(data);
        }

        private void Test32MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt32(bytes);
            var decrypted = _execution.Decrypt32(data);
        }
        private void Test64MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt64(bytes);
            var decrypted = _execution.Decrypt64(data);
        }
        private void Test128MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt128(bytes);
            var decrypted = _execution.Decrypt128(data);
        }
        private void Test256MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt256(bytes);
            var decrypted = _execution.Decrypt256(data);
        }
        private void Test512MbFile(string fileName)
        {
            var bytes = FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, fileName));
            var data = _execution.Encrypt512(bytes);
            var decrypted = _execution.Decrypt512(data);
        }

    }
}
