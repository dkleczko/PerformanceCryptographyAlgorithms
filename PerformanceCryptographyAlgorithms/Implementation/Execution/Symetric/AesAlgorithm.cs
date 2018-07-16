using System;
using System.IO;
using System.Security.Cryptography;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Symetric
{
    public class AesAlgorithm : SymetricExecution
    {
        private readonly Aes _aes;

        public AesAlgorithm()
        {
            _aes = Aes.Create();
        }
        public override byte[] Encrypt(byte[] bytesToEncrypt)
        {
            byte[] encrypted = null;
            if (bytesToEncrypt == null || bytesToEncrypt.Length == 0)
                throw new ArgumentException("BytesToEncrypt should have value");
            using (var aesAlg = Aes.Create())
            {
                if (aesAlg != null)
                {
                    aesAlg.Key = _aes.Key;
                    aesAlg.IV = _aes.IV;
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, aesAlg.CreateEncryptor(), 
                            CryptoStreamMode.Write))
                        {
                            csEncrypt.Write(bytesToEncrypt, 0, bytesToEncrypt.Length);
                            csEncrypt.Flush();
                        }
                        encrypted = msEncrypt.ToArray();

                    }

                }
            }
            return encrypted;
        }
        public override byte[] Decrypt(byte[] bytesToDecrypt)
        {
            byte[] plain;
            using (var mStream = new MemoryStream(bytesToDecrypt)) //add encrypted
            {
                using (var aesProvider = new AesCryptoServiceProvider())
                {
                    using (var cryptoStream = new CryptoStream(mStream,
                        aesProvider.CreateDecryptor(_aes.Key, _aes.IV), CryptoStreamMode.Read))
                    {
                        using (var stream = new StreamReader(cryptoStream))
                        {
                            var sf = stream.ReadToEnd();
                            plain = System.Text.Encoding.Default.GetBytes(sf);
                        }
                    }
                }
            }
            return plain;
        }
    }
}
