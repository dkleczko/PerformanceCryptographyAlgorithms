using System;
using System.Collections.Generic;
using NUnit.Framework;
using PerformanceCryptographyAlgorithms.Helpers;

namespace PerformanceCryptographyAlgorithms.Tests.HelpersTests
{
    [TestFixture]
    public class CsvExportTests
    {
        [Test]
        public void Export_Without_Inline_Headers_One_Item_In_List()
        {
            var list = new List<CsvExportModel>()
            {
                new CsvExportModel()
                {
                    Name = "User",
                    DateOfBirth = new DateTime(1990, 01, 03),
                    Height = 185,
                    Weight = 85.5
                }
            };
            var csvExport = new CsvExport<CsvExportModel>(list);
            var result = csvExport.Export(false);

            Assert.AreEqual("User,185,\"85,5\",1990-01-03\r\n", result);
        }

        [Test]
        public void Export_With_Inline_Headers_One_Item_In_List()
        {
            var list = new List<CsvExportModel>()
            {
                new CsvExportModel()
                {
                    Name = "User",
                    DateOfBirth = new DateTime(1990, 01, 03),
                    Height = 185,
                    Weight = 85.5
                }
            };
            var csvExport = new CsvExport<CsvExportModel>(list);
            var result = csvExport.Export(true);

            Assert.AreEqual("Name,Height,Weight,DateOfBirth\r\n" +
                            "User,185,\"85,5\",1990-01-03\r\n", result);
        }

        [Test]
        public void Export_With_Null_Value()
        {
            var list = new List<CsvExportModel>()
            {
                new CsvExportModel()
                {
                    Name = "User",
                    DateOfBirth = new DateTime(1990, 01, 03),
                    Height = 185,
                    Weight = null
                }
            };
            var csvExport = new CsvExport<CsvExportModel>(list);
            var result = csvExport.Export(false);

            Assert.AreEqual("User,185,,1990-01-03\r\n", result);
        }

        [Test]
        public void Export_String_With_Quotation_Mark()
        {
            var list = new List<CsvExportModel>()
            {
                new CsvExportModel()
                {
                    Name = "User \"TEST\"",
                    DateOfBirth = new DateTime(1990, 01, 03),
                    Height = 185,
                    Weight = null
                }
            };
            var csvExport = new CsvExport<CsvExportModel>(list);
            var result = csvExport.Export(false);

            Assert.AreEqual("\"User \"\"TEST\"\"\",185,,1990-01-03\r\n", result);
        }

        [Test]
        public void Export_Empty_List()
        {
            var list = new List<CsvExportModel>();
            var csvExport = new CsvExport<CsvExportModel>(list);
            var result = csvExport.Export(false);

            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void Export_Null_List()
        {
            var csvExport = new CsvExport<CsvExportModel>(null);
            var result = csvExport.Export(false);
            Assert.AreEqual(string.Empty, result);
        }
    }

    internal class CsvExportModel
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public double? Weight { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
