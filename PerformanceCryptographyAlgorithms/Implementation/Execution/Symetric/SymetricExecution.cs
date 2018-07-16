using System;
using System.Text;
using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Implementation.Attribute;
using PerformanceCryptographyAlgorithms.Implementation.Proxy;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Symetric
{
    public abstract class SymetricExecution : PerformanceByRefObject, ISymetricExecution
    {
        public abstract byte[] Encrypt(byte[] bytesToEncrypt);
        public abstract byte[] Decrypt(byte[] bytesToDecrypt);

        public void WarmUp(string data)
        {
            var code =Encrypt(Encoding.ASCII.GetBytes(data));
            var decrypt =  Decrypt(code);
            var result = Encoding.ASCII.GetString(decrypt);
        }
        [Performance("Encrypt 1MB")]
        public byte[] Encrypt1(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Encrypt 2MB")]
        public byte[] Encrypt2(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Encrypt 4MB")]
        public byte[] Encrypt4(byte[] inputData)
        {
            return Encrypt(inputData);
        }

        [Performance("Encrypt 8MB")]
        public byte[] Encrypt8(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Encrypt 16MB")]
        public byte[] Encrypt16(byte[] inputData)
        {
            return Encrypt(inputData);
        }

        [Performance("Encrypt 32MB")]
        public byte[] Encrypt32(byte[] inputData)
        {
            return Encrypt(inputData);
        }

        [Performance("Encrypt 64MB")]
        public byte[] Encrypt64(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Encrypt 128MB")]
        public byte[] Encrypt128(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Encrypt 256MB")]
        public byte[] Encrypt256(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Encrypt 512MB")]
        public byte[] Encrypt512(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Decrypt 1MB")]
        public byte[] Decrypt1(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }
        [Performance("Decrypt 2MB")]
        public byte[] Decrypt2(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }
        [Performance("Decrypt 4MB")]
        public byte[] Decrypt4(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }
        [Performance("Decrypt 8MB")]
        public byte[] Decrypt8(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Decrypt 16MB")]
        public byte[] Decrypt16(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Decrypt 32MB")]
        public byte[] Decrypt32(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }
        [Performance("Decrypt 64MB")]
        public byte[] Decrypt64(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Decrypt 128MB")]
        public byte[] Decrypt128(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }

        [Performance("Decrypt 256MB")]
        public byte[] Decrypt256(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }
        [Performance("Decrypt 512MB")]
        public byte[] Decrypt512(byte[] encryptedData)
        {
            return Decrypt(encryptedData);
        }


    }
}
