using CommonApi.Regres;
using NUnit.Framework;
using System.Net;

namespace ApiTests.RegresTest
{
    [TestFixture]
    public class RegrestServiceTest
    {
        private ReqresInService service;

        [OneTimeSetUp]
        public void Setup()
        {
            service = new ReqresInService();
        }

        [Test]
        public void Test1()
        {
            var response = service.GetUser("2");

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.User.Id, Is.EqualTo(2));
        }

        [Test]
        public void Test2()
        {
            var response = service.GetUserList();

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

    }
}