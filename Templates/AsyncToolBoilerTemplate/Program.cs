using AsyncToolBoilerTemplate.Services;
using CommandLine;
using Microsoft.Extensions.Logging;
using Serilog;

namespace AsyncToolBoilerTemplate
{
    internal class Program
    {
        static int Main(string[] args)
        {
            var returnCode = 0;

            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsedAsync(async o =>
                {
                    var runner = new Runner();

                    try
                    {
                        await runner.RunAsync(o).ConfigureAwait(false);
                        Console.ReadKey();
                    }
                    catch (Exception e)
                    {
                        returnCode = 1;

                        if (runner.Logger != null)
                        {
                            runner.Logger.LogError(e, "Application error.");
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }
                    finally
                    {
                        Log.CloseAndFlush();
                    }

                }).Wait();

            return returnCode;
        }
    }
}