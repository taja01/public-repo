using CodeWarsTests.StringTasks;
using NUnit.Framework;

namespace CodeWarsTests.StringTests
{
    [TestFixture]
    public class DecodePassTests
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual("password123",
                Kata.DecodePass(new string[] { "password123", "admin", "admin1" },
                    "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(null,
                Kata.DecodePass(new string[] { "password321", "admin", "admin1" },
                    "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"));
        }

        [Test]
        public void SampleTest3()
        {
            Assert.AreEqual(null,
              Kata.DecodePass(new string[] { "password456", "pass1", "test12" },
                  "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"));
        }

        [Test]
        public void SampleTest4()
        {
            Assert.AreEqual("Bhpz91vHCh",
              Kata.DecodePass(new string[] { "Bhpz91vHCh", "zGOJ5dafyUl7B3xcNOu7", "mthMjdvCPX65OvJxC8Q" },
                  "1000010 1101000 1110000 1111010 111001 110001 1110110 1001000 1000011 1101000"));
        }
    }
}