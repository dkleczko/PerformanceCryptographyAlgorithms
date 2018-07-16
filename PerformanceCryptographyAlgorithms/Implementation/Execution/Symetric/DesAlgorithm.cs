using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Symetric
{
    public class DesAlgorithm : SymetricExecution
    {
        private readonly DES _des;

        public DesAlgorithm()
        {
            _des = DES.Create();
        }

        public override byte[] Encrypt(byte[] bytesToEncrypt)
        {
            if(bytesToEncrypt == null)
                throw new ArgumentException("Bytes To Encrypt shouldn't be null");
            byte[] encrypted = null;
            using (var tdsAlg = new DESCryptoServiceProvider())
            {
                tdsAlg.Key = _des.Key;
                tdsAlg.IV = _des.IV;
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, 
                        tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV), CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(bytesToEncrypt, 0, bytesToEncrypt.Length);
                        csEncrypt.FlushFinalBlock();
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
            return encrypted;
        }

        public override byte[] Decrypt(byte[] bytesToDecrypt)
        {
            byte[] plain = null;
            using (var mStream = new MemoryStream(bytesToDecrypt)) //add encrypted
            {
                using (var desProvider = new DESCryptoServiceProvider())
                {
                    desProvider.Key = _des.Key;
                    desProvider.IV = _des.IV;
                    using (var cryptoStream = new CryptoStream(mStream,
                        desProvider.CreateDecryptor(_des.Key, _des.IV), CryptoStreamMode.Read))
                    {
                        using (var stream = new StreamReader(cryptoStream))
                        {
                            var sf = stream.ReadToEnd();
                            plain = Encoding.Default.GetBytes(sf);
                        }
                    }
                }
            }
            return plain;
        }
    }
}
