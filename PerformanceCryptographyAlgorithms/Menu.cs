using System;
using PerformanceCryptographyAlgorithms.Helpers;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric.Rsa;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Hash;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Symetric;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Xor;
using PerformanceCryptographyAlgorithms.Implementation.Measure;
using PerformanceCryptographyAlgorithms.Implementation.Performance;
using PerformanceCryptographyAlgorithms.Implementation.Performance.RsaKeyLength;
using PerformanceCryptographyAlgorithms.Implementation.Proxy;
using PerformanceCryptographyAlgorithms.Static;

namespace PerformanceCryptographyAlgorithms
{
    public class Menu
    {
        public Menu()
        {
            DataToTestHelper.Create();
        }
        public void ShowMenu()
        {
            Console.WriteLine("Please select algorithms to run:");
            Console.WriteLine("1. Symetric algorithms AES and DES");
            Console.WriteLine("2. Hash algorithms MD5 and SHA");
            Console.WriteLine("3. Asymetric algorithm RSA depends on file length");
            Console.WriteLine("4. Asymetric algorithm RSA depends on key length");
            Console.WriteLine("5. Xor algorithm multithread");
            Console.WriteLine("6. All");
            Console.WriteLine("7. Exit");
            SelectNumber();
        }

        private void SelectNumber()
        {
            var number = Console.ReadKey();
            switch (number.KeyChar)
            {
                case '1':
                    RunAesAndDes();
                    break;
                case '2':
                    RunMd5AndSha();
                    break;
                case '3':
                    RunRsaFileLength();
                    break;
                case '4':
                    RunRsaKeyLength();
                    break;
                case '5':
                    RunXor();
                    break;
                case '6':
                    RunAll();
                    break;
                case '7':
                    Environment.Exit(1);
                    break;
                default:
                    ShowMenu();
                    break;

            }
            ShowMenu();

        }

        private void RunAesAndDes()
        {
            new SymetricPerformance(Proxy.Create<AesAlgorithm>()).PerformanceTest();
            new SymetricPerformance(Proxy.Create<DesAlgorithm>()).PerformanceTest();
            GenerateCsv("AesAndDes");
        }

        private void RunMd5AndSha()
        {
            new HashPerformance(Proxy.Create<Md5Algorithm>()).PerformanceTest();
            new HashPerformance(Proxy.Create<Sha1Algorithm>()).PerformanceTest();
            new HashPerformance(Proxy.Create<Sha256Algorithm>()).PerformanceTest();
            new HashPerformance(Proxy.Create<Sha384Algorithm>()).PerformanceTest();
            new HashPerformance(Proxy.Create<Sha512Algorithm>()).PerformanceTest();
            GenerateCsv("Md5andSha");

        }

        private void RunRsaFileLength()
        {
            new AsymetricPerformance(Proxy.Create<Rsa4096Key>()).PerformanceTest();
            GenerateCsv("RsaFileLength");

        }

        private void RunRsaKeyLength()
        {
            new RsaKeyLengthPerformance().PerformanceTest();
            GenerateCsv("RsaKeyLength");

        }

        private void RunXor()
        {
            var xorWithoutThreads = new XorPerformance(Proxy.Create<XorWithoutThreads>());
            xorWithoutThreads.PerformanceTest();
            var xorWithThreads = new XorPerformance(Proxy.Create<XorWithThreads>());
            xorWithThreads.PerformanceTest();
            var xorWithTaks = new XorPerformance(Proxy.Create<XorWithTasks>());
            xorWithTaks.PerformanceTest();
            GenerateCsv("Xor");

        }

        private void RunAll()
        {
            RunAesAndDes();
            RunMd5AndSha();
            RunRsaFileLength();
            RunRsaKeyLength();
            RunXor();
        }

        private void GenerateCsv(string name)
        {
            Console.WriteLine("Csv generation started...");
            Aggregator.GenerateCsv(name);
            Aggregator.MeasureAggregator = new MemoryMeasureAggregator();
        }
    }
}
