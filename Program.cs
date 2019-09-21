using System;
using System.Runtime.CompilerServices;

namespace Idea
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var commandsManager = new CommandsManager();
            var commands = commandsManager.GetCommands();

            foreach (var command in commands)
            {
                command.Value.DoAction();
            }

            Console.ReadLine();
        }
    }
}
