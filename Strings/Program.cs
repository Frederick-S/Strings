using System;
using CommandLine;

namespace Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: su [option] [string]");

                return;
            }

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(options =>
                {
                    var text = args[1];

                    if (options.LowerCaseAndUnderscore)
                    {
                        Console.WriteLine(Strings.ConvertToLowerCaseAndUnderscore(text));
                    }
                });
        }
    }
}
