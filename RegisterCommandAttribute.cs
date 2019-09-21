using System;

namespace Idea
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class RegisterCommandAttribute : Attribute
    {
        public string CommandName { get; set; }

        public RegisterCommandAttribute(string commandName)
        {
            CommandName = commandName;
        }
    }
}
