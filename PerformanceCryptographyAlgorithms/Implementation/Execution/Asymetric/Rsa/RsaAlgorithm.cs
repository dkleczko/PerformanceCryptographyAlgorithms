using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric.Rsa
{
    public class RsaAlgorithm : AsymetricExecution
    {
        private readonly RSA _rsa;

        public RsaAlgorithm()
        {
            _rsa = RSA.Create();
        }

        public RsaAlgorithm(RSA rsa)
        {
            _rsa = rsa;
        }

        public override byte[] Encrypt(byte[] bytesToEncrypt)
        {
            byte[] encryptedData;
            using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
            {
                provider.ImportParameters(_rsa.ExportParameters(false));
                encryptedData = provider.Encrypt(bytesToEncrypt, false);
            }
            return encryptedData;
        }

        public override byte[] Decrypt(byte[] bytesToDecrypt)
        {
            byte[] encryptedData = null;
            using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
            {
                provider.ImportParameters(_rsa.ExportParameters(true));
                encryptedData = provider.Decrypt(bytesToDecrypt, false);
            }
            return encryptedData;
        }
    }
}
