using RestSharp;
using System;

namespace CommonApi
{
    public class TimedRestResponse<T>
    {
        public IRestResponse<T> Response { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
