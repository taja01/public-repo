using System.Collections.Generic;

namespace CommonApi.Otp.ResponseDto
{
    public class CarsWeepStakesResponse
    {
        public string Number { get; set; }
        public IList<Sweepstake> Sweepstakes { get; set; }
    }
}
