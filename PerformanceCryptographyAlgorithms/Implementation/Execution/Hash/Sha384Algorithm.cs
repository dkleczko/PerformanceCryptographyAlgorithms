using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Hash
{
    public class Sha384Algorithm : HashExecution
    {
        public override byte[] Encrypt(byte[] bytesToEncrypt)
        {
            var sha384 = new SHA384CryptoServiceProvider();
            return sha384.ComputeHash(bytesToEncrypt);
        }
    }
}
