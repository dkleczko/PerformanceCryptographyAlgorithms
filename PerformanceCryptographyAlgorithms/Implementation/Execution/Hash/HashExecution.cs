using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Implementation.Attribute;
using PerformanceCryptographyAlgorithms.Implementation.Proxy;
using System;
using System.Text;
using PerformanceCryptographyAlgorithms.Exceptions;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Hash
{
    public abstract class HashExecution : PerformanceByRefObject, IHashExecution
    {
        public virtual byte[] Decrypt(byte[] bytesToDecrypt)
        {
            throw new NoValidOperationException("Operation is not valid for this algorithm");
        }

        public abstract byte[] Encrypt(byte[] bytesToEncrypt);

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

        [Performance("Encrypt 128MB")]
        public byte[] Encrypt128(byte[] inputData)
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
        [Performance("Encrypt 256MB")]
        public byte[] Encrypt256(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Encrypt 32MB")]
        public byte[] Encrypt32(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Encrypt 512MB")]
        public byte[] Encrypt512(byte[] inputData)
        {
            return Encrypt(inputData);
        }
        [Performance("Encrypt 64MB")]
        public byte[] Encrypt64(byte[] inputData)
        {
            return Encrypt(inputData);
        }

        public void WarmUp(string data)
        {
            Encrypt(Encoding.ASCII.GetBytes(data));
        }
    }
}
