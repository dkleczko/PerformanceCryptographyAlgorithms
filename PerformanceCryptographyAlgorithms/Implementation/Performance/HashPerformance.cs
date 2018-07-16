using PerformanceCryptographyAlgorithms.Abstract.Performance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerformanceCryptographyAlgorithms.Helpers;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Hash;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Symetric;
using PerformanceCryptographyAlgorithms.Static;

namespace PerformanceCryptographyAlgorithms.Implementation.Performance
{
    public class HashPerformance : IPerformance
    {
        private readonly HashExecution _proxy;

        public HashPerformance(HashExecution execution)
        {
            _proxy = execution;
        }

        public void PerformanceTest()
        {
            _proxy.WarmUp(WarmUpValue.Value);
            _proxy.Encrypt1(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File1Mb)));
            _proxy.Encrypt2(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File2Mb)));
            _proxy.Encrypt4(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File4Mb)));
            _proxy.Encrypt8(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File8Mb)));
            _proxy.Encrypt16(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File16Mb)));
            _proxy.Encrypt32(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File32Mb)));
            _proxy.Encrypt64(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File64Mb)));
            _proxy.Encrypt128(FileHelper.GetFileBytes(Path.Combine(Folder.FilesFolder, Files.File128Mb)));
        }
    }
}
