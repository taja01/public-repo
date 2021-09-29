using Microsoft.Extensions.Configuration;
using System;

namespace ConfigExample
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }
        static void Main(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            Console.WriteLine("Hello World!");
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{env}.json", optional: true);

            Configuration = builder.Build();


            Console.WriteLine(Configuration["WhereIam"]);
        }
    }
}
