namespace PerformanceCryptographyAlgorithms.Abstract.Performance
{
    public interface IExecution
    {
        void WarmUp(string data);
        byte[] Encrypt(byte[] bytesToEncrypt);
        byte[] Decrypt(byte[] bytesToDecrypt);

    }
}
