namespace PerformanceCryptographyAlgorithms.Abstract.Performance
{
    public interface IHashExecution : IExecution
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
    }
}
