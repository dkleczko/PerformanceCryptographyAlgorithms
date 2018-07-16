using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Hash
{
    public class Sha512Algorithm : HashExecution
    {
        public override byte[] Encrypt(byte[] bytesToEncrypt)
        {
            var sha512 = new SHA512CryptoServiceProvider();
            return sha512.ComputeHash(bytesToEncrypt);
        }
    }
}
