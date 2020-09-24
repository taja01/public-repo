using CommonApi.Otp.ResponseDto;
using RestSharp;

namespace CommonApi.Otp
{
    public class OtpBankCarPrizeDeposit : AbstractService
    {
        public OtpBankCarPrizeDeposit() : base("https://www.otpbank.hu/apps/composite/api")
        {
        }

        public IRestResponse<CarsWeepStakesResponse> GetCarsweepstake(string number)
        {
            return base.Get<CarsWeepStakesResponse>($"carsweepstakes/check/{number}");
        }
    }
}
