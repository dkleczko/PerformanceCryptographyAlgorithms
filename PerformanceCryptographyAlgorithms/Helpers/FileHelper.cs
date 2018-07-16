using System.IO;

namespace PerformanceCryptographyAlgorithms.Helpers
{
    public class FileHelper
    {
        public static byte[] GetFileBytes(string path)
        {
            return File.ReadAllBytes(path);
        }
    }
}
