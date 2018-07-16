using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric.Rsa
{
    public class Rsa4096Key : RsaAlgorithm
    {
        public Rsa4096Key() : base(CreateRsa())
        {

        }

        private static RSA CreateRsa()
        {
            return new RSACryptoServiceProvider(4096);
        }
    }
}
