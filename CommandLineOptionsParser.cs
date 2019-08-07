using System;
using System.Linq;
using System.Reflection;

namespace Idea
{
    public class CommandLineOptionsParser
    {
        public static void Parse(string[] args, object options)
        {
            foreach(var property in options.GetType().GetProperties())
            {
                var attribute = property.GetCustomAttribute<OptionAttribute>();

                if(attribute == null)
                {
                    continue;
                }

                if(args.Any(str => str == attribute.ShortName || str == attribute.LongName))
                {
                    if(attribute.HasValue)
                    {
                        var indexedArgument = args.Select((argument, index) => new { str=argument, index }).Single(obj => obj.str == attribute.ShortName || obj.str == attribute.LongName);

                        try
                        {
                            property.SetValue(options, Convert.ChangeType(args[indexedArgument.index + 1], property.PropertyType));
                        }
                        catch(IndexOutOfRangeException)
                        {
                            Console.WriteLine($"Argument \"{args[indexedArgument.index]}\" has no value!");
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine($"Bad data for option \"{args[indexedArgument.index]}\" \nTip: {attribute.Tip}");
                        }
                    }
                    else
                    {
                        property.SetValue(options, true);
                    }
                }

            }
        }
    }
}
