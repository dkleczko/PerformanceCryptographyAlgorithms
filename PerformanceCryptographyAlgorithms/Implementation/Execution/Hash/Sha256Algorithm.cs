using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Hash
{
    public class Sha256Algorithm : HashExecution
    {
        public override byte[] Encrypt(byte[] bytesToEncrypt)
        {
            var sha256 = SHA256.Create();
            return sha256.ComputeHash(bytesToEncrypt);
        }
    }
}
