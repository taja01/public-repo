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
            var response = service.GetDelayedUsers(10);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public void Test3_3()
        {
            var response = service.GetDelayedUsers(3);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public void Test3_4()
        {
            var response = service.GetDelayedUsers(4);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public void Test3_13()
        {
            var response = service.GetDelayedUsers(13);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public void Test3_5()
        {
            var response = service.GetDelayedUsers(5);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public void Test4_6()
        {
            var response = service.GetDelayedUsers(6); //intentional
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
            //Assert.That(response.Duration.TotalSeconds, Is.LessThan(5), "Long execute");
        }
    }
}