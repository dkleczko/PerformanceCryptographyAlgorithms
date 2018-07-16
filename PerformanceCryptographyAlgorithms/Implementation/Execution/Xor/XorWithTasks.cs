using System.Threading.Tasks;

namespace PerformanceCryptographyAlgorithms.Implementation.Execution.Xor
{
    public class XorWithTasks : XorAlgorithm
    {
        public override void Encrypt(byte[] inputData, byte key)
        {
            const int taskCount = 3;
            var tasks = new Task[taskCount];
            var elementsForThread = inputData.Length / taskCount;
            for (var i = 0; i < taskCount; i++)
            {
                var start = i * elementsForThread;
                int end;
                if (i == taskCount - 1)
                {
                    end = inputData.Length;
                }
                else
                {
                    end = (i + 1) * elementsForThread;
                }
                tasks[i] = new Task(() =>
                {
                    Algorithm(inputData, key, start, end);
                });
            }
            for (var i = 0; i < taskCount; i++)
            {
                tasks[i].Start();
            }
            Task.WaitAll(tasks);
        }
    }
}
