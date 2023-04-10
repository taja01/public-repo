using CommandLine;

namespace AsyncToolBoilerTemplate.Services
{
    internal class CommandLineOptions
    {
        [Option('e', "environment", Required = false, HelpText = "The runtime environment (eg.: Development, DEV, UAT, Production).")]
        public string Environment { get; set; }
    }
}
