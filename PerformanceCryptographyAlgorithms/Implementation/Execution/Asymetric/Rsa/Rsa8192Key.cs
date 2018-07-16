using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric.Rsa
{
    public class Rsa8192Key : RsaAlgorithm
    {
        public Rsa8192Key() : base(CreateRsa())
        {

        }
        private static RSA CreateRsa()
        {
            return new RSACryptoServiceProvider(8192);
        }
    }
}
