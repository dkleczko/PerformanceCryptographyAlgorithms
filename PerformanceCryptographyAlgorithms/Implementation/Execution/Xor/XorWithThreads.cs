using System.Threading;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Xor
{
    public class XorWithThreads : XorAlgorithm
    {
        public override void Encrypt(byte[] inputData, byte key)
        {
            const int threadsCount = 3;
            var threads = new Thread[threadsCount];
            var elementsForThread = inputData.Length / threadsCount;
            for (var i = 0; i < threadsCount; i++)
            {
                var start = i * elementsForThread;
                int end;
                if (i == threadsCount - 1)
                {
                    end = inputData.Length;
                }
                else
                {
                    end = (i + 1) * elementsForThread;
                }
                threads[i] = new Thread(() =>
                {
                    Algorithm(inputData, key, start, end);
                });
            }
            for (var i = 0; i < threadsCount; i++)
            {
                threads[i].Start();
            }
            for (var i = 0; i < threadsCount; i++)
            {
                threads[i].Join();
            }
        }
    }
}
