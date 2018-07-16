using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;
using PerformanceCryptographyAlgorithms.Abstract.Performance;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Asymetric.Rsa;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Hash;
using PerformanceCryptographyAlgorithms.Implementation.Execution.Symetric;

namespace PerformanceCryptographyAlgorithms.Tests
{
    [TestFixture]
    public class AlgorithmsTest
    {
        [Test]
        public void TestAesEncryptionAndDecryption_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            ISymetricExecution symetricExecution = new AesAlgorithm();
            var bytesEncrypted = symetricExecution.Encrypt(Encoding.ASCII.GetBytes(input));
            var bytesDecrypted = symetricExecution.Decrypt(bytesEncrypted);

            Assert.AreEqual(input, Encoding.ASCII.GetString(bytesDecrypted));
        }

        [Test]
        public void TestAesEncryptionAndDecryption_Not_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            const string input2 = "TestAesEncryptionAndDecryption TesT";
            ISymetricExecution symetricExecution = new AesAlgorithm();
            var bytesEncrypted = symetricExecution.Encrypt(Encoding.ASCII.GetBytes(input));
            var bytesEncrypted2 = symetricExecution.Encrypt(Encoding.ASCII.GetBytes(input2));
            var bytesEncrypted3 = symetricExecution.Encrypt(Encoding.ASCII.GetBytes(input));
            Assert.AreEqual(bytesEncrypted, bytesEncrypted3);
            Assert.AreNotEqual(bytesEncrypted, bytesEncrypted2);

        }

        [Test]
        public void TestDesEncryptionAndDecryption_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            ISymetricExecution symetricExecution = new DesAlgorithm();
            var bytesEncrypted = symetricExecution.Encrypt(Encoding.ASCII.GetBytes(input));
            var bytesDecrypted = symetricExecution.Decrypt(bytesEncrypted);

            Assert.AreEqual(input, Encoding.ASCII.GetString(bytesDecrypted));
        }

        [Test]
        public void TestDesEncryptionAndDecryption_Not_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            const string input2 = "TestAesEncryptionAndDecryption TesT";
            ISymetricExecution symetricExecution = new DesAlgorithm();
            var bytesEncrypted = symetricExecution.Encrypt(Encoding.ASCII.GetBytes(input));
            var bytesEncrypted2 = symetricExecution.Encrypt(Encoding.ASCII.GetBytes(input2));
            var bytesEncrypted3 = symetricExecution.Encrypt(Encoding.ASCII.GetBytes(input));
            Assert.AreEqual(bytesEncrypted, bytesEncrypted3);
            Assert.AreNotEqual(bytesEncrypted, bytesEncrypted2);

        }

        [Test]
        public void TestRsaEncryptionAndDecryption_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            IAsymetricExectuion asymetricExectution = new RsaAlgorithm(RSA.Create());
            var bytesEncrypted = asymetricExectution.Encrypt(Encoding.ASCII.GetBytes(input));
            var bytesDecrypted = asymetricExectution.Decrypt(bytesEncrypted);

            Assert.AreEqual(input, Encoding.ASCII.GetString(bytesDecrypted));
        }
        [Test]
        public void TestRsaEncryptionAndDecryption_Not_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            const string input2 = "TestAesEncryptionAndDecryption TesT";
            IAsymetricExectuion asymetricExectution = new RsaAlgorithm(RSA.Create());
            var bytesEncrypted = asymetricExectution.Encrypt(Encoding.ASCII.GetBytes(input));
            var bytesEncrypted2 = asymetricExectution.Encrypt(Encoding.ASCII.GetBytes(input2));
            var bytesEncrypted3 = asymetricExectution.Encrypt(Encoding.ASCII.GetBytes(input));
            var decrypted = asymetricExectution.Decrypt(bytesEncrypted);
            var decrypted2 = asymetricExectution.Decrypt(bytesEncrypted3);
            Assert.AreEqual(Encoding.ASCII.GetString(decrypted), Encoding.ASCII.GetString(decrypted2));
            Assert.AreNotEqual(bytesEncrypted, bytesEncrypted2);
        }

        [Test]
        public void TestMd5Encryption_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            IHashExecution execution = new Md5Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            Assert.AreEqual(test, test2);
        }
        [Test]
        public void TestMd5Encryption_Not_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            const string input2 = "TestAesEncryptionAndDecryption TesT";
            IHashExecution execution = new Md5Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input2));
            Assert.AreNotEqual(test, test2);
        }
        [Test]
        public void TestSha1Encryption_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            IHashExecution execution = new Sha1Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            Assert.AreEqual(test, test2);
        }
        [Test]
        public void TestSha1Encryption_Not_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            const string input2 = "TestAesEncryptionAndDecryption TesT";
            IHashExecution execution = new Sha1Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input2));
            Assert.AreNotEqual(test, test2);
        }

        [Test]
        public void TestSha256Encryption_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            IHashExecution execution = new Sha256Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            Assert.AreEqual(test, test2);
        }
        [Test]
        public void TestSha256Encryption_Not_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            const string input2 = "TestAesEncryptionAndDecryption TesT";
            IHashExecution execution = new Sha256Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input2));
            Assert.AreNotEqual(test, test2);
        }
        [Test]
        public void TestSha384Encryption_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            IHashExecution execution = new Sha384Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            Assert.AreEqual(test, test2);
        }
        [Test]
        public void TestSha384Encryption_Not_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            const string input2 = "TestAesEncryptionAndDecryption TesT";
            IHashExecution execution = new Sha384Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input2));
            Assert.AreNotEqual(test, test2);
        }
        [Test]
        public void TestSha512Encryption_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            IHashExecution execution = new Sha512Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            Assert.AreEqual(test, test2);
        }
        [Test]
        public void TestSha512Encryption_Not_Equals()
        {
            const string input = "TestAesEncryptionAndDecryption Test";
            const string input2 = "TestAesEncryptionAndDecryption TesT";
            IHashExecution execution = new Sha512Algorithm();
            var test = execution.Encrypt(Encoding.ASCII.GetBytes(input));
            var test2 = execution.Encrypt(Encoding.ASCII.GetBytes(input2));
            Assert.AreNotEqual(test, test2);
        }
    }
}
