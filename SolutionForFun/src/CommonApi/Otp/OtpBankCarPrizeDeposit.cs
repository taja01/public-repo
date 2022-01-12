using CommonApi.Otp.ResponseDto;
using RestSharp;
using System.Threading.Tasks;

namespace CommonApi.Otp
{
    public class OtpBankCarPrizeDeposit : AbstractService
    {
        public OtpBankCarPrizeDeposit() : base("https://www.otpbank.hu/apps/composite/api")
        {
        }

        public Task<RestResponse<CarsWeepStakesResponse>> GetCarsweepstake(string number)
        {
            var header = new HeaderParameter("Accept", "application/json");

            return GetAsync<CarsWeepStakesResponse>($"carsweepstakes/check/{number}", new[] { header });
        }
    }
}
