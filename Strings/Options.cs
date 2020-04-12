using CommandLine;

namespace Strings
{
    public class Options
    {
        [Option("lu", Required = false, HelpText = "Convert to lower case and underscore")]
        public bool LowerCaseAndUnderscore { get; set; }
    }
}
