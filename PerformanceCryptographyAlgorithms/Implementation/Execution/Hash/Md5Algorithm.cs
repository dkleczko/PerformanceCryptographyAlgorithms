using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Hash
{
    public class Md5Algorithm : HashExecution
    {
        public override byte[] Encrypt(byte[] bytesToEncrypt)
        {
            using (var md5Hash = MD5.Create())
            {
                return md5Hash.ComputeHash(bytesToEncrypt);
            }
        }
    }
}
