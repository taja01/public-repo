using RestSharp;
using System;

namespace CommonApi
{
    public class TimedRestResponse<T>
    {
        public RestResponse<T> Response { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
