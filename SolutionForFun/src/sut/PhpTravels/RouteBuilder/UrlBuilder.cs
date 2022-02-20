using System;
using Zelenium.Core.Interfaces;

namespace PhpTravels.RouteBuilder
{
    public class UrlBuilder : IRouteBuilder<Route>
    {
        string IRouteBuilder<Route>.GetUrl(Route page) => page switch
        {
            Route.MainPage => "https://phptravels.com/",
            Route.DemoPage => "https://phptravels.com/demo",
            Route.PricingPage => "https://phptravels.com/order",
            Route.DocsPage => "https://docs.phptravels.com/",
            Route.LoginPage => "https://www.phptravels.net/login",
            _ => throw new NotImplementedException($"Please implement '{page}'!"),
        };
    }
}
