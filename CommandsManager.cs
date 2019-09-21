using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Idea
{
    public class CommandsManager
    {
        public IDictionary<string, ICommand> GetCommands()
        {
            return GetTypesWithHelpAttribute(Assembly.GetAssembly(typeof(ICommand))).
                ToDictionary(type => type.GetCustomAttribute<RegisterCommandAttribute>().CommandName, 
                    type => (ICommand) Activator.CreateInstance(type));
        }

        private IEnumerable<Type> GetTypesWithHelpAttribute(Assembly assembly)
        {
            return assembly.GetTypes().Where(type => type.GetCustomAttributes<RegisterCommandAttribute>().Any());
        }
    }
}
