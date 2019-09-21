using System;

namespace Idea
{
    [RegisterCommand(CommandsNames.Fancy)]
    public class VeryFancyCommand : ICommand
    {
        public void DoAction()
        {
            Console.WriteLine("Very Fancy Action");
        }
    }
}
