using PerformanceCryptographyAlgorithms.Implementation.Execution;

namespace PerformanceCryptographyAlgorithms.Abstract.Performance
{
    public interface ISymetricExecution : IExecution
    {
        byte[] Encrypt1(byte[] inputData);
        byte[] Encrypt2(byte[] inputData);
        byte[] Encrypt4(byte[] inputData);
        byte[] Encrypt8(byte[] inputData);
        byte[] Encrypt16(byte[] inputData);
        byte[] Encrypt32(byte[] inputData);
        byte[] Encrypt64(byte[] inputData);
        byte[] Encrypt128(byte[] inputData);
        byte[] Encrypt256(byte[] inputData);
        byte[] Encrypt512(byte[] inputData);
        byte[] Decrypt1(byte[] inputData);
        byte[] Decrypt2(byte[] inputData);
        byte[] Decrypt4(byte[] inputData);
        byte[] Decrypt8(byte[] inputData);
        byte[] Decrypt16(byte[] encryptedData);
        byte[] Decrypt32(byte[] encryptedData);
        byte[] Decrypt64(byte[] encryptedData);
        byte[] Decrypt128(byte[] encryptedData);
        byte[] Decrypt256(byte[] encryptedData);
        byte[] Decrypt512(byte[] encryptedData);
    }
}
