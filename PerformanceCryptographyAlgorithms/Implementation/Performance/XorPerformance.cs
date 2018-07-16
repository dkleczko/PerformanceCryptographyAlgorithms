using System.IO;
using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Helpers;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Xor;
using PerformanceCryptographyAlgorithms.Static;

namespace PerformanceCryptographyAlgorithms.Implementation.Performance
{
    public class XorPerformance : IPerformance
    {
        private readonly XorExecution _execution;

        public XorPerformance(XorExecution execution)
        {
            _execution = execution;
        }
        public void PerformanceTest()
        {
            _execution.Encrypt8(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File8Mb)), 117);
            _execution.Encrypt16(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File16Mb)), 117);
            _execution.Encrypt32(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File32Mb)), 117);
            _execution.Encrypt64(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File64Mb)), 117);
            _execution.Encrypt128(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File128Mb)), 117);
            _execution.Encrypt256(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File256Mb)), 117);
            _execution.Encrypt512(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File512Mb)), 117);
        }
    }
}
