using System;

namespace Idea
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Simulating args
            var arguments = new[] { "--quiet-mode", "-s", "1000" };
            var options = new CommandLineOptions();

            CommandLineOptionsParser.Parse(arguments, options);

            if(options.QuietMode)
            {
                Console.WriteLine("shut the fuck up");
            }

            Console.ReadLine();
        }
    }
}
