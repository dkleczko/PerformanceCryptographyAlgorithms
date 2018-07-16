using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric.Rsa
{
    public class Rsa1024Key : RsaAlgorithm
    {
        public Rsa1024Key() : base(CreateRsa())
        {
            
        }

        private static RSA CreateRsa()
        {
            return new RSACryptoServiceProvider(1024);
        }
    }
}
