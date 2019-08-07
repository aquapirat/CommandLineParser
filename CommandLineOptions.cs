namespace Idea
{
    public class CommandLineOptions
    {
        [Option("q", "quiet-mode", false, "Enables quiet mode")]
        public bool QuietMode { get; set; }

        [Option("s", "seed-random-contractors", true, "Seeds random contractors with given value")]
        public int SeedRandomContractors { get; set; }
    }
}
