using CommonApi.Otp;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace ApiTests.OtpTest
{
    [TestFixture]
    public class CarSweepTest
    {
        OtpBankCarPrizeDeposit service;

        [OneTimeSetUp]
        public void Setup()
        {
            service = new OtpBankCarPrizeDeposit();
        }

        [Test]
        public async Task Winner()
        {
            var response = await service.GetCarsweepstake("602214339 ");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status code");

            Assert.Multiple(() =>
            {
                Assert.AreEqual("602214339", response.Data.Number, "Number");
                CollectionAssert.IsNotEmpty(response.Data.Sweepstakes, "sweepstakes is empty");
                Assert.AreEqual("2021-12-15", response.Data.Sweepstakes[0].LotDate, "LotDate");
                Assert.AreEqual("Toyota Yaris 1.0 Active 5 ajtós", response.Data.Sweepstakes[0].CarType, "LotDate");
            });
        }

        [Test]
        public async Task NotWinner()
        {
            var response = await service.GetCarsweepstake("0");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status code");
            Assert.AreEqual("0", response.Data.Number, "Number");
            CollectionAssert.IsEmpty(response.Data.Sweepstakes, "sweepstakes is empty");
        }
    }
}
