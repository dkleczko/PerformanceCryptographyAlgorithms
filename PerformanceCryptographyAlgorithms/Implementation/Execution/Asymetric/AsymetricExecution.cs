using System;
using System.Text;
using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Implementation.Proxy;
using PerformanceCryptographyAlgorithms.Implementation.Attribute;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric
{
    public abstract class AsymetricExecution : PerformanceByRefObject, IAsymetricExectuion
    {
        public void WarmUp(string data)
        {
            var code = Encrypt(Encoding.ASCII.GetBytes(data));
            var decrypt = Decrypt(code);
            var dectryptReturn = Encoding.ASCII.GetString(decrypt);
        }

        public abstract byte[] Encrypt(byte[] bytesToEncrypt);

        public abstract byte[] Decrypt(byte[] bytesToDecrypt);

        [Performance("Encrypt 117Bit")]
        public byte[] Encrypt117Bit(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Decrypt 117Bit")]
        public byte[] Decrypt117Bit(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }
        [Performance("Encrypt 25Bit")]
        public byte[] Encrypt25Bit(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Decrypt 25Bit")]
        public byte[] Decrypt25Bit(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Encrypt 50Bit")]
        public byte[] Encrypt50Bit(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Decrypt 50Bit")]
        public byte[] Decrypt50Bit(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Encrypt 75Bit")]
        public byte[] Encrypt75Bit(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Decrypt 75Bit")]
        public byte[] Decrypt75Bit(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Encrypt 100Bit")]
        public byte[] Encrypt100Bit(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Decrypt 100Bit")]
        public byte[] Decrypt100Bit(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Encrypt 150Bit")]
        public byte[] Encrypt150Bit(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Decrypt 150Bit")]
        public byte[] Decrypt150Bit(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Encrypt 200Bit")]
        public byte[] Encrypt200Bit(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Decrypt 200Bit")]
        public byte[] Decrypt200Bit(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Encrypt 245Bit")]
        public byte[] Encrypt245Bit(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Decrypt 245Bit")]
        public byte[] Decrypt245Bit(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }
    }
}
