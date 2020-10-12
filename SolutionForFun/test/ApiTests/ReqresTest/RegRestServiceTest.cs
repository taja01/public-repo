using CommonApi.Reqres;
using NUnit.Framework;
using System.Net;

namespace ApiTests.ReqresTest
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
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

        [Test]
        public void Test3_10()
        {
            var response = service.GetDelayedUsers2(10); //intentional

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
            //Assert.That(response.Duration.TotalSeconds, Is.LessThan(5), "Long execute");

        }

        [Test]
        public void Test3_3()
        {
            var response = service.GetDelayedUsers2(3);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public void Test3_4()
        {
            var response = service.GetDelayedUsers2(4); //intentional

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
            //Assert.That(response.Duration.TotalSeconds, Is.LessThan(5), "Long execute");

        }

        [Test]
        public void Test3_13()
        {
            var response = service.GetDelayedUsers2(13);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public void Test3_5()
        {
            var response = service.GetDelayedUsers2(5);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

    }
}