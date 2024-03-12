using Microsoft.Extensions.DependencyInjection;

namespace WebMiddleware
{
    public static class Extension
    {
        public static IServiceCollection ConfigureHttpLoggingServices(this IServiceCollection services)
        {
            services.AddTransient<LoggingHttpHandler>();
            return services;
        }
    }
}
