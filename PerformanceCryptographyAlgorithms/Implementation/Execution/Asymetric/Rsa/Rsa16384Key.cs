using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric.Rsa
{
    public class Rsa16384Key : RsaAlgorithm
    {
        public Rsa16384Key() : base(CreateRsa())
        {

        }
        private static RSA CreateRsa()
        {
            return new RSACryptoServiceProvider(16384);
        }
    }
}
