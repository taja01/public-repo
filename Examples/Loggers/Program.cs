using Loggers;
using Serilog;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loggerConfig = new LoggerConfiguration();

            loggerConfig
                .MinimumLevel.Debug()
                .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day);

            var logger = loggerConfig.CreateLogger();

            logger.Information("Program Start");

            var dog = new Dog("Rex", "Black", "GermanSheppard");

            logger.Warning("Dog created: {@dog}, output dog: {@dog}", dog, dog);

            try
            {
                var wrongIndex = dog.Name[100];
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception throw");
            }

            logger.Information(messageTemplate: "Program End");
        }
    }
}