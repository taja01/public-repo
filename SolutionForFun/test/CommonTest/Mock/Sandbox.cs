using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace CommonTest.Mock
{
    [TestFixture]
    public class Sandbox
    {
        public class ResponseDto
        {
            public IDictionary<string, bool> AllowedRoutes { get; set; }
        }

        private static List<Mock<ResponseDto>> TestData
        {
            get
            {
                var data = new List<Mock<ResponseDto>>();

                var d1 = new Mock<ResponseDto>();
                var dict1 = new Mock<IDictionary<string, bool>>();
                dict1.SetupGet(r => r["main"]).Returns(true);
                dict1.Setup(r => r.ContainsKey("main")).Returns(true);
                dict1.SetupGet(r => r["vip"]).Returns(false);
                dict1.SetupGet(r => r["blog"]).Throws<KeyNotFoundException>();
                d1.Object.AllowedRoutes = dict1.Object;
                data.Add(d1);
                return data;
            }
        }

        [Test, TestCaseSource(nameof(TestData))]
        public void TestMethod(Mock<ResponseDto> response)
        {
            Assert.IsTrue(response.Object.AllowedRoutes["main"]);
            Assert.IsTrue(response.Object.AllowedRoutes.ContainsKey("main"));
            Assert.Throws<KeyNotFoundException>(() => _ = response.Object.AllowedRoutes["blog"]);
        }
    }
}
