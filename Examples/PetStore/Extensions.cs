using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebMiddleware;

namespace PetStore
{
    public static class Extensions
    {
        public static IServiceCollection AddPetStoreClient(this IServiceCollection services, IConfiguration configuration)
        {
            var options = new PetStoreOptions();
            configuration.Bind(nameof(PetStoreOptions), options);
            services.ConfigureHttpLoggingServices();
            services.Configure<PetStoreOptions>(configuration.GetSection(nameof(PetStoreOptions)));
            services.AddHttpClient<IPetStoreClient, PetStoreClient>(c => c.BaseAddress = new Uri(options.BaseAddress))
              .AddHttpMessageHandler<LoggingHttpHandler>();

            return services;
        }
    }
}
