namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Xor
{
    public abstract class XorAlgorithm : XorExecution
    {

        public void Algorithm(byte[] inputData, byte key, int? startIndex, int? endIndex)
        {
            if (!startIndex.HasValue)
                startIndex = 0;
            if (!endIndex.HasValue)
                endIndex = inputData.Length;

            for (var i = startIndex.Value; i < endIndex.Value; i++)
            {
                inputData[i] ^= key;
            }
        }

        public override void Encrypt(byte[] inputData, byte key)
        {
            Algorithm(inputData, key, null, null);
        }


    }
}
