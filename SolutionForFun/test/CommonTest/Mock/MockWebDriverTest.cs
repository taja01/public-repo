using Moq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MyLibraryTest.Mock
{
    [TestFixture]
    public class MockWebDriverTest
    {
        [Test]
        public void UrlTest()
        {
            var url = "https://www.index.hu";
            var driver = new Mock<IWebDriver>();
            driver.Setup(x => x.Url).Returns(url);

            Assert.AreEqual(url, driver.Object.Url);
        }
    }
}