using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric.Rsa
{
    public class Rsa2048Key : RsaAlgorithm
    {
        public Rsa2048Key() : base(CreateRsa())
        {

        }

        private static RSA CreateRsa()
        {
            return new RSACryptoServiceProvider(2048);
        }
    }
}
