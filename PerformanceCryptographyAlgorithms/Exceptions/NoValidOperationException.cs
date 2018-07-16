using System;

namespace PerformanceCryptographyAlgorithms.Exceptions
{
    public class NoValidOperationException : Exception
    {
        public NoValidOperationException(string message) : base(message)
        {
            
        }
    }
}
