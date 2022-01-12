using CommonApi.Reqres;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace ApiTests.ReqresTest
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class RegrestServiceTest
    {
        private ReqresInServiceClient service;

        [OneTimeSetUp]
        public void Setup()
        {
            service = new ReqresInServiceClient();
        }

        [Test]
        public async Task Test1()
        {
            var response = await service.GetUser("2");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.User.Id, Is.EqualTo(2));
        }

        [Test]
        public async Task Test2()
        {
            var response = await service.GetUserList();
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public async Task Test3_10()
        {
            var response = await service.GetDelayedUsers(10);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public async Task Test3_3()
        {
            var response = await service.GetDelayedUsers(3);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public async Task Test3_4()
        {
            var response = await service.GetDelayedUsers(4);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public async Task Test3_13()
        {
            var response = await service.GetDelayedUsers(13);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public async Task Test3_5()
        {
            var response = await service.GetDelayedUsers(5);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }

        [Test]
        public async Task Test4_6()
        {
            var response = await service.GetDelayedUsers(6); //intentional
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.Users.Count, Is.GreaterThan(1));
        }
    }
}