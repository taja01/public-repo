using CommonApi.Otp;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace ApiTests.OtpTest
{
    [TestFixture]
    public class CarSweepTest
    {
        OtpBankCarPrizeDepositClient service;

        [OneTimeSetUp]
        public void Setup()
        {
            service = new OtpBankCarPrizeDepositClient();
        }

        [Test]
        public async Task WinnerTest()
        {
            var response = await service.GetCarsweepstake("650822590");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status code");

            Assert.Multiple(() =>
            {
                Assert.AreEqual("650822590", response.Data.Number, "Number");
                CollectionAssert.IsNotEmpty(response.Data.Sweepstakes, "sweepstakes is empty");
                Assert.AreEqual("2022-02-15", response.Data.Sweepstakes[0].LotDate, "LotDate");
                Assert.AreEqual("Toyota Yaris 1,0 Active 5 ajtós", response.Data.Sweepstakes[0].CarType, "CarType");
            });
        }

        [Test]
        public async Task OldWinnerTest()
        {
            var response = await service.GetCarsweepstake("201614152");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status code");

            Assert.Multiple(() =>
            {
                Assert.AreEqual("201614152", response.Data.Number, "Number");
                CollectionAssert.IsNotEmpty(response.Data.Sweepstakes, "sweepstakes is empty");
                Assert.AreEqual(null, response.Data.Sweepstakes[0].LotDate, "LotDate");
                Assert.IsEmpty(response.Data.Sweepstakes[0].CarType, "CarType");
            });
        }

        [Test]
        public async Task OldTwiceWinnerTest()
        {
            var response = await service.GetCarsweepstake("201541564");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status code");

            Assert.Multiple(() =>
            {
                Assert.AreEqual("201541564", response.Data.Number, "Number");
                CollectionAssert.IsNotEmpty(response.Data.Sweepstakes, "sweepstakes is empty");
                Assert.AreEqual(2, response.Data.Sweepstakes.Count);

                CommonApi.Otp.ResponseDto.Sweepstake firsttTime = response.Data.Sweepstakes[0];
                Assert.AreEqual("1982-11-30", firsttTime.LotDate, "LotDate");
                Assert.IsEmpty(firsttTime.CarType, "CarType");

                CommonApi.Otp.ResponseDto.Sweepstake secondTime = response.Data.Sweepstakes[1];
                Assert.AreEqual("1994-05-31", secondTime.LotDate, "LotDate");
                Assert.IsEmpty(secondTime.CarType, "CarType");
            });
        }

        [Test]
        public async Task NotWinnerTest()
        {
            var response = await service.GetCarsweepstake("0");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status code");

            Assert.Multiple(() =>
            {
                Assert.AreEqual("0", response.Data.Number, "Number");
                CollectionAssert.IsEmpty(response.Data.Sweepstakes, "sweepstakes is empty");
            });
        }
    }
}
