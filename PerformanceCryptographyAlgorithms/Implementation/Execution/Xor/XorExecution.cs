using System;
using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Implementation.Attribute;
using PerformanceCryptographyAlgorithms.Implementation.Proxy;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Xor
{
    public abstract class XorExecution : PerformanceByRefObject, IXorExecution
    {

        public abstract void Encrypt(byte[] inputData, byte key);

        [Performance("Encrypt 8MB")]
        public void Encrypt8(byte[] inputData, byte key)
        {
            Encrypt(inputData, key);
        }
        [Performance("Encrypt 16MB")]
        public void Encrypt16(byte[] inputData, byte key)
        {
            Encrypt(inputData, key);
        }

        [Performance("Encrypt 32MB")]
        public void Encrypt32(byte[] inputData, byte key)
        {
            Encrypt(inputData, key);
        }

        [Performance("Encrypt 64MB")]
        public void Encrypt64(byte[] inputData, byte key)
        {
            Encrypt(inputData, key);
        }
        [Performance("Encrypt 128MB")]
        public void Encrypt128(byte[] inputData, byte key)
        {
            Encrypt(inputData, key);
        }
        [Performance("Encrypt 256MB")]
        public void Encrypt256(byte[] inputData, byte key)
        {
            Encrypt(inputData, key);
        }
        [Performance("Encrypt 512MB")]
        public void Encrypt512(byte[] inputData, byte key)
        {
            Encrypt(inputData, key);
        }
        
    }
}
