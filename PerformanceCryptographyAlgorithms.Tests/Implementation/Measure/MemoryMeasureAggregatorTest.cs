using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PerformanceCryptographyAlgorithms.Helpers;
using PerformanceCryptographyAlgorithms.Implementation.Measure;
using PerformanceCryptographyAlgorithms.Model.Measure;

namespace PerformanceCryptographyAlgorithms.Tests.Implementation.Measure
{
    [TestFixture()]
    public class MemoryMeasureAggregatorTest
    {
        [Test]
        public void Average_With_No_Current_Key_And_No_Elements()
        {
            const string key = "TEST1";
            var measurementAggregator = new MemoryMeasureAggregator();

            var result = measurementAggregator.Average(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(key, result.Name);
            Assert.AreEqual(0.0, result.Value);
        }

        [Test]
        public void Average_With_No_Current_Key_And_Filled_Elements()
        {
            const string key = "TEST1";
            var measurementAggregator = new MemoryMeasureAggregator(new CloneableDictionary<string, CloneableList<double>>()
            {
                {"TEST2", new CloneableList<double>(){5.5} }
            });

            var result = measurementAggregator.Average(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(key, result.Name);
            Assert.AreEqual(0.0, result.Value);
        }

        [Test]
        public void Average_With_Existing_Current_Key()
        {
            const string key = "TEST1";
            var measurementAggregator = new MemoryMeasureAggregator(new CloneableDictionary<string, CloneableList<double>>()
            {
                {key, new CloneableList<double>(){5.5, 6, 10, 11 ,12} }
            });

            var result = measurementAggregator.Average(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(key, result.Name);
            Assert.AreEqual(8.9, result.Value);
        }

        [Test]
        public void Max_With_No_Current_Key_And_No_Elements()
        {
            const string key = "TEST1";
            var measurementAggregator = new MemoryMeasureAggregator();

            var result = measurementAggregator.Max(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(key, result.Name);
            Assert.AreEqual(0.0, result.Value);
        }

        [Test]
        public void Max_With_No_Current_Key_And_Filled_Elements()
        {
            const string key = "TEST1";
            var measurementAggregator = new MemoryMeasureAggregator(new CloneableDictionary<string, CloneableList<double>>()
            {
                {"TEST2", new CloneableList<double>(){5.5} }
            });

            var result = measurementAggregator.Max(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(key, result.Name);
            Assert.AreEqual(0.0, result.Value);
        }

        [Test]
        public void Max_With_Existing_Current_Key()
        {
            const string key = "TEST1";
            var measurementAggregator = new MemoryMeasureAggregator(new CloneableDictionary<string, CloneableList<double>>()
            {
                {key, new CloneableList<double>(){-2, -3, 13,  6, 10, 11 ,12} }
            });

            var result = measurementAggregator.Max(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(key, result.Name);
            Assert.AreEqual(13, result.Value);
        }

        [Test]
        public void Min_With_No_Current_Key_And_No_Elements()
        {
            const string key = "TEST1";
            var measurementAggregator = new MemoryMeasureAggregator();

            var result = measurementAggregator.Min(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(key, result.Name);
            Assert.AreEqual(0.0, result.Value);
        }

        [Test]
        public void Min_With_No_Current_Key_And_Filled_Elements()
        {
            const string key = "TEST1";
            var measurementAggregator = new MemoryMeasureAggregator(new CloneableDictionary<string, CloneableList<double>>()
            {
                {"TEST2", new CloneableList<double>(){5.5} }
            });

            var result = measurementAggregator.Min(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(key, result.Name);
            Assert.AreEqual(0.0, result.Value);
        }

        [Test]
        public void Min_With_Existing_Current_Key()
        {
            const string key = "TEST1";
            var measurementAggregator = new MemoryMeasureAggregator(new CloneableDictionary<string, CloneableList<double>>()
            {
                {key, new CloneableList<double>(){-2, -3, 13,  6, 10, 11 ,12} }
            });

            var result = measurementAggregator.Min(key);

            Assert.IsNotNull(result);
            Assert.AreEqual(key, result.Name);
            Assert.AreEqual(-3, result.Value);
        }

        [Test]
        public void GetFirstAverage_No_Elements()
        {
            var measurementAggregator = new MemoryMeasureAggregator();

            var result = measurementAggregator.GetFirstAverage();

            Assert.IsNull(result);
        }

        [Test]
        public void GetFirstAverage_Not_Empty_List()
        {
            var measurementAggregator = new MemoryMeasureAggregator(new CloneableDictionary<string, CloneableList<double>>
            {
                {"TEST", new CloneableList<double>(){5,6} },
                {"TEST2", new CloneableList<double>(){10, 11} }
            });
            var result = measurementAggregator.GetFirstAverage();

            Assert.IsNotNull(result);
            Assert.AreEqual("TEST", result.Name);
            Assert.AreEqual(5.5, result.Value);
        }

        [Test]
        public void Average_With_No_Elements()
        {
            var measuremenetAggregator = new MemoryMeasureAggregator();

            var result = measuremenetAggregator.Average();

            Assert.IsNotNull(result);
            Assert.IsNull(result.GetEnumerator().Current);
        }

        [Test]
        public void Average_With_Elements()
        {
            var measurementAggregator = new MemoryMeasureAggregator(new CloneableDictionary<string, CloneableList<double>>()
            {
                {"TEST1", new CloneableList<double>(){4,6} },
                {"TEST2", new CloneableList<double>(){2,4} }
            });

            var result = measurementAggregator.Average();
            var measurements = result as Measurement[] ?? result.ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual("TEST1", measurements.ToArray()[0].Name);
            Assert.AreEqual("TEST2", measurements.ToArray()[1].Name);
            Assert.AreEqual(5, measurements.ToArray()[0].Value);
        }

        [Test]
        public void GetKeys_No_Elements()
        {
            var measureAggregator = new MemoryMeasureAggregator();
            var result = measureAggregator.GetKeys();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void GetKeys_Filled_Elements()
        {
            var measurementAggregator = new MemoryMeasureAggregator(new CloneableDictionary<string, CloneableList<double>>()
            {
                {"TEST1", new CloneableList<double>(){4,6} },
                {"TEST2", new CloneableList<double>(){2,4} }
            });
            var result = measurementAggregator.GetKeys();

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("TEST1", result[0]);
            Assert.AreEqual("TEST2", result[1]);
        }


    }
}
