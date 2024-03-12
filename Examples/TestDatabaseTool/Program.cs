using Microsoft.Extensions.Logging;
using Serilog;

namespace TestDatabaseTool
{
    internal class Program
    {
        static async Task Main()
        {
            var runner = new Runner();
            try
            {
                await runner.RunAsync().ConfigureAwait(false);
                Console.ReadLine();
            }
            catch (Exception e)
            {
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
        }
    }
}
