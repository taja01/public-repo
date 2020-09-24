using CommonApi.Otp;
using NUnit.Framework;
using System.Net;

namespace ApiTests.OtTest
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
        public void Winner()
        {
            var response = service.GetCarsweepstake("601410154");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status code");
            Assert.AreEqual("601410154", response.Data.Number, "Number");
            CollectionAssert.IsNotEmpty(response.Data.Sweepstakes, "sweepstakes is empty");
            Assert.AreEqual("2020-09-15", response.Data.Sweepstakes[0].LotDate, "LotDate");
            Assert.AreEqual("Toyota Aygo 1,0 X-Comfort 5 ajtós", response.Data.Sweepstakes[0].CarType, "LotDate");
        }

        [Test]
        public void NotWinner()
        {
            var response = service.GetCarsweepstake("0");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status code");
            Assert.AreEqual("0", response.Data.Number, "Number");
            CollectionAssert.IsEmpty(response.Data.Sweepstakes, "sweepstakes is empty");
        }
    }
}
