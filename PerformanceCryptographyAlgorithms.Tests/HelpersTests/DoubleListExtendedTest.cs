using System;
using System.Collections.Generic;
using NUnit.Framework;
using PerformanceCryptographyAlgorithms.Helpers;

namespace PerformanceCryptographyAlgorithms.Tests.HelpersTests
{
    [TestFixture]
    public class DoubleListExtendedTest
    {
        [Test]
        public void Median_With_One_Item_In_List()
        {
            var input = new List<double> { 3.0d };
            var median = input.Median();
            Assert.AreEqual(3.0d, median);
        }

        [Test]
        public void Median_With_Two_Items_In_List()
        {
            var input = new List<double> {10.5d, 2.0d};
            var median = input.Median();
            Assert.AreEqual(6.25d, median);
        }

        [Test]
        public void Median_With_Three_Items_In_List()
        {
            var input = new List<double> { 10.5d, 2.0d, 7d };
            var median = input.Median();
            Assert.AreEqual(7d, median);
        }

        [Test]
        public void Median_With_Three_Items_And_Two_The_Same()
        {
            var input = new List<double> { 10.5d, 2.0d, 2.0d };
            var median = input.Median();
            Assert.AreEqual(2.0d, median);
        }

        [Test]
        public void Median_Without_Any_Items()
        {
            var input = new List<double>();
            var ex = Assert.Throws<ArgumentException>(() => input.Median());
            Assert.AreEqual("Median of empty array not defined.", ex.Message);
        }

        [Test]
        public void Median__With_Null_List()
        {
            var ex = Assert.Throws<ArgumentException>(() => ((List<double>) null).Median());
            Assert.AreEqual("Median of empty array not defined.", ex.Message);
        }

        [Test]
        public void StandardDeviation_With_One_Item_In_List()
        {
            var input = new List<double> { 9.0d };
            var standardDeviation = input.StandardDeviation();
            Assert.AreEqual(0.0d, standardDeviation);
        }

        [Test]
        public void StandardDeviation_With_Two_Items_In_List()
        {
            const double precision = 0.00001;
            var input = new List<double> { 5d, -8d};
            var standardDeviation = input.StandardDeviation();
            Assert.AreEqual(6.5, standardDeviation, precision);
        }

        [Test]
        public void StandardDeviation_With_Ten_Items_In_List()
        {
            const double precision = 0.00001;
            var input = new List<double> { 5d, -8d, 10d, -30d, 12d, 77d, -20d, 3d, 4d, 11d };
            var standardDeviation = input.StandardDeviation();
            Assert.AreEqual(27.01555d, standardDeviation, precision);
        }

        [Test]
        public void StandardDeviation_With_No_Items_In_List()
        {
            var input = new List<double>();
            var ex = Assert.Throws<ArgumentException>(() => input.StandardDeviation());
            Assert.AreEqual("Standard Deviation of empty array not defined.", ex.Message);
        }

        [Test]
        public void StandardDeviation_With_Null_List()
        {
            var ex = Assert.Throws<ArgumentException>(() => ((List<double>) null).StandardDeviation());
            Assert.AreEqual("Standard Deviation of empty array not defined.", ex.Message);

        }
    }
}
