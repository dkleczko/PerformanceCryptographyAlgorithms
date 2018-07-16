using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using PerformanceCryptographyAlgorithms.Implementation.Attribute;
using PerformanceCryptographyAlgorithms.Implementation.Factory;
using PerformanceCryptographyAlgorithms.Implementation.Measure;
using PerformanceCryptographyAlgorithms.Static;

namespace PerformanceCryptographyAlgorithms.Implementation.Proxy
{
    public class PerformanceProxy<T> : RealProxy where T : PerformanceByRefObject
    {
        private readonly T _baseObject;
        private string Name;
        public static T CreateInstance()
        {
            var obj = new PerformanceProxy<T>();
            return (T) obj.GetTransparentProxy();
        }

        private PerformanceProxy()
            : base(typeof(T))
        {
            _baseObject = Activator.CreateInstance<T>();
            Name = _baseObject.GetType().Name;
        }

        public override IMessage Invoke(IMessage msg)
        {
            IMethodCallMessage methMessage = (IMethodCallMessage)msg;
            object returnedVal = null;
            Console.WriteLine("Starting {0} ....", MeasureFactory.GetName(methMessage, Name));
            for (var i = 0; i < 100; i++)
            {
                using (MeasureFactory.CreateInstance(methMessage, Aggregator.MeasureAggregator, Name))
                {
                    returnedVal = methMessage.MethodBase.Invoke(_baseObject, methMessage.Args);
                }
            }
            return new ReturnMessage(returnedVal, methMessage.Args, methMessage.ArgCount, methMessage.LogicalCallContext, methMessage);
        }
    }
}
