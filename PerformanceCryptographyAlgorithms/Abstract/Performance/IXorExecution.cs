namespace PerformanceCryptographyAlgorithms.Abstract.Performance
{
    public interface IXorExecution
    {
        void Encrypt(byte[] inputData, byte key);
    }
}
