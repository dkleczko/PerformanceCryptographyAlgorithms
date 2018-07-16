using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Hash
{
    public class Sha1Algorithm : HashExecution
    {
        public override byte[] Encrypt(byte[] bytesToEncrypt)
        {
            var sha = new SHA1CryptoServiceProvider();
            return sha.ComputeHash(bytesToEncrypt);
        }
    }
}
