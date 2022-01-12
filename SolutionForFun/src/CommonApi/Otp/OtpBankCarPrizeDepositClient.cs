using CommonApi.Otp.ResponseDto;
using RestSharp;
using System.Threading.Tasks;

namespace CommonApi.Otp
{
    public class OtpBankCarPrizeDepositClient
    {
        private readonly RestClient _restClient;
        public OtpBankCarPrizeDepositClient()
        {
            _restClient = new RestClient("https://www.otpbank.hu/apps/composite/api")
                .AddDefaultHeader(KnownHeaders.Accept, "application/json");
        }

        public Task<RestResponse<CarsWeepStakesResponse>> GetCarsweepstake(string number)
        {
            var request = new RestRequest($"carsweepstakes/check/{number}", Method.Get);
            return _restClient.ExecuteAsync<CarsWeepStakesResponse>(request);
        }
    }
}
