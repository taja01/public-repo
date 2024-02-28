using CommandLine;

namespace AsyncToolBoilerTemplate.Services
{
    internal class CommandLineOptions
    {
        [Option('e', "environment", Required = false, HelpText = "The runtime environment (eg.: Development, DEV, UAT, Production).")]
        public string Environment { get; set; }

        [Option('s', "service", Required = true, HelpText = "Select your service")]

        public string? ServiceType { get; internal set; }

        [Option('t', "threads", Required = false, Default = 1, HelpText = "Set number of threads")]
        public int NumberOfThreads { get; internal set; }
    }
}
