using System;
using System.IO;
using PerformanceCryptographyAlgorithms.Static;

namespace PerformanceCryptographyAlgorithms.Helpers
{
    public class DataToTestHelper
    {
        private const int OneMegabytetoBytes = 1048576;

        public static void Create()
        {
            CreateDirectory();
            CreateFile(Files.File117Bit, 117);
            CreateFile(Files.File1Mb, 1 * OneMegabytetoBytes);
            CreateFile(Files.File2Mb, 2 * OneMegabytetoBytes);
            CreateFile(Files.File4Mb, 4 * OneMegabytetoBytes);
            CreateFile(Files.File8Mb, 8 * OneMegabytetoBytes);
            CreateFile(Files.File16Mb, 16 * OneMegabytetoBytes);
            CreateFile(Files.File32Mb, 32 * OneMegabytetoBytes);
            CreateFile(Files.File64Mb, 64 * OneMegabytetoBytes);
            CreateFile(Files.File128Mb, 128 * OneMegabytetoBytes);
            CreateFile(Files.File256Mb, 256 * OneMegabytetoBytes);
            CreateFile(Files.File512Mb, 512 * OneMegabytetoBytes);
            CreateFile(Files.File25Bit, 23);
            CreateFile(Files.File50Bit, 47);
            CreateFile(Files.File75Bit, 77);
            CreateFile(Files.File100Bit, 100);
            CreateFile(Files.File150Bit, 150);
            CreateFile(Files.File200Bit, 200);
            CreateFile(Files.File245Bit, 245);
        }

        private static void CreateFile(string name, int bytes)
        {

            Console.WriteLine("Creating File {0} in progress...", name);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WorkingDirectory = Path.Combine(Directory.GetCurrentDirectory(), Folder.FilesFolder);
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = string.Format("/c fsutil file createnew {0} {1}", name, bytes);
            process.StartInfo = startInfo;
            process.Start();
        }


        private static void CreateDirectory()
        {
            Console.WriteLine("Creating directory in progress...");
            if (!Directory.Exists(Folder.FilesFolder))
            {
                Directory.CreateDirectory(Folder.FilesFolder);
            }
        }
    }
}
